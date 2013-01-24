using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using Evemu_DB_Editor.src;



namespace Evemu_DB_Editor
{
    public partial class frItemEditor : Form
    {
        public frItemEditor()
        {
            InitializeComponent();
        }

        private void frItemEditor_Load(object sender, EventArgs e)
        {
            lMarketGroup.Items.Clear();
            foreach (DataRow record in DBConnect.AQuery("SELECT marketGroupID, parentGroupID AS parent, (SELECT marketGroupName FROM invMarketGroups WHERE marketGroupID = parent) as marketParentName, marketGroupName FROM invMarketGroups ORDER BY marketParentName").Rows)
            {
                lMarketGroup.Items.Add(record[0].ToString() + " - " + record[2].ToString() + " - " + record[3].ToString());
            }

            lGroup.Items.Clear();
            foreach (DataRow record in DBConnect.AQuery("SELECT groupID, groupName FROM invGroups ORDER BY groupName").Rows)
            {
               lGroup.Items.Add(record[0].ToString() + " - " + record[1].ToString());
            }

            foreach (DataRow record in DBConnect.AQuery("SELECT effectName FROM dgmEffects ORDER BY effectName").Rows)
            {
                lEffectDescription.Items.Add(record[0].ToString());
            }
        }

        #region properties

        public void extractItemInfo(int itemID)
        {
            DataTable invTypesdata = DBConnect.AQuery("SELECT * FROM invTypes WHERE typeID=" + itemID);
            foreach (DataRow record in invTypesdata.Rows)
            {
                lbTypeID.Text = record["typeID"].ToString();
                lbGroupID.Text = record["groupID"].ToString();
                tbTypeName.Text = record["typeName"].ToString();
                tbDescription.Text = record["description"].ToString();
                tbGraphicID.Text = record["graphicID"].ToString();
                tbRadius.Text = record["radius"].ToString();
                tbMass.Text = record["mass"].ToString();
                tbVolume.Text = record["volume"].ToString();
                tbCapacity.Text = record["capacity"].ToString();
                tbPortionSize.Text = record["portionSize"].ToString();
                tbRaceID.Text = record["raceId"].ToString();
                tbBasePrice.Text = record["basePrice"].ToString();
                tbPublished.Text = record["published"].ToString();
                lbMarketGroupID.Text = record["marketGroupID"].ToString();
                tbChanceOfDuplicating.Text = record["chanceOfDuplicating"].ToString();

                //Populate the Group ComboBox
                int groupIndex = lGroup.FindString(lbGroupID.Text + " -");
                lGroup.SelectedIndex = groupIndex;

                //Populate the MarketGroup ComboBox
                int marketIndex = lMarketGroup.FindString(lbMarketGroupID.Text + " -");
                lMarketGroup.SelectedIndex = marketIndex;
                
                frItemEditor.ActiveForm.Text = tbTypeName.Text;                
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tbRaceID.Text == "") tbRaceID.Text = "0";
            DBConnect.SQuery("UPDATE invTypes SET "+
                "groupID = " + lbGroupID.Text + ","+
                "published = " + tbPublished.Text + ","+
                "marketGroupID = " + lbMarketGroupID.Text + ","+
                "typeName = '" + tbTypeName.Text + "',"+
                "graphicID = " + tbGraphicID.Text + ","+
                "radius = " + tbRadius.Text + ","+
                "mass = " + tbMass.Text + ","+
                "volume = " + tbVolume.Text + ","+
                "capacity = " + tbCapacity.Text + ","+
                "portionSize = " + tbPortionSize.Text + ","+
                "raceID = " + tbRaceID.Text + ","+
                "basePrice = " + tbBasePrice.Text + ","+
                "description = '" + tbDescription.Text + "'"+
                " WHERE typeID = " + lbTypeID.Text);
        }

        private void lGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbGroupID.Text = lGroup.Text.Substring(0, lGroup.Text.IndexOf(" "));          
        }

        private void lMarketGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMarketGroupID.Text = lMarketGroup.Text.Substring(0, lMarketGroup.Text.IndexOf(" "));
            
        }


        private void btHelp_Click(object sender, EventArgs e)
        {
            information info = new information();
            info.ShowDialog();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            extractItemInfo(int.Parse(lbTypeID.Text));
        }        

        private void btDelete_Click(object sender, EventArgs e)
        {
            DBConnect.SQuery("DELETE FROM invTypes WHERE typeID=" + lbTypeID.Text); // the item itself
            DBConnect.SQuery("DELETE FROM dgmTypeAttributes WHERE typeID=" + lbTypeID.Text); // all it's attributes
            DBConnect.SQuery("DELETE FROM invShipTypes WHERE shiptypeID=" + lbTypeID.Text); // if it's a ship, delete it from ship types...

            this.Close(); // This item does not exist anymore, no point providing any info anymore...
        }

        #endregion

        #region attributes

        private void tabItemAttributes_Enter(object sender, EventArgs e)
        {
            lvAttributes.Items.Clear();
            foreach (DataRow record in DBConnect.AQuery("SELECT dgmTypeAttributes.attributeID, attributeName, valueInt, valueFloat FROM dgmTypeAttributes LEFT JOIN dgmAttributeTypes ON dgmTypeAttributes.attributeID = dgmAttributeTypes.attributeID WHERE (((dgmTypeAttributes.typeID)= " + lbTypeID.Text + "))").Rows)
            {
                string[] attribute = new string[4];
                attribute[0] = record[0].ToString();
                attribute[1] = record[1].ToString();
                attribute[2] = record[2].ToString();
                attribute[3] = record[3].ToString();  
                ListViewItem attribute2 = new ListViewItem(attribute);
                lvAttributes.Items.Add(attribute2);
            }

            foreach (DataRow record in DBConnect.AQuery("SELECT attributeName FROM dgmAttributeTypes ORDER BY attributeName").Rows)
            {
                lAttributeName.Items.Add(record[0].ToString());
            }
        }

        private void lvAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem SelectedItem in lvAttributes.SelectedItems)
            {
                lblAttributeID.Text = SelectedItem.SubItems[0].Text;
                lAttributeName.Text = SelectedItem.SubItems[1].Text;
                tbAttributeInt.Text = SelectedItem.SubItems[2].Text;
                tbAttributeFloat.Text = SelectedItem.SubItems[3].Text;
            }
        }

        private void lAttributeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow record in DBConnect.AQuery("SELECT attributeID FROM dgmAttributeTypes WHERE attributeName = '" + lAttributeName.Text + "'").Rows)
            {
                lblAttributeID.Text = record[0].ToString();
            }            
        }

        private void btAttributeAdd_Click(object sender, EventArgs e)
        {
           if (tbAttributeInt.Text != "") 
           {
               DBConnect.SQuery("INSERT INTO dgmTypeAttributes (typeID, attributeID, valueInt) VALUES (" + lbTypeID.Text + "," + lblAttributeID.Text + "," + tbAttributeInt.Text + ")");
           }
           else
           {
               DBConnect.SQuery("INSERT INTO dgmTypeAttributes (typeID, attributeID, valueFloat) VALUES (" + lbTypeID.Text + "," + lblAttributeID.Text + ",'" + tbAttributeFloat.Text + "')");
           }                        
            tabItemAttributes_Enter(null,null);
        }

        private void btAttributeChange_Click(object sender, EventArgs e)
        {
            if (tbAttributeInt.Text != "")
            {
                DBConnect.SQuery("UPDATE dgmTypeAttributes SET valueInt = " + tbAttributeInt.Text + " WHERE typeID = " + lbTypeID.Text + " AND attributeID = " + lblAttributeID.Text);
            }
            else
            {
                DBConnect.SQuery("UPDATE dgmTypeAttributes SET valueFloat = '" + tbAttributeFloat.Text + "' WHERE typeID = " + lbTypeID.Text + " AND attributeID = " + lblAttributeID.Text);
            }
            tabItemAttributes_Enter(null, null);
        }

        private void miDeleteAttribute_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem SelectedItem in lvAttributes.SelectedItems)
            {
                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete " + SelectedItem.SubItems[1].Text  + "?", "Confirm delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    DBConnect.SQuery("DELETE FROM dgmTypeAttributes WHERE typeID = " + lbTypeID.Text + " AND attributeID = " + SelectedItem.SubItems[0].Text);
                    tabItemAttributes_Enter(null, null);
                }
            }
        }

        #endregion
        
        #region effects

        private void tabItemEffects_Enter(object sender, EventArgs e)
        {
            lvEffects.Items.Clear();
            foreach (DataRow record in DBConnect.AQuery("SELECT effectID AS effect, (SELECT effectname FROM dgmEffects WHERE effectID = effect) as effectName, isDefault FROM dgmTypeEffects WHERE typeID = " + lbTypeID.Text).Rows)
            {
                string[] attribute = new string[3];
                attribute[0] = record[0].ToString();
                attribute[1] = record[1].ToString();
                attribute[2] = record[2].ToString();                
                ListViewItem attribute2 = new ListViewItem(attribute);
                lvEffects.Items.Add(attribute2);
            }

        }

        private void lEffectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow record in DBConnect.AQuery("SELECT effectID FROM dgmEffects WHERE effectName = '" + lEffectDescription.Text + "'").Rows)
            {
                lblEffectID.Text = record[0].ToString();
            }             
        }

        private void btAddEffect_Click(object sender, EventArgs e)
        {
            DBConnect.SQuery("INSERT INTO dgmTypeEffects (typeID, effectID, isDefault) VALUES (" + lbTypeID.Text + "," + lblEffectID.Text + "," + tbIsDefault.Text + ")");
        }

        private void miDeleteEffect_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem SelectedItem in lvEffects.SelectedItems)
            {
                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete " + SelectedItem.SubItems[1].Text + "?", "Confirm delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    DBConnect.SQuery("DELETE FROM dgmTypeEffects WHERE typeID = " + lbTypeID.Text + " AND effectID = " + SelectedItem.SubItems[0].Text);
                    tabItemAttributes_Enter(null, null);
                }
            }
        }

        private void lvEffects_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem SelectedItem in lvEffects.SelectedItems)
            {
                lEffectDescription.Text = SelectedItem.SubItems[1].Text;
                //tabItemEffects_Enter(null, null);
            }
        }

        #endregion

    }
}
