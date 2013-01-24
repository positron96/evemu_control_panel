namespace Evemu_DB_Editor
{
    partial class frAccountEditor
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
            this.btChange = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbChangePass = new System.Windows.Forms.CheckBox();
            this.cbChangeRole = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lRole = new System.Windows.Forms.ComboBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(60, 181);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 0;
            this.btChange.Text = "Change";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(95, 89);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(121, 20);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "<<Possible Error>>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(95, 115);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(121, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // cbChangePass
            // 
            this.cbChangePass.AutoSize = true;
            this.cbChangePass.Location = new System.Drawing.Point(12, 12);
            this.cbChangePass.Name = "cbChangePass";
            this.cbChangePass.Size = new System.Drawing.Size(103, 17);
            this.cbChangePass.TabIndex = 8;
            this.cbChangePass.Text = "New Password?";
            this.cbChangePass.UseVisualStyleBackColor = true;
            this.cbChangePass.CheckedChanged += new System.EventHandler(this.cbChangePass_CheckedChanged);
            // 
            // cbChangeRole
            // 
            this.cbChangeRole.AutoSize = true;
            this.cbChangeRole.Location = new System.Drawing.Point(12, 35);
            this.cbChangeRole.Name = "cbChangeRole";
            this.cbChangeRole.Size = new System.Drawing.Size(136, 17);
            this.cbChangeRole.TabIndex = 9;
            this.cbChangeRole.Text = "Change account level?";
            this.cbChangeRole.UseVisualStyleBackColor = true;
            this.cbChangeRole.Visible = false;
            this.cbChangeRole.CheckedChanged += new System.EventHandler(this.cbChangeRole_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Account Level:";
            this.label4.Visible = false;
            // 
            // lRole
            // 
            this.lRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lRole.Enabled = false;
            this.lRole.FormattingEnabled = true;
            this.lRole.Items.AddRange(new object[] {
            "SUPER ADMIN",
            "ADMIN",
            "GAME MASTER HIGH",
            "GAME MASTER LOW",
            "PLAYER"});
            this.lRole.Location = new System.Drawing.Point(95, 141);
            this.lRole.Name = "lRole";
            this.lRole.Size = new System.Drawing.Size(121, 21);
            this.lRole.TabIndex = 11;
            this.lRole.Visible = false;
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(95, 65);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.ReadOnly = true;
            this.tbUserID.Size = new System.Drawing.Size(121, 20);
            this.tbUserID.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "User ID:";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(141, 181);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 14;
            this.btClose.Text = "Cancel";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frAccountEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 216);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbChangeRole);
            this.Controls.Add(this.cbChangePass);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frAccountEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbChangePass;
        private System.Windows.Forms.CheckBox cbChangeRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lRole;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Button btClose;

    }
}