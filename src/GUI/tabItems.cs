using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Evemu_DB_Editor.src.gui {
    public partial class tabItems : UserControl {

        public tabItems() {
            InitializeComponent();
        }

        //private void tabItemEditor_Enter(object sender, EventArgs e)
        //{
        //    if(!DBConnect.isConnected() ) {
        //        showNotConnected();
        //        return;
        //    }
        //    foreach (DataRow record in DBConnect.AQuery("SELECT CategoryName from invCategories").Rows)
        //    {
        //        CategoryDropdown.Items.Add(record[0]);
        //    }

        //}

        private void btSearch_Click(object sender, EventArgs e)
        {
            lvItems.Items.Clear();
            string SQLQuery = "SELECT invTypes.typeID, invTypes.typeName, invGroups.groupName, chrRaces.raceName, invTypes.description FROM (invCategories RIGHT JOIN (invTypes LEFT JOIN invGroups ON invTypes.groupID = invGroups.groupID) ON invCategories.categoryID = invGroups.categoryID) LEFT JOIN chrRaces ON invTypes.raceID = chrRaces.raceID WHERE (((invCategories.categoryName) = '" + lCategory.Text + "') and typeName like '%" + tbSearch.Text + "%')";

            DataTable data = DBConnect.AQuery(SQLQuery);
            String[] item = new string[data.Columns.Count];
            ListViewItem[] items = new ListViewItem[data.Rows.Count];
            int count = 0;

            foreach (DataRow row in data.Rows)
            {
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    item[i] = row[i].ToString();
                }

                ListViewItem item2 = new ListViewItem(item);
                items[count] = item2;
                count++;
            }
            lvItems.Items.AddRange(items);
        }
        
        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSearch_Click(null, null);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            itemAddEdit add = new itemAddEdit();
            add.Show();
            add.extractItemInfo(int.Parse(lvItems.SelectedItems[0].SubItems[0].Text));
        }

        private void lCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvItems.Items.Clear();
            string SQLQuery = "SELECT invTypes.typeID, invTypes.typeName, invGroups.groupName, chrRaces.raceName, invTypes.description FROM (invCategories RIGHT JOIN (invTypes LEFT JOIN invGroups ON invTypes.groupID = invGroups.groupID) ON invCategories.categoryID = invGroups.categoryID) LEFT JOIN chrRaces ON invTypes.raceID = chrRaces.raceID WHERE (((invCategories.categoryName) = '" + lCategory.Text + "'))";

            DataTable SQLData = DBConnect.AQuery(SQLQuery);
            String[] item = new string[SQLData.Columns.Count];
            ListViewItem[] items = new ListViewItem[SQLData.Rows.Count];
            int count = 0;

            foreach (DataRow row in SQLData.Rows)
            {
                for (int i = 0; i < SQLData.Columns.Count; i++)
                {
                    item[i] = row[i].ToString();
                }

                ListViewItem item2 = new ListViewItem(item);
                items[count] = item2;
                count++;
            }
            lvItems.Items.AddRange(items);
            btSearch.Visible = true;
            label35.Visible = true;
            tbSearch.Visible = true;
        }

        private void lvItems_DblClick(object sender, EventArgs e)
        {
            foreach (ListViewItem SelectedItem in lvItems.SelectedItems)
            {
                itemAddEdit add = new itemAddEdit();
                add.Show();
                add.extractItemInfo(int.Parse(lvItems.SelectedItems[0].SubItems[0].Text));
            }
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            DataTable FindNewID = DBConnect.AQuery("SELECT max(typeID) from invTypes");
            int newid = 0;
            foreach (DataRow record in FindNewID.Rows)
            {
                newid = Convert.ToInt16(record[0].ToString()) + 1;
            }

            foreach (ListViewItem SelectedItem in lvItems.SelectedItems)
            {
                int typeID = Convert.ToInt16(SelectedItem.SubItems[0].Text);
                DBConnect.SQuery("INSERT INTO invTypes(typeID, groupID, typeName, description, graphicID, radius, mass, volume, capacity, portionSize, raceID, basePrice, published, marketGroupID, chanceOfDuplicating) SELECT '" + newid + "', groupID, concat('Copy of ', typeName), description, graphicID, radius, mass, volume, capacity, portionSize, raceID, basePrice, published, marketGroupID, chanceOfDuplicating from invTypes WHERE typeID = '" + typeID + "'");
                DBConnect.SQuery("INSERT INTO dgmTypeAttributes SELECT '" + newid + "', attributeID, valueInt, valueFloat from dgmTypeAttributes WHERE typeID = '" + typeID + "'");
                DBConnect.SQuery("INSERT INTO invShipTypes SELECT '" + newid + "', weapontypeID, miningtypeID, skilltypeID from invShipTypes WHERE shiptypeID = '" + typeID + "'");
                DBConnect.SQuery("INSERT INTO dgmTypeEffects SELECT '" + newid + "', effectID, isDefault from dgmTypeEffects WHERE typeID = '" + typeID + "'");
            }
            lCategory_SelectedIndexChanged(null, null);

            itemAddEdit add = new itemAddEdit();
            add.Show();
            add.extractItemInfo(newid);
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            lvItems_DblClick(null, null);
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem SelectedItem in lvItems.SelectedItems)
            {
                DBConnect.SQuery("DELETE FROM invTypes WHERE typeID = '" + SelectedItem.SubItems[0].Text + "'");
                DBConnect.SQuery("DELETE FROM dgmTypeAttributes WHERE typeID = '" + SelectedItem.SubItems[0].Text + "'");
                DBConnect.SQuery("DELETE FROM shiptypes WHERE shiptypeID = '" + SelectedItem.SubItems[0].Text + "'");
            }
            lCategory_SelectedIndexChanged(null, null);
        }

    }
}
