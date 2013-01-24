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
    partial class frItemEditor
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabItemProperties = new System.Windows.Forms.TabPage();
            this.lGroup = new System.Windows.Forms.ComboBox();
            this.lMarketGroup = new System.Windows.Forms.ComboBox();
            this.btHelp = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tbChanceOfDuplicating = new System.Windows.Forms.TextBox();
            this.lbMarketGroupID = new System.Windows.Forms.TextBox();
            this.tbPublished = new System.Windows.Forms.TextBox();
            this.tbBasePrice = new System.Windows.Forms.TextBox();
            this.tbRaceID = new System.Windows.Forms.TextBox();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.tbPortionSize = new System.Windows.Forms.TextBox();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.tbGraphicID = new System.Windows.Forms.TextBox();
            this.tbMass = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbGroupID = new System.Windows.Forms.TextBox();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.lbTypeID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabItemAttributes = new System.Windows.Forms.TabPage();
            this.btAttributeAdd = new System.Windows.Forms.Button();
            this.btAttributeChange = new System.Windows.Forms.Button();
            this.tbAttributeInt = new System.Windows.Forms.TextBox();
            this.tbAttributeFloat = new System.Windows.Forms.TextBox();
            this.lblAttributeID = new System.Windows.Forms.TextBox();
            this.lAttributeName = new System.Windows.Forms.ComboBox();
            this.lvAttributes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.mAttributes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDeleteAttrib = new System.Windows.Forms.ToolStripMenuItem();
            this.tabItemEffects = new System.Windows.Forms.TabPage();
            this.btAddEffect = new System.Windows.Forms.Button();
            this.btChangeEffect = new System.Windows.Forms.Button();
            this.tbIsDefault = new System.Windows.Forms.TextBox();
            this.lblEffectID = new System.Windows.Forms.TextBox();
            this.lEffectDescription = new System.Windows.Forms.ComboBox();
            this.lvEffects = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.mEffects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDeleteEffect = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabItemProperties.SuspendLayout();
            this.tabItemAttributes.SuspendLayout();
            this.mAttributes.SuspendLayout();
            this.tabItemEffects.SuspendLayout();
            this.mEffects.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabItemProperties);
            this.tabControl1.Controls.Add(this.tabItemAttributes);
            this.tabControl1.Controls.Add(this.tabItemEffects);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 510);
            this.tabControl1.TabIndex = 11;
            // 
            // tabItemProperties
            // 
            this.tabItemProperties.Controls.Add(this.lGroup);
            this.tabItemProperties.Controls.Add(this.lMarketGroup);
            this.tabItemProperties.Controls.Add(this.btHelp);
            this.tabItemProperties.Controls.Add(this.btRefresh);
            this.tabItemProperties.Controls.Add(this.btDelete);
            this.tabItemProperties.Controls.Add(this.btSave);
            this.tabItemProperties.Controls.Add(this.tbChanceOfDuplicating);
            this.tabItemProperties.Controls.Add(this.lbMarketGroupID);
            this.tabItemProperties.Controls.Add(this.tbPublished);
            this.tabItemProperties.Controls.Add(this.tbBasePrice);
            this.tabItemProperties.Controls.Add(this.tbRaceID);
            this.tabItemProperties.Controls.Add(this.tbCapacity);
            this.tabItemProperties.Controls.Add(this.tbPortionSize);
            this.tabItemProperties.Controls.Add(this.tbVolume);
            this.tabItemProperties.Controls.Add(this.tbRadius);
            this.tabItemProperties.Controls.Add(this.tbGraphicID);
            this.tabItemProperties.Controls.Add(this.tbMass);
            this.tabItemProperties.Controls.Add(this.tbDescription);
            this.tabItemProperties.Controls.Add(this.lbGroupID);
            this.tabItemProperties.Controls.Add(this.tbTypeName);
            this.tabItemProperties.Controls.Add(this.lbTypeID);
            this.tabItemProperties.Controls.Add(this.label17);
            this.tabItemProperties.Controls.Add(this.label16);
            this.tabItemProperties.Controls.Add(this.label15);
            this.tabItemProperties.Controls.Add(this.label14);
            this.tabItemProperties.Controls.Add(this.label13);
            this.tabItemProperties.Controls.Add(this.label12);
            this.tabItemProperties.Controls.Add(this.label2);
            this.tabItemProperties.Controls.Add(this.label9);
            this.tabItemProperties.Controls.Add(this.label8);
            this.tabItemProperties.Controls.Add(this.label7);
            this.tabItemProperties.Controls.Add(this.label6);
            this.tabItemProperties.Controls.Add(this.label5);
            this.tabItemProperties.Controls.Add(this.label4);
            this.tabItemProperties.Controls.Add(this.label3);
            this.tabItemProperties.Location = new System.Drawing.Point(4, 22);
            this.tabItemProperties.Name = "tabItemProperties";
            this.tabItemProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabItemProperties.Size = new System.Drawing.Size(431, 484);
            this.tabItemProperties.TabIndex = 0;
            this.tabItemProperties.Text = "Item Info";
            this.tabItemProperties.UseVisualStyleBackColor = true;
            // 
            // lGroup
            // 
            this.lGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lGroup.DropDownWidth = 400;
            this.lGroup.FormattingEnabled = true;
            this.lGroup.Location = new System.Drawing.Point(233, 35);
            this.lGroup.Name = "lGroup";
            this.lGroup.Size = new System.Drawing.Size(184, 21);
            this.lGroup.TabIndex = 36;
            this.lGroup.SelectedIndexChanged += new System.EventHandler(this.lGroup_SelectedIndexChanged);
            // 
            // lMarketGroup
            // 
            this.lMarketGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lMarketGroup.DropDownWidth = 400;
            this.lMarketGroup.FormattingEnabled = true;
            this.lMarketGroup.Location = new System.Drawing.Point(233, 62);
            this.lMarketGroup.Name = "lMarketGroup";
            this.lMarketGroup.Size = new System.Drawing.Size(184, 21);
            this.lMarketGroup.TabIndex = 35;
            this.lMarketGroup.SelectedIndexChanged += new System.EventHandler(this.lMarketGroup_SelectedIndexChanged);
            // 
            // btHelp
            // 
            this.btHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btHelp.Location = new System.Drawing.Point(245, 433);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(172, 33);
            this.btHelp.TabIndex = 34;
            this.btHelp.Text = "Information/How To";
            this.btHelp.UseVisualStyleBackColor = true;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btRefresh.Location = new System.Drawing.Point(245, 397);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(172, 33);
            this.btRefresh.TabIndex = 33;
            this.btRefresh.Text = "Item Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btDelete.Location = new System.Drawing.Point(245, 358);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(172, 33);
            this.btDelete.TabIndex = 31;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btSave.Location = new System.Drawing.Point(245, 319);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(172, 33);
            this.btSave.TabIndex = 30;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbChanceOfDuplicating
            // 
            this.tbChanceOfDuplicating.Location = new System.Drawing.Point(133, 112);
            this.tbChanceOfDuplicating.Name = "tbChanceOfDuplicating";
            this.tbChanceOfDuplicating.Size = new System.Drawing.Size(94, 20);
            this.tbChanceOfDuplicating.TabIndex = 29;
            // 
            // lbMarketGroupID
            // 
            this.lbMarketGroupID.Location = new System.Drawing.Point(133, 62);
            this.lbMarketGroupID.Name = "lbMarketGroupID";
            this.lbMarketGroupID.ReadOnly = true;
            this.lbMarketGroupID.Size = new System.Drawing.Size(94, 20);
            this.lbMarketGroupID.TabIndex = 28;
            // 
            // tbPublished
            // 
            this.tbPublished.Location = new System.Drawing.Point(133, 88);
            this.tbPublished.Name = "tbPublished";
            this.tbPublished.Size = new System.Drawing.Size(94, 20);
            this.tbPublished.TabIndex = 27;
            // 
            // tbBasePrice
            // 
            this.tbBasePrice.Location = new System.Drawing.Point(133, 445);
            this.tbBasePrice.Name = "tbBasePrice";
            this.tbBasePrice.Size = new System.Drawing.Size(94, 20);
            this.tbBasePrice.TabIndex = 26;
            // 
            // tbRaceID
            // 
            this.tbRaceID.Location = new System.Drawing.Point(133, 419);
            this.tbRaceID.Name = "tbRaceID";
            this.tbRaceID.Size = new System.Drawing.Size(94, 20);
            this.tbRaceID.TabIndex = 25;
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(133, 368);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(94, 20);
            this.tbCapacity.TabIndex = 24;
            // 
            // tbPortionSize
            // 
            this.tbPortionSize.Location = new System.Drawing.Point(133, 393);
            this.tbPortionSize.Name = "tbPortionSize";
            this.tbPortionSize.Size = new System.Drawing.Size(94, 20);
            this.tbPortionSize.TabIndex = 23;
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(133, 342);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(94, 20);
            this.tbVolume.TabIndex = 22;
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(133, 290);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(94, 20);
            this.tbRadius.TabIndex = 21;
            // 
            // tbGraphicID
            // 
            this.tbGraphicID.Location = new System.Drawing.Point(133, 264);
            this.tbGraphicID.Name = "tbGraphicID";
            this.tbGraphicID.Size = new System.Drawing.Size(94, 20);
            this.tbGraphicID.TabIndex = 20;
            // 
            // tbMass
            // 
            this.tbMass.Location = new System.Drawing.Point(133, 316);
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(94, 20);
            this.tbMass.TabIndex = 19;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(133, 138);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(284, 120);
            this.tbDescription.TabIndex = 18;
            // 
            // lbGroupID
            // 
            this.lbGroupID.Location = new System.Drawing.Point(133, 35);
            this.lbGroupID.Name = "lbGroupID";
            this.lbGroupID.ReadOnly = true;
            this.lbGroupID.Size = new System.Drawing.Size(94, 20);
            this.lbGroupID.TabIndex = 17;
            // 
            // tbTypeName
            // 
            this.tbTypeName.Location = new System.Drawing.Point(233, 9);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.Size = new System.Drawing.Size(184, 20);
            this.tbTypeName.TabIndex = 16;
            // 
            // lbTypeID
            // 
            this.lbTypeID.Location = new System.Drawing.Point(133, 9);
            this.lbTypeID.Name = "lbTypeID";
            this.lbTypeID.ReadOnly = true;
            this.lbTypeID.Size = new System.Drawing.Size(94, 20);
            this.lbTypeID.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 396);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Portion Size:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 448);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Base Price:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Mass:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Race ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Description:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Published:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Group ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Capacity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Market Group:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Graphic ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Chance Of Duplicating:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Volume:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Radius:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item:";
            // 
            // tabItemAttributes
            // 
            this.tabItemAttributes.Controls.Add(this.btAttributeAdd);
            this.tabItemAttributes.Controls.Add(this.btAttributeChange);
            this.tabItemAttributes.Controls.Add(this.tbAttributeInt);
            this.tabItemAttributes.Controls.Add(this.tbAttributeFloat);
            this.tabItemAttributes.Controls.Add(this.lblAttributeID);
            this.tabItemAttributes.Controls.Add(this.lAttributeName);
            this.tabItemAttributes.Controls.Add(this.lvAttributes);
            this.tabItemAttributes.Location = new System.Drawing.Point(4, 22);
            this.tabItemAttributes.Name = "tabItemAttributes";
            this.tabItemAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabItemAttributes.Size = new System.Drawing.Size(431, 484);
            this.tabItemAttributes.TabIndex = 1;
            this.tabItemAttributes.Text = "Item Attributes";
            this.tabItemAttributes.UseVisualStyleBackColor = true;
            this.tabItemAttributes.Enter += new System.EventHandler(this.tabItemAttributes_Enter);
            // 
            // btAttributeAdd
            // 
            this.btAttributeAdd.Location = new System.Drawing.Point(297, 447);
            this.btAttributeAdd.Name = "btAttributeAdd";
            this.btAttributeAdd.Size = new System.Drawing.Size(52, 23);
            this.btAttributeAdd.TabIndex = 38;
            this.btAttributeAdd.Text = "Add";
            this.btAttributeAdd.UseVisualStyleBackColor = true;
            this.btAttributeAdd.Click += new System.EventHandler(this.btAttributeAdd_Click);
            // 
            // btAttributeChange
            // 
            this.btAttributeChange.Location = new System.Drawing.Point(355, 447);
            this.btAttributeChange.Name = "btAttributeChange";
            this.btAttributeChange.Size = new System.Drawing.Size(52, 23);
            this.btAttributeChange.TabIndex = 37;
            this.btAttributeChange.Text = "Change";
            this.btAttributeChange.UseVisualStyleBackColor = true;
            this.btAttributeChange.Click += new System.EventHandler(this.btAttributeChange_Click);
            // 
            // tbAttributeInt
            // 
            this.tbAttributeInt.Location = new System.Drawing.Point(175, 448);
            this.tbAttributeInt.Name = "tbAttributeInt";
            this.tbAttributeInt.Size = new System.Drawing.Size(54, 20);
            this.tbAttributeInt.TabIndex = 36;
            // 
            // tbAttributeFloat
            // 
            this.tbAttributeFloat.Location = new System.Drawing.Point(235, 448);
            this.tbAttributeFloat.Name = "tbAttributeFloat";
            this.tbAttributeFloat.Size = new System.Drawing.Size(54, 20);
            this.tbAttributeFloat.TabIndex = 35;
            // 
            // lblAttributeID
            // 
            this.lblAttributeID.Location = new System.Drawing.Point(6, 448);
            this.lblAttributeID.Name = "lblAttributeID";
            this.lblAttributeID.ReadOnly = true;
            this.lblAttributeID.Size = new System.Drawing.Size(47, 20);
            this.lblAttributeID.TabIndex = 34;
            // 
            // lAttributeName
            // 
            this.lAttributeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.lAttributeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lAttributeName.FormattingEnabled = true;
            this.lAttributeName.Location = new System.Drawing.Point(59, 447);
            this.lAttributeName.Name = "lAttributeName";
            this.lAttributeName.Size = new System.Drawing.Size(110, 21);
            this.lAttributeName.TabIndex = 33;
            this.lAttributeName.SelectedIndexChanged += new System.EventHandler(this.lAttributeName_SelectedIndexChanged);
            // 
            // lvAttributes
            // 
            this.lvAttributes.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAttributes.ContextMenuStrip = this.mAttributes;
            this.lvAttributes.FullRowSelect = true;
            this.lvAttributes.HideSelection = false;
            this.lvAttributes.Location = new System.Drawing.Point(6, 6);
            this.lvAttributes.MultiSelect = false;
            this.lvAttributes.Name = "lvAttributes";
            this.lvAttributes.Size = new System.Drawing.Size(419, 435);
            this.lvAttributes.TabIndex = 12;
            this.lvAttributes.UseCompatibleStateImageBehavior = false;
            this.lvAttributes.View = System.Windows.Forms.View.Details;
            this.lvAttributes.SelectedIndexChanged += new System.EventHandler(this.lvAttributes_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AttributeID";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Attribute";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Integer";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Float";
            this.columnHeader4.Width = 50;
            // 
            // mAttributes
            // 
            this.mAttributes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeleteAttrib});
            this.mAttributes.Name = "itemAttributeContext";
            this.mAttributes.Size = new System.Drawing.Size(113, 26);
            // 
            // miDeleteAttrib
            // 
            this.miDeleteAttrib.Name = "miDeleteAttrib";
            this.miDeleteAttrib.Size = new System.Drawing.Size(112, 22);
            this.miDeleteAttrib.Text = "Delete";
            this.miDeleteAttrib.Click += new System.EventHandler(this.miDeleteAttribute_Click);
            // 
            // tabItemEffects
            // 
            this.tabItemEffects.Controls.Add(this.btAddEffect);
            this.tabItemEffects.Controls.Add(this.btChangeEffect);
            this.tabItemEffects.Controls.Add(this.tbIsDefault);
            this.tabItemEffects.Controls.Add(this.lblEffectID);
            this.tabItemEffects.Controls.Add(this.lEffectDescription);
            this.tabItemEffects.Controls.Add(this.lvEffects);
            this.tabItemEffects.Location = new System.Drawing.Point(4, 22);
            this.tabItemEffects.Name = "tabItemEffects";
            this.tabItemEffects.Padding = new System.Windows.Forms.Padding(3);
            this.tabItemEffects.Size = new System.Drawing.Size(431, 484);
            this.tabItemEffects.TabIndex = 2;
            this.tabItemEffects.Text = "Item Effects";
            this.tabItemEffects.UseVisualStyleBackColor = true;
            this.tabItemEffects.Enter += new System.EventHandler(this.tabItemEffects_Enter);
            // 
            // btAddEffect
            // 
            this.btAddEffect.Location = new System.Drawing.Point(298, 446);
            this.btAddEffect.Name = "btAddEffect";
            this.btAddEffect.Size = new System.Drawing.Size(52, 23);
            this.btAddEffect.TabIndex = 45;
            this.btAddEffect.Text = "Add";
            this.btAddEffect.UseVisualStyleBackColor = true;
            this.btAddEffect.Click += new System.EventHandler(this.btAddEffect_Click);
            // 
            // btChangeEffect
            // 
            this.btChangeEffect.Location = new System.Drawing.Point(356, 446);
            this.btChangeEffect.Name = "btChangeEffect";
            this.btChangeEffect.Size = new System.Drawing.Size(52, 23);
            this.btChangeEffect.TabIndex = 44;
            this.btChangeEffect.Text = "Change";
            this.btChangeEffect.UseVisualStyleBackColor = true;
            // 
            // tbIsDefault
            // 
            this.tbIsDefault.Location = new System.Drawing.Point(254, 446);
            this.tbIsDefault.Name = "tbIsDefault";
            this.tbIsDefault.Size = new System.Drawing.Size(38, 20);
            this.tbIsDefault.TabIndex = 43;
            this.tbIsDefault.Text = "0";
            // 
            // lblEffectID
            // 
            this.lblEffectID.Location = new System.Drawing.Point(7, 447);
            this.lblEffectID.Name = "lblEffectID";
            this.lblEffectID.ReadOnly = true;
            this.lblEffectID.Size = new System.Drawing.Size(47, 20);
            this.lblEffectID.TabIndex = 41;
            // 
            // lEffectDescription
            // 
            this.lEffectDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.lEffectDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lEffectDescription.FormattingEnabled = true;
            this.lEffectDescription.Location = new System.Drawing.Point(60, 446);
            this.lEffectDescription.Name = "lEffectDescription";
            this.lEffectDescription.Size = new System.Drawing.Size(188, 21);
            this.lEffectDescription.TabIndex = 40;
            this.lEffectDescription.SelectedIndexChanged += new System.EventHandler(this.lEffectName_SelectedIndexChanged);
            // 
            // lvEffects
            // 
            this.lvEffects.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEffects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvEffects.ContextMenuStrip = this.mEffects;
            this.lvEffects.FullRowSelect = true;
            this.lvEffects.HideSelection = false;
            this.lvEffects.Location = new System.Drawing.Point(7, 5);
            this.lvEffects.MultiSelect = false;
            this.lvEffects.Name = "lvEffects";
            this.lvEffects.Size = new System.Drawing.Size(419, 435);
            this.lvEffects.TabIndex = 39;
            this.lvEffects.UseCompatibleStateImageBehavior = false;
            this.lvEffects.View = System.Windows.Forms.View.Details;
            this.lvEffects.SelectedIndexChanged += new System.EventHandler(this.lvEffects_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "EffectID";
            this.columnHeader5.Width = 62;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Effect";
            this.columnHeader6.Width = 253;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Is default";
            // 
            // mEffects
            // 
            this.mEffects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeleteEffect});
            this.mEffects.Name = "itemEffectContext";
            this.mEffects.Size = new System.Drawing.Size(113, 26);
            // 
            // miDeleteEffect
            // 
            this.miDeleteEffect.Name = "miDeleteEffect";
            this.miDeleteEffect.Size = new System.Drawing.Size(112, 22);
            this.miDeleteEffect.Text = "Delete";
            this.miDeleteEffect.Click += new System.EventHandler(this.miDeleteEffect_Click);
            // 
            // frItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 516);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frItemEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Name: ";
            this.Load += new System.EventHandler(this.frItemEditor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabItemProperties.ResumeLayout(false);
            this.tabItemProperties.PerformLayout();
            this.tabItemAttributes.ResumeLayout(false);
            this.tabItemAttributes.PerformLayout();
            this.mAttributes.ResumeLayout(false);
            this.tabItemEffects.ResumeLayout(false);
            this.tabItemEffects.PerformLayout();
            this.mEffects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabItemProperties;
        private System.Windows.Forms.TabPage tabItemAttributes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbChanceOfDuplicating;
        private System.Windows.Forms.TextBox lbMarketGroupID;
        private System.Windows.Forms.TextBox tbPublished;
        private System.Windows.Forms.TextBox tbBasePrice;
        private System.Windows.Forms.TextBox tbRaceID;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.TextBox tbPortionSize;
        private System.Windows.Forms.TextBox tbVolume;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.TextBox tbGraphicID;
        private System.Windows.Forms.TextBox tbMass;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox lbGroupID;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.TextBox lbTypeID;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btHelp;
        protected System.Windows.Forms.ListView lvAttributes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btAttributeAdd;
        private System.Windows.Forms.Button btAttributeChange;
        private System.Windows.Forms.TextBox tbAttributeInt;
        private System.Windows.Forms.TextBox tbAttributeFloat;
        private System.Windows.Forms.TextBox lblAttributeID;
        private System.Windows.Forms.ComboBox lAttributeName;
        private System.Windows.Forms.ComboBox lMarketGroup;
        private System.Windows.Forms.ComboBox lGroup;
        private System.Windows.Forms.TabPage tabItemEffects;
        private System.Windows.Forms.Button btAddEffect;
        private System.Windows.Forms.Button btChangeEffect;
        private System.Windows.Forms.TextBox tbIsDefault;
        private System.Windows.Forms.TextBox lblEffectID;
        private System.Windows.Forms.ComboBox lEffectDescription;
        protected System.Windows.Forms.ListView lvEffects;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip mAttributes;
        private System.Windows.Forms.ToolStripMenuItem miDeleteAttrib;
        private System.Windows.Forms.ContextMenuStrip mEffects;
        private System.Windows.Forms.ToolStripMenuItem miDeleteEffect;
    }
}