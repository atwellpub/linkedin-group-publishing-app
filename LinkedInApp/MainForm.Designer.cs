namespace LinkedInApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bntLogin = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbUserGroup = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbManager = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbOwner = new System.Windows.Forms.CheckBox();
            this.cbMember = new System.Windows.Forms.CheckBox();
            this.cbWaittingconfirm = new System.Windows.Forms.CheckBox();
            this.cbModerator = new System.Windows.Forms.CheckBox();
            this.cbParentconfirm = new System.Windows.Forms.CheckBox();
            this.cbNonmember = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.lbUserGroupChosse = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPromotion = new System.Windows.Forms.CheckBox();
            this.bntStartPosting = new System.Windows.Forms.Button();
            this.tbAttDes = new System.Windows.Forms.TextBox();
            this.tbattUrl = new System.Windows.Forms.TextBox();
            this.tbAttImg = new System.Windows.Forms.TextBox();
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.tbAttTitle = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bntSavelog = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbDefaultApi = new System.Windows.Forms.CheckBox();
            this.tbSercetApiKey = new System.Windows.Forms.TextBox();
            this.tbApikey = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntLogin
            // 
            this.bntLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLogin.Location = new System.Drawing.Point(289, 16);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(75, 53);
            this.bntLogin.TabIndex = 0;
            this.bntLogin.Text = "Getting Your Group";
            this.bntLogin.UseVisualStyleBackColor = true;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(77, 22);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(193, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(77, 55);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(193, 20);
            this.tbPass.TabIndex = 2;
            // 
            // lbUserGroup
            // 
            this.lbUserGroup.FormattingEnabled = true;
            this.lbUserGroup.Location = new System.Drawing.Point(12, 34);
            this.lbUserGroup.Name = "lbUserGroup";
            this.lbUserGroup.Size = new System.Drawing.Size(147, 212);
            this.lbUserGroup.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbManager);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbOwner);
            this.groupBox1.Controls.Add(this.cbMember);
            this.groupBox1.Controls.Add(this.cbWaittingconfirm);
            this.groupBox1.Controls.Add(this.cbModerator);
            this.groupBox1.Controls.Add(this.cbParentconfirm);
            this.groupBox1.Controls.Add(this.cbNonmember);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.bntLogin);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 205);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Getting Your LinkiedIn Group";
            // 
            // cbManager
            // 
            this.cbManager.AutoSize = true;
            this.cbManager.Location = new System.Drawing.Point(285, 111);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(68, 17);
            this.cbManager.TabIndex = 12;
            this.cbManager.Tag = "manager";
            this.cbManager.Text = "Manager";
            this.cbManager.UseVisualStyleBackColor = true;
            this.cbManager.CheckedChanged += new System.EventHandler(this.GroupTypeCheckedChange);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Select your group type :";
            // 
            // cbOwner
            // 
            this.cbOwner.AutoSize = true;
            this.cbOwner.Location = new System.Drawing.Point(120, 111);
            this.cbOwner.Name = "cbOwner";
            this.cbOwner.Size = new System.Drawing.Size(57, 17);
            this.cbOwner.TabIndex = 10;
            this.cbOwner.Tag = "owner";
            this.cbOwner.Text = "Owner";
            this.cbOwner.UseVisualStyleBackColor = true;
            this.cbOwner.CheckedChanged += new System.EventHandler(this.GroupTypeCheckedChange);
            // 
            // cbMember
            // 
            this.cbMember.AutoSize = true;
            this.cbMember.Location = new System.Drawing.Point(207, 111);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(64, 17);
            this.cbMember.TabIndex = 9;
            this.cbMember.Tag = "member";
            this.cbMember.Text = "Member";
            this.cbMember.UseVisualStyleBackColor = true;
            this.cbMember.CheckedChanged += new System.EventHandler(this.GroupTypeCheckedChange);
            // 
            // cbWaittingconfirm
            // 
            this.cbWaittingconfirm.AutoSize = true;
            this.cbWaittingconfirm.Location = new System.Drawing.Point(285, 143);
            this.cbWaittingconfirm.Name = "cbWaittingconfirm";
            this.cbWaittingconfirm.Size = new System.Drawing.Size(126, 17);
            this.cbWaittingconfirm.TabIndex = 8;
            this.cbWaittingconfirm.Tag = "awaiting-confirmation";
            this.cbWaittingconfirm.Text = "Awaiting confirmation";
            this.cbWaittingconfirm.UseVisualStyleBackColor = true;
            this.cbWaittingconfirm.CheckedChanged += new System.EventHandler(this.GroupTypeCheckedChange);
            // 
            // cbModerator
            // 
            this.cbModerator.AutoSize = true;
            this.cbModerator.Location = new System.Drawing.Point(207, 143);
            this.cbModerator.Name = "cbModerator";
            this.cbModerator.Size = new System.Drawing.Size(74, 17);
            this.cbModerator.TabIndex = 7;
            this.cbModerator.Tag = "moderator";
            this.cbModerator.Text = "Moderator";
            this.cbModerator.UseVisualStyleBackColor = true;
            this.cbModerator.CheckedChanged += new System.EventHandler(this.GroupTypeCheckedChange);
            // 
            // cbParentconfirm
            // 
            this.cbParentconfirm.AutoSize = true;
            this.cbParentconfirm.Location = new System.Drawing.Point(12, 143);
            this.cbParentconfirm.Name = "cbParentconfirm";
            this.cbParentconfirm.Size = new System.Drawing.Size(189, 17);
            this.cbParentconfirm.TabIndex = 6;
            this.cbParentconfirm.Tag = "awaiting-parent-group-confirmation";
            this.cbParentconfirm.Text = "Awaiting parent group confirmation";
            this.cbParentconfirm.UseVisualStyleBackColor = true;
            this.cbParentconfirm.CheckedChanged += new System.EventHandler(this.GroupTypeCheckedChange);
            // 
            // cbNonmember
            // 
            this.cbNonmember.AutoSize = true;
            this.cbNonmember.Location = new System.Drawing.Point(12, 111);
            this.cbNonmember.Name = "cbNonmember";
            this.cbNonmember.Size = new System.Drawing.Size(86, 17);
            this.cbNonmember.TabIndex = 5;
            this.cbNonmember.Tag = "non-member";
            this.cbNonmember.Text = "Non member";
            this.cbNonmember.UseVisualStyleBackColor = true;
            this.cbNonmember.CheckedChanged += new System.EventHandler(this.GroupTypeCheckedChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passwords :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bntDelete);
            this.groupBox2.Controls.Add(this.bntAdd);
            this.groupBox2.Controls.Add(this.lbUserGroupChosse);
            this.groupBox2.Controls.Add(this.lbUserGroup);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 257);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chosse your groups";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Target Groups";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your groups";
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(165, 121);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 6;
            this.bntDelete.Text = "<<<";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(165, 92);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 5;
            this.bntAdd.Text = ">>>";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // lbUserGroupChosse
            // 
            this.lbUserGroupChosse.FormattingEnabled = true;
            this.lbUserGroupChosse.Location = new System.Drawing.Point(246, 34);
            this.lbUserGroupChosse.Name = "lbUserGroupChosse";
            this.lbUserGroupChosse.Size = new System.Drawing.Size(147, 212);
            this.lbUserGroupChosse.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbPromotion);
            this.groupBox3.Controls.Add(this.bntStartPosting);
            this.groupBox3.Controls.Add(this.tbAttDes);
            this.groupBox3.Controls.Add(this.tbattUrl);
            this.groupBox3.Controls.Add(this.tbAttImg);
            this.groupBox3.Controls.Add(this.tbSummary);
            this.groupBox3.Controls.Add(this.tbAttTitle);
            this.groupBox3.Controls.Add(this.tbTitle);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(429, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 357);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Start posting";
            // 
            // cbPromotion
            // 
            this.cbPromotion.AutoSize = true;
            this.cbPromotion.Location = new System.Drawing.Point(136, 255);
            this.cbPromotion.Name = "cbPromotion";
            this.cbPromotion.Size = new System.Drawing.Size(73, 17);
            this.cbPromotion.TabIndex = 20;
            this.cbPromotion.Text = "Promotion";
            this.cbPromotion.UseVisualStyleBackColor = true;
            // 
            // bntStartPosting
            // 
            this.bntStartPosting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntStartPosting.Location = new System.Drawing.Point(136, 280);
            this.bntStartPosting.Name = "bntStartPosting";
            this.bntStartPosting.Size = new System.Drawing.Size(202, 56);
            this.bntStartPosting.TabIndex = 19;
            this.bntStartPosting.Text = "Start posting ";
            this.bntStartPosting.UseVisualStyleBackColor = true;
            this.bntStartPosting.Click += new System.EventHandler(this.bntStartPosting_Click);
            // 
            // tbAttDes
            // 
            this.tbAttDes.Location = new System.Drawing.Point(136, 221);
            this.tbAttDes.Name = "tbAttDes";
            this.tbAttDes.Size = new System.Drawing.Size(202, 20);
            this.tbAttDes.TabIndex = 18;
            // 
            // tbattUrl
            // 
            this.tbattUrl.Location = new System.Drawing.Point(136, 127);
            this.tbattUrl.Name = "tbattUrl";
            this.tbattUrl.Size = new System.Drawing.Size(202, 20);
            this.tbattUrl.TabIndex = 17;
            // 
            // tbAttImg
            // 
            this.tbAttImg.Location = new System.Drawing.Point(136, 187);
            this.tbAttImg.Name = "tbAttImg";
            this.tbAttImg.Size = new System.Drawing.Size(202, 20);
            this.tbAttImg.TabIndex = 15;
            // 
            // tbSummary
            // 
            this.tbSummary.Location = new System.Drawing.Point(136, 48);
            this.tbSummary.Multiline = true;
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Size = new System.Drawing.Size(202, 71);
            this.tbSummary.TabIndex = 14;
            // 
            // tbAttTitle
            // 
            this.tbAttTitle.Location = new System.Drawing.Point(136, 157);
            this.tbAttTitle.Name = "tbAttTitle";
            this.tbAttTitle.Size = new System.Drawing.Size(202, 20);
            this.tbAttTitle.TabIndex = 12;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(136, 22);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(202, 20);
            this.tbTitle.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Attachment Image URL :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Attachment Title :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Attachment Description :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Attachment URL :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Summary :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bntSavelog);
            this.groupBox4.Controls.Add(this.tbLog);
            this.groupBox4.Location = new System.Drawing.Point(12, 491);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(773, 144);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Procesing log";
            // 
            // bntSavelog
            // 
            this.bntSavelog.Location = new System.Drawing.Point(680, 115);
            this.bntSavelog.Name = "bntSavelog";
            this.bntSavelog.Size = new System.Drawing.Size(75, 23);
            this.bntSavelog.TabIndex = 1;
            this.bntSavelog.Text = "Save log";
            this.bntSavelog.UseVisualStyleBackColor = true;
            this.bntSavelog.Click += new System.EventHandler(this.bntSavelog_Click);
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.Color.Black;
            this.tbLog.ForeColor = System.Drawing.Color.White;
            this.tbLog.Location = new System.Drawing.Point(10, 19);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(664, 119);
            this.tbLog.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbDefaultApi);
            this.groupBox5.Controls.Add(this.tbSercetApiKey);
            this.groupBox5.Controls.Add(this.tbApikey);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(429, 385);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(356, 100);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "LinkedIn Api";
            // 
            // cbDefaultApi
            // 
            this.cbDefaultApi.AutoSize = true;
            this.cbDefaultApi.Checked = true;
            this.cbDefaultApi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultApi.Location = new System.Drawing.Point(142, 70);
            this.cbDefaultApi.Name = "cbDefaultApi";
            this.cbDefaultApi.Size = new System.Drawing.Size(140, 17);
            this.cbDefaultApi.TabIndex = 4;
            this.cbDefaultApi.Text = "Use default Api account";
            this.cbDefaultApi.UseVisualStyleBackColor = true;
            // 
            // tbSercetApiKey
            // 
            this.tbSercetApiKey.Location = new System.Drawing.Point(111, 38);
            this.tbSercetApiKey.Name = "tbSercetApiKey";
            this.tbSercetApiKey.Size = new System.Drawing.Size(227, 20);
            this.tbSercetApiKey.TabIndex = 3;
            // 
            // tbApikey
            // 
            this.tbApikey.Location = new System.Drawing.Point(111, 13);
            this.tbApikey.Name = "tbApikey";
            this.tbApikey.Size = new System.Drawing.Size(227, 20);
            this.tbApikey.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Aapi secret key :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Api key :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 647);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkedIn Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntLogin;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.ListBox lbUserGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.ListBox lbUserGroupChosse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntStartPosting;
        private System.Windows.Forms.TextBox tbAttDes;
        private System.Windows.Forms.TextBox tbattUrl;
        private System.Windows.Forms.TextBox tbAttImg;
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.TextBox tbAttTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bntSavelog;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbDefaultApi;
        private System.Windows.Forms.TextBox tbSercetApiKey;
        private System.Windows.Forms.TextBox tbApikey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbOwner;
        private System.Windows.Forms.CheckBox cbMember;
        private System.Windows.Forms.CheckBox cbWaittingconfirm;
        private System.Windows.Forms.CheckBox cbModerator;
        private System.Windows.Forms.CheckBox cbParentconfirm;
        private System.Windows.Forms.CheckBox cbNonmember;
        private System.Windows.Forms.CheckBox cbManager;
        private System.Windows.Forms.CheckBox cbPromotion;
    }
}

