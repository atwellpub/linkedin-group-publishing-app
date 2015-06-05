using Bluesky;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LinkedInApp
{
    public partial class MainForm : Form
    {
        string strLoggedUser = "";
        Random random = new Random();

        List<string> lstGrouptype = new List<string> { };
        List<Group> listGroup = new List<Group> { };
        List<Group> listGroupChosse = new List<Group> { };
        private OAuthLinkedIn _oauth = new OAuthLinkedIn();
        public MainForm()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------------------------------------
        private void bntLogin_Click(object sender, EventArgs e)
        {
            bntLogin.Enabled = false;
           

            Thread loginTh = new Thread(new ThreadStart(() =>
                {
                    //If dupticate user go to begin get user group
                    bool sameUser = tbUsername.Text.Trim().Equals(strLoggedUser) ? true : false;
                    

                    this.Invoke(new MethodInvoker(() =>
                    {
                        lbUserGroup.Items.Clear();
                        lbUserGroupChosse.Items.Clear();
                    }));
                    listGroup.Clear();
                    listGroupChosse.Clear();
                    OAuthLinkedIn _oauth = new OAuthLinkedIn();

                    if (sameUser)
                    {
                        _oauth = this._oauth;
                        goto StartGetGroupInfoamtion;
                    }

                    

                    //Use deafult API key ?
                    if (!cbDefaultApi.Checked)
                    {
                        _oauth.ConsumerKey = tbApikey.Text;
                        _oauth.ConsumerSecret = tbSercetApiKey.Text;
                    }
                    //Start get token and request token
                    try
                    {
                        Logging("Starting log in to LinkedIn");
                        Logging("Get request token");
                        String requestToken = _oauth.getRequestToken();

                        Logging("Authorizaing token");
                        Logging("Log in LinkedIn with your account infomation");
                        _oauth.authorizeToken(tbUsername.Text, tbPass.Text);

                        Logging("Get your access token");
                        String accessToken = _oauth.getAccessToken();

                        Logging("Now you are logged in LinkedIn");
                        strLoggedUser = tbUsername.Text;
                    }
                    catch
                    {
                        Logging("Have a problem when logg in.Please try again !");
                        this.Invoke(new MethodInvoker(() =>
                        {
                            bntLogin.Enabled = true;
                        }));
                        return;
                    }
                    StartGetGroupInfoamtion: ;
                    foreach (string grpType in lstGrouptype)
                    {
                        #region ############ Get group infomation ############
                        bool isGetMore = true;
                        int start = 0;
                        while (isGetMore)
                        {
                            string callStr = "https://api.linkedin.com/v1/people/~/group-memberships:(group:(id,name,counts-by-category))?membership-state=" + grpType + "&start=" + (start * 10).ToString() + "&count=10";
                            string xmlRepon = _oauth.APIWebRequest("GET",callStr, null);
                            start++;
                            if (string.IsNullOrEmpty(xmlRepon))
                                return;

                            //Read repose xml and pass infomation to form
                            XmlDocument doc = new XmlDocument();
                            doc.LoadXml(xmlRepon);
                            XmlNodeList nodeList = doc.SelectNodes("//group");
                            foreach (XmlNode n in nodeList)
                            {
                                XmlNode id = n.SelectSingleNode(".//id");
                                XmlNode name = n.SelectSingleNode(".//name");
                                Group g = new Group();
                                g.Id = id.InnerText;
                                g.Name = name.InnerText;
                                this.Invoke(new MethodInvoker(() =>
                                {
                                    listGroup.Add(g);
                                    lbUserGroup.Items.Add(name.InnerText);
                                }));
                            }
                            if (nodeList.Count < 10)
                            {
                                isGetMore = false;
                            }
                        }
                        #endregion
                    }
                    this.Invoke(new MethodInvoker(() =>
                    {
                        bntLogin.Enabled = true;
                    }));

                    if(!sameUser)
                        this._oauth = _oauth;
                    Logging("Complete get all your group infomation ");

                }));
            loginTh.SetApartmentState(ApartmentState.STA);
            loginTh.Start();
        }
        //---------------------------------------------------------------------------------------------------
        private void bntAdd_Click(object sender, EventArgs e)
        {
            int index = lbUserGroup.SelectedIndex;
            if (index == -1)
                return;
            lbUserGroupChosse.Items.Add(lbUserGroup.SelectedItem.ToString());
            listGroupChosse.Add(listGroup[index]);

            lbUserGroup.Items.RemoveAt(index);
            listGroup.RemoveAt(index);
        }
        //---------------------------------------------------------------------------------------------------
        private void bntDelete_Click(object sender, EventArgs e)
        {
            int index = lbUserGroupChosse.SelectedIndex;
            if (index == -1)
                return;
            lbUserGroup.Items.Add(lbUserGroupChosse.SelectedItem.ToString());
            listGroup.Add(listGroupChosse[index]);

            lbUserGroupChosse.Items.RemoveAt(index);
            listGroupChosse.RemoveAt(index);
        }
        //---------------------------------------------------------------------------------------------------
        private void bntStartPosting_Click(object sender, EventArgs e)
        {
            bntStartPosting.Enabled = false;
            Thread mainTh = new Thread(new ThreadStart(() =>
                {
                    string links = "";
                    for (int i = 0; i < listGroupChosse.Count; i++)
                    {     
                        //Posting to group

                        string posted = PostDicussToGroup(listGroupChosse[i].Id);
                        if (posted == "Error")
                        {
                            Logging("Can't posting to " + listGroupChosse[i].Name + " group");
                            continue;
                        }
                        else
                        {
                            Logging("Complete posting to " + listGroupChosse[i].Name + " group");

                            if (posted == "NoUrlFound")
                                break;
                            //Getting post infomation

                            string str = GetPosInfomation(listGroupChosse[i].Id);

                            string[] splStr = str.Split(' ');
                            if (splStr.Length > 1)
                            {
                                listGroupChosse[i].postId = splStr[0];
                                listGroupChosse[i].postUrl = splStr[1];

                                Logging("Your post ID :" + listGroupChosse[i].postId);
                                Logging("Your post URL :" + listGroupChosse[i].postUrl);

                                links += listGroupChosse[i].postUrl + "\r\n";

                                //Flag a post as promotion

                                if (cbPromotion.Checked)
                                {
                                    string xml = "<code>promotion</code>";
                                    string reponse = _oauth.APIWebRequest("PUT", "http://api.linkedin.com/v1/posts/"+ listGroupChosse[i].postId +"/category/code", xml);
                                    Logging("Flag your post as promotion post");
                                }
                            }

                        }
                    }

                    // Write all link to link log file

                    using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "/posting_link.txt"))
                    {
                        writer.Write(links);
                        writer.Close();
                    }

                    this.Invoke(new MethodInvoker(() =>
                        {
                            bntStartPosting.Enabled = true;
                        }));
                    Logging("Complete posting to all group");
                }));
            mainTh.Start();
        }
        //-----------------------------------------------------------------------------------------------------
        private string PostDicussToGroup(string ID)
        {
            try
            {
                string postData = @"<?xml version='1.0' encoding='UTF-8'?>
                                    <post>
                                        <title>" + GetSpinString(random, tbTitle.Text) + @"</title>
                                        <summary>" + GetSpinString(random, tbSummary.Text) + @"</summary>
                                        <content>
                                                 <submitted-url>" +GetSpinString(random, tbattUrl.Text) + @"</submitted-url>
                                                 <submitted-image-url>" +GetSpinString(random, tbAttImg.Text )+ @"</submitted-image-url>
                                                 <title>" + GetSpinString(random, tbAttTitle.Text) + @"</title>
                                                 <description>" + GetSpinString(random, tbAttDes.Text) + @"</description>                                                           
                                        </content>
                                    </post>";
                string xmlRepon = _oauth.APIWebRequest("POST", "https://api.linkedin.com/v1/groups/" + ID + "/posts", postData);
                if (xmlRepon == null)
                {
                    return "NoUrlFound";
                }
            }
            catch(Exception e)
            {
                return "Error";
            }
            return "Sucess";
            
        }
        //-----------------------------------------------------------------------------------------------------
        private string GetPosInfomation(string id)
        {
            string result = "";
            try
            {
                string xmlRepon = _oauth.APIWebRequest("GET", "http://api.linkedin.com/v1/people/~/group-memberships/" + id + "/posts:(id,creator:(first-name,last-name,picture-url),title,summary,creation-timestamp,likes,comments,attachment:(image-url,content-domain,content-url,title,summary),site-group-post-url)?role=creator&category=discussion&order=recency", null);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xmlRepon);
                XmlNodeList nodeList = doc.SelectNodes("//post");
                foreach (XmlNode n in nodeList)
                {
                    XmlNode ID = n.SelectSingleNode(".//id");
                    XmlNode url = n.SelectSingleNode(".//site-group-post-url");
                    result += ID.InnerText.Trim() + " " + url.InnerText.Trim();
                }
            }
            catch
            {
            }
            return result;
        }
        //-----------------------------------------------------------------------------------------------------
        private void Logging(string log)
        {
            this.Invoke(new MethodInvoker(() =>
                {
                    tbLog.Text +="..." + log + "\r\n";
                    tbLog.SelectionStart = tbLog.Text.Length;
                    tbLog.ScrollToCaret();
                }));
        }
        //-----------------------------------------------------------------------------------------------------
        private static string GetSpinString(Random rnd, string str) {
            // Loop over string until all patterns exhausted.
            string pattern = "{[^{}]*}";
            Match m = Regex.Match(str, pattern);
            while (m.Success) {
                // Get random choice and replace pattern match.
                string seg = str.Substring(m.Index + 1, m.Length - 2);
                string[] choices = seg.Split('|');
                str = str.Substring(0, m.Index) + choices[rnd.Next(choices.Length)] + str.Substring(m.Index + m.Length);
                m = Regex.Match(str, pattern);
            }
            return str;
        }
        private void bntSavelog_Click(object sender, EventArgs e)
        {
            using(StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "/log.txt"))
            {
                writer.Write(tbLog.Text);
                writer.Close();
            }
        }
        //-----------------------------------------------------------------------------------------------------
        private void GroupTypeCheckedChange(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                lstGrouptype.Add(cb.Tag.ToString());
            }
            else
            {
                lstGrouptype.Remove(cb.Tag.ToString());
            }
        }
        //-----------------------------------------------------------------------------------------------------

    }
    class Group
    {
        public string Name;
        public string Id;
        public string postUrl;
        public string postId;
    };
    
}
