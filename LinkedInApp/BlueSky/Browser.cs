using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bluesky;
using System.Collections.Specialized;
using System.Web;
namespace LinkedInApp.BlueSky
{
    class Browser
    {
        public string Token = "";
        public string Verifier = "";
        string user;
        string pass;
        bool completeAuth = false;
        WebBrowser webBrowser = new WebBrowser();
        OAuthLinkedIn oAuth = new OAuthLinkedIn();
        public Browser(OAuthLinkedIn o,string user, string pass)
        {
            this.user = user;
            this.pass = pass;
            oAuth = o;
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Navigated += webBrowser_Navigated;
            //webBrowser.Navigating += webBrowser_Navigating;
        }

        void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (e.Url.ToString().Contains("LinkedinApp"))
            {
                string queryParams = e.Url.Query;
                if (queryParams.Length > 0)
                {
                    //Store the Token and Token Secret
                    NameValueCollection qs = HttpUtility.ParseQueryString(queryParams);
                    if (qs["oauth_token"] != null)
                    {
                        Token = qs["oauth_token"];
                    }
                    if (qs["oauth_verifier"] != null)
                    {
                        Verifier = qs["oauth_verifier"];
                    }
                }
                completeAuth = true;

            }      
        }

        //--------------------------------------------------------------------------------------------
        public void StatBrowserAuth()
        {
            webBrowser.Navigate(oAuth.AuthorizationLink);
            Sleep(10);
            ClickAByText("Not you");
            Sleep(5);
            FillInput("session_key", user);
            FillInput("session_password", pass);
            ClickByName("authorize");

            int l = 0;
            while (!completeAuth && l < 20)
            {
                l++;
                Sleep(1);
            }

            return;
            
        }
        //--------------------------------------------------------------------------------------------
        void FillInput(string name, string value)
        {
            HtmlElementCollection he = webBrowser.Document.GetElementsByTagName("input");
            foreach (HtmlElement e in he)
            {
                if (e == null)
                    continue;
                if (e.GetAttribute("name") == null)
                    continue;
                if (e.GetAttribute("name") == name)
                {
                    e.SetAttribute("value", value);
                }
            }
            
        }
        //--------------------------------------------------------------------------------------------
        void ClickByName(string name)
        {
            HtmlElementCollection he = webBrowser.Document.GetElementsByTagName("input");
            foreach (HtmlElement e in he)
            {
                if (e == null)
                    continue;
                if (e.GetAttribute("name") == null)
                    continue;
                if (e.GetAttribute("name") == name)
                {
                    e.InvokeMember("click");
                }
            }
        }
        //--------------------------------------------------------------------------------------------
        void ClickAByText(string text)
        {
            HtmlElementCollection he = webBrowser.Document.GetElementsByTagName("a");
            foreach (HtmlElement e in he)
            {
                if (e == null)
                    continue;
                if (e.InnerText == null)
                    continue;
                if (e.InnerText.Contains(text))
                {
                    e.InvokeMember("click");
                }
            }
        }
        //--------------------------------------------------------------------------------------------
        void Sleep(int second)
        {
            int m = second * 1000;
            int m2 = 0;
            while (m2 < m)
            {
                Application.DoEvents();
                m2 += 5;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }
        }
        //--------------------------------------------------------------------------------------------
        
    }
}
