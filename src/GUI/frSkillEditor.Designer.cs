/*------------------------------------------------------------------------------------
LICENSE:
------------------------------------------------------------------------------------
This file is part of EVEmu: EVE Online Server Emulator
Copyright 2006 - 2011 The EVEmu Team
For the latest information visit http://evemu.org
------------------------------------------------------------------------------------
This program is free software; you can redistribute it and/or modify it under
the terms of the GNU Lesser General Public License as published by the Free Software
Foundation; either version 2 of the License, or (at your option) any later
version.

This program is distributed in the hope that it will be useful, but WITHOUT
ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License along with
this program; if not, write to the Free Software Foundation, Inc., 59 Temple
Place - Suite 330, Boston, MA 02111-1307, USA, or go to
http://www.gnu.org/copyleft/lesser.txt.
------------------------------------------------------------------------------------
*/



namespace Evemu_DB_Editor
{
    partial class frSkillEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frSkillEditor));
            this.lblCharacterID = new System.Windows.Forms.TextBox();
            this.lblSkillID = new System.Windows.Forms.TextBox();
            this.lSkillName = new System.Windows.Forms.ComboBox();
            this.tbSkillLevel = new System.Windows.Forms.TextBox();
            this.btLevelDown = new System.Windows.Forms.Button();
            this.btLevelUp = new System.Windows.Forms.Button();
            this.tbSkillPoints = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCharacterID
            // 
            resources.ApplyResources(this.lblCharacterID, "lblCharacterID");
            this.lblCharacterID.Name = "lblCharacterID";
            this.lblCharacterID.ReadOnly = true;
            // 
            // lblSkillID
            // 
            resources.ApplyResources(this.lblSkillID, "lblSkillID");
            this.lblSkillID.Name = "lblSkillID";
            this.lblSkillID.ReadOnly = true;
            // 
            // lSkillName
            // 
            this.lSkillName.FormattingEnabled = true;
            resources.ApplyResources(this.lSkillName, "lSkillName");
            this.lSkillName.Name = "lSkillName";
            this.lSkillName.SelectedIndexChanged += new System.EventHandler(this.lSkillName_SelectedIndexChanged);
            // 
            // tbSkillLevel
            // 
            resources.ApplyResources(this.tbSkillLevel, "tbSkillLevel");
            this.tbSkillLevel.Name = "tbSkillLevel";
            this.tbSkillLevel.ReadOnly = true;
            // 
            // btLevelDown
            // 
            resources.ApplyResources(this.btLevelDown, "btLevelDown");
            this.btLevelDown.Name = "btLevelDown";
            this.btLevelDown.UseVisualStyleBackColor = true;
            this.btLevelDown.Click += new System.EventHandler(this.btLevelDown_Click);
            // 
            // btLevelUp
            // 
            resources.ApplyResources(this.btLevelUp, "btLevelUp");
            this.btLevelUp.Name = "btLevelUp";
            this.btLevelUp.UseVisualStyleBackColor = true;
            this.btLevelUp.Click += new System.EventHandler(this.btLevelUp_Click);
            // 
            // tbSkillPoints
            // 
            resources.ApplyResources(this.tbSkillPoints, "tbSkillPoints");
            this.tbSkillPoints.Name = "tbSkillPoints";
            // 
            // btSave
            // 
            resources.ApplyResources(this.btSave, "btSave");
            this.btSave.Name = "btSave";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            resources.ApplyResources(this.btCancel, "btCancel");
            this.btCancel.Name = "btCancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frSkillEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbSkillPoints);
            this.Controls.Add(this.btLevelUp);
            this.Controls.Add(this.btLevelDown);
            this.Controls.Add(this.tbSkillLevel);
            this.Controls.Add(this.lSkillName);
            this.Controls.Add(this.lblSkillID);
            this.Controls.Add(this.lblCharacterID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frSkillEditor";
            this.Load += new System.EventHandler(this.frEditSkill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLevelDown;
        private System.Windows.Forms.Button btLevelUp;
        public System.Windows.Forms.TextBox lblCharacterID;
        public System.Windows.Forms.TextBox lblSkillID;
        public System.Windows.Forms.ComboBox lSkillName;
        public System.Windows.Forms.TextBox tbSkillLevel;
        public System.Windows.Forms.TextBox tbSkillPoints;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
    }
}