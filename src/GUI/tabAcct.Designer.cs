namespace Evemu_DB_Editor.src.GUI {
    partial class tabAcct {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            "",
            ""}, -1);
            this.btSearchAccount = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbCharacterID = new System.Windows.Forms.TextBox();
            this.btAddAccount = new System.Windows.Forms.Button();
            this.lCharacterName = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lvCharacterSkills = new System.Windows.Forms.ListView();
            this.columnHeader23 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader24 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader25 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader26 = new System.Windows.Forms.ColumnHeader();
            this.mCharacterSkill = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddSkill = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lvAccounts = new System.Windows.Forms.ListView();
            this.columnHeader27 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader28 = new System.Windows.Forms.ColumnHeader();
            this.mAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.miDeleteAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.newAcctLevel = new System.Windows.Forms.ComboBox();
            this.accountTxtBox = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.newUsername = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mCharacterSkill.SuspendLayout();
            this.mAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSearchAccount
            // 
            this.btSearchAccount.Location = new System.Drawing.Point(176, 77);
            this.btSearchAccount.Name = "btSearchAccount";
            this.btSearchAccount.Size = new System.Drawing.Size(75, 23);
            this.btSearchAccount.TabIndex = 38;
            this.btSearchAccount.Text = "Search";
            this.btSearchAccount.UseVisualStyleBackColor = true;
            this.btSearchAccount.Click += new System.EventHandler(this.btSearchAccount_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Verdana", 12.25F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label40.Location = new System.Drawing.Point(573, 39);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(144, 20);
            this.label40.TabIndex = 37;
            this.label40.Text = "Character Edit";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(478, 80);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(56, 13);
            this.label39.TabIndex = 26;
            this.label39.Text = "Character:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(665, 80);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(21, 13);
            this.label36.TabIndex = 23;
            this.label36.Text = "ID:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 12.25F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label19.Location = new System.Drawing.Point(305, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "New Account";
            // 
            // tbCharacterID
            // 
            this.tbCharacterID.Location = new System.Drawing.Point(703, 77);
            this.tbCharacterID.Name = "tbCharacterID";
            this.tbCharacterID.ReadOnly = true;
            this.tbCharacterID.Size = new System.Drawing.Size(111, 20);
            this.tbCharacterID.TabIndex = 30;
            // 
            // btAddAccount
            // 
            this.btAddAccount.Location = new System.Drawing.Point(330, 236);
            this.btAddAccount.Name = "btAddAccount";
            this.btAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btAddAccount.TabIndex = 28;
            this.btAddAccount.Text = "Add";
            this.btAddAccount.UseVisualStyleBackColor = true;
            this.btAddAccount.Click += new System.EventHandler(this.btAddAccount_Click);
            // 
            // lCharacterName
            // 
            this.lCharacterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lCharacterName.FormattingEnabled = true;
            this.lCharacterName.Location = new System.Drawing.Point(540, 77);
            this.lCharacterName.Name = "lCharacterName";
            this.lCharacterName.Size = new System.Drawing.Size(119, 21);
            this.lCharacterName.TabIndex = 29;
            this.lCharacterName.SelectedIndexChanged += new System.EventHandler(this.lCharacterName_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(267, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Acct Level:";
            this.label15.Visible = false;
            // 
            // lvCharacterSkills
            // 
            this.lvCharacterSkills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26});
            this.lvCharacterSkills.ContextMenuStrip = this.mCharacterSkill;
            this.lvCharacterSkills.FullRowSelect = true;
            this.lvCharacterSkills.HideSelection = false;
            this.lvCharacterSkills.Location = new System.Drawing.Point(481, 107);
            this.lvCharacterSkills.MultiSelect = false;
            this.lvCharacterSkills.Name = "lvCharacterSkills";
            this.lvCharacterSkills.Size = new System.Drawing.Size(336, 259);
            this.lvCharacterSkills.TabIndex = 33;
            this.lvCharacterSkills.UseCompatibleStateImageBehavior = false;
            this.lvCharacterSkills.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "ID";
            this.columnHeader23.Width = 66;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Name";
            this.columnHeader24.Width = 136;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Level";
            this.columnHeader25.Width = 43;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Skillpoints";
            this.columnHeader26.Width = 86;
            // 
            // mCharacterSkill
            // 
            this.mCharacterSkill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddSkill,
            this.removeToolStripMenuItem,
            this.editToolStripMenuItem1});
            this.mCharacterSkill.Name = "characterSkillMenuStrip";
            this.mCharacterSkill.Size = new System.Drawing.Size(123, 70);
            // 
            // miAddSkill
            // 
            this.miAddSkill.Name = "miAddSkill";
            this.miAddSkill.Size = new System.Drawing.Size(122, 22);
            this.miAddSkill.Text = "Add";
            this.miAddSkill.Click += new System.EventHandler(this.miAddSkill_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.miRemoveSkill_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.miEditSkill_Click);
            // 
            // lvAccounts
            // 
            this.lvAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader27,
            this.columnHeader28});
            this.lvAccounts.ContextMenuStrip = this.mAccount;
            this.lvAccounts.FullRowSelect = true;
            this.lvAccounts.HideSelection = false;
            this.lvAccounts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvAccounts.Location = new System.Drawing.Point(17, 106);
            this.lvAccounts.MultiSelect = false;
            this.lvAccounts.Name = "lvAccounts";
            this.lvAccounts.Size = new System.Drawing.Size(234, 259);
            this.lvAccounts.TabIndex = 32;
            this.lvAccounts.UseCompatibleStateImageBehavior = false;
            this.lvAccounts.View = System.Windows.Forms.View.Details;
            this.lvAccounts.SelectedIndexChanged += new System.EventHandler(this.lvAccounts_SelectedIndexChanged);
            this.lvAccounts.Click += new System.EventHandler(this.lvAccounts_Click);
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "ID";
            this.columnHeader27.Width = 41;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Account";
            this.columnHeader28.Width = 158;
            // 
            // mAccount
            // 
            this.mAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddAccount,
            this.miEditAccount,
            this.toolStripSeparator4,
            this.miDeleteAccount});
            this.mAccount.Name = "addToEdit";
            this.mAccount.Size = new System.Drawing.Size(162, 76);
            // 
            // miAddAccount
            // 
            this.miAddAccount.Name = "miAddAccount";
            this.miAddAccount.Size = new System.Drawing.Size(161, 22);
            this.miAddAccount.Text = "Add Account";
            // 
            // miEditAccount
            // 
            this.miEditAccount.Name = "miEditAccount";
            this.miEditAccount.Size = new System.Drawing.Size(161, 22);
            this.miEditAccount.Text = "Edit Account";
            this.miEditAccount.Click += new System.EventHandler(this.miEditAccount_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // miDeleteAccount
            // 
            this.miDeleteAccount.Name = "miDeleteAccount";
            this.miDeleteAccount.Size = new System.Drawing.Size(161, 22);
            this.miDeleteAccount.Text = "Delete Account";
            this.miDeleteAccount.Click += new System.EventHandler(this.miDeleteAccount_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(267, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Password:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "Account:";
            // 
            // newAcctLevel
            // 
            this.newAcctLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newAcctLevel.Enabled = false;
            this.newAcctLevel.FormattingEnabled = true;
            this.newAcctLevel.Items.AddRange(new object[] {
            "SUPER ADMIN",
            "ADMIN",
            "GAME MASTER HIGH",
            "GAME MASTER LOW",
            "PLAYER"});
            this.newAcctLevel.Location = new System.Drawing.Point(331, 209);
            this.newAcctLevel.Name = "newAcctLevel";
            this.newAcctLevel.Size = new System.Drawing.Size(130, 21);
            this.newAcctLevel.TabIndex = 24;
            this.newAcctLevel.Visible = false;
            // 
            // accountTxtBox
            // 
            this.accountTxtBox.Location = new System.Drawing.Point(70, 78);
            this.accountTxtBox.Name = "accountTxtBox";
            this.accountTxtBox.Size = new System.Drawing.Size(100, 20);
            this.accountTxtBox.TabIndex = 20;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(331, 183);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(130, 20);
            this.newPassword.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 12.25F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label17.Location = new System.Drawing.Point(32, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Account Search";
            // 
            // newUsername
            // 
            this.newUsername.Location = new System.Drawing.Point(331, 157);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(130, 20);
            this.newUsername.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(267, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 17.25F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(341, 28);
            this.label10.TabIndex = 31;
            this.label10.Text = "Account/Character Editor";
            // 
            // tabAcct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSearchAccount);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.tbCharacterID);
            this.Controls.Add(this.lCharacterName);
            this.Controls.Add(this.lvCharacterSkills);
            this.Controls.Add(this.btAddAccount);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lvAccounts);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.accountTxtBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.newAcctLevel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.newUsername);
            this.Controls.Add(this.label13);
            this.Name = "tabAcct";
            this.Size = new System.Drawing.Size(828, 386);
            this.mCharacterSkill.ResumeLayout(false);
            this.mAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSearchAccount;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbCharacterID;
        private System.Windows.Forms.Button btAddAccount;
        private System.Windows.Forms.ComboBox lCharacterName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView lvCharacterSkills;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ListView lvAccounts;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox newAcctLevel;
        private System.Windows.Forms.TextBox accountTxtBox;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox newUsername;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip mAccount;
        private System.Windows.Forms.ToolStripMenuItem miAddAccount;
        private System.Windows.Forms.ToolStripMenuItem miEditAccount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem miDeleteAccount;
        private System.Windows.Forms.ContextMenuStrip mCharacterSkill;
        private System.Windows.Forms.ToolStripMenuItem miAddSkill;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
    }
}
