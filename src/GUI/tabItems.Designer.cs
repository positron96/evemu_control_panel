namespace Evemu_DB_Editor.src.gui {
    partial class tabItems {
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
            this.label35 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lvItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label11 = new System.Windows.Forms.Label();
            this.lCategory = new System.Windows.Forms.ComboBox();
            this.btEditItem = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.mItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(195, 42);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 13);
            this.label35.TabIndex = 26;
            this.label35.Text = "Search:";
            this.label35.Visible = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(245, 38);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(101, 20);
            this.tbSearch.TabIndex = 25;
            this.tbSearch.Visible = false;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(352, 38);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 24;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Visible = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lvItems
            // 
            this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvItems.FullRowSelect = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(3, 63);
            this.lvItems.MultiSelect = false;
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(784, 290);
            this.lvItems.TabIndex = 23;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.DoubleClick += new System.EventHandler(this.lvItems_DblClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "typeID";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "typeName";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Race";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 388;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Category:";
            // 
            // lCategory
            // 
            this.lCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lCategory.FormattingEnabled = true;
            this.lCategory.Location = new System.Drawing.Point(68, 37);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(121, 21);
            this.lCategory.TabIndex = 21;
            this.lCategory.SelectedIndexChanged += new System.EventHandler(this.lCategory_SelectedIndexChanged);
            // 
            // btEditItem
            // 
            this.btEditItem.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEditItem.Location = new System.Drawing.Point(3, 359);
            this.btEditItem.Name = "btEditItem";
            this.btEditItem.Size = new System.Drawing.Size(121, 23);
            this.btEditItem.TabIndex = 20;
            this.btEditItem.Text = "Edit Item";
            this.btEditItem.UseVisualStyleBackColor = true;
            this.btEditItem.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 17.25F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(231, 28);
            this.label20.TabIndex = 19;
            this.label20.Text = "Item/Ship Editor";
            // 
            // mItems
            // 
            this.mItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCopy,
            this.miEdit,
            this.miDelete});
            this.mItems.Name = "contextItemEdit";
            this.mItems.Size = new System.Drawing.Size(142, 70);
            // 
            // miCopy
            // 
            this.miCopy.Name = "miCopy";
            this.miCopy.Size = new System.Drawing.Size(141, 22);
            this.miCopy.Text = "Copy item";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // miEdit
            // 
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(141, 22);
            this.miEdit.Text = "Edit item";
            this.miEdit.Click += new System.EventHandler(this.miEdit_Click);
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(141, 22);
            this.miDelete.Text = "Delete item";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // tabItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label35);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lCategory);
            this.Controls.Add(this.btEditItem);
            this.Controls.Add(this.label20);
            this.Name = "tabItems";
            this.Size = new System.Drawing.Size(792, 395);
            this.mItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox lCategory;
        private System.Windows.Forms.Button btEditItem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ContextMenuStrip mItems;
        private System.Windows.Forms.ToolStripMenuItem miCopy;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
    }
}
