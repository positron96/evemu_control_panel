using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Evemu_DB_Editor.src.GUI {
    public partial class tabAcct : UserControl {
        public tabAcct() {
            InitializeComponent();
        }

                
        private void btSearchAccount_Click(object sender, EventArgs e)
        {
            populateAccountList();
        }

        private void btAddAccount_Click(object sender, EventArgs e)
        {
            string query = "";

            if (newUsername.Text != "" && newPassword.Text != "")// && newAcctLevel.Text != "")
            {
                //conn = new MySqlConnection(connection);
                //string acctrole = newAcctLevel.Text;
                //if (acctrole == "SUPER ADMIN")
                //{
                //    acctrole = "4294967231";
                //}
                //else if (acctrole == "ADMIN")
                //{
                //    acctrole = "32";
                //}
                //else if (acctrole == "GAME MASTER HIGH")
                //{
                //    acctrole = "16";
                //}
                //else if (acctrole == "GAME MASTER LOW")
                //{
                //    acctrole = "8";
                //}
                //else if (acctrole == "PLAYER")
                //{
                //    acctrole = "2";
                //}
                //else
                //{
                //    MessageBox.Show("You have not selected a role, the account will be \"2 (PLAYER)\" by default.");
                //    acctrole = "2";
                //}
                string acctrole = "5003499186008621056";

                query = "INSERT INTO account (accountName, password, role) VALUES ('"
                    + newUsername.Text + "', '"
                    + newPassword.Text + "', '"
                    + acctrole + "')";

                if (DBConnect.SQuery(query) == 1)
                {
                    newUsername.Clear();
                    newPassword.Clear();
                    newAcctLevel.SelectedIndex = -1;
                    populateAccountList();
                    MessageBox.Show("Account Created!");
                }
            }
            else
            {
                MessageBox.Show("Please make sure all the fields are filled in.");
            }
        }

        private void miDeleteAccount_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lvAccounts.SelectedItems[0].Text))
            {
                MessageBox.Show("Please right click an account.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete the account: " + lvAccounts.SelectedItems[0].SubItems[1].Text + "?", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBConnect.SQuery("DELETE FROM account WHERE accountID=" + lvAccounts.SelectedItems[0].SubItems[0].Text);
                    lvAccounts.Items.Remove(lvAccounts.SelectedItems[0]);
                }
            }
        }

        private void miEditAccount_Click(object sender, EventArgs e)
        {
            if(! String.IsNullOrEmpty(lvAccounts.SelectedItems[0].Text))
            {
                acctEdit acc = new acctEdit();
                acc.Show();
                ListViewItem item = lvAccounts.SelectedItems[0];
                acc.GetAccountInfo(item.SubItems[0].Text);
                acc.userID.Text = item.SubItems[0].Text;
            }
        }

        private void lCharacterName_DropDown(object sender, EventArgs e)
        {
            //characterSkillsList.Items.Clear();
            //foreach (DataRow record in DBConnect.AQuery("SELECT typeID, itemName, itemID AS currentitemID, (SELECT valueInt FROM entity_attributes WHERE itemID = currentitemID AND attributeid = 280) AS level, (SELECT valueInt FROM entity_attributes WHERE itemID = currentitemID AND attributeid = 276) AS skillpoints FROM entity WHERE flag = 7 AND ownerid = " + characterIDTxtBox.Text).Rows)
            //{
            //    string[] temp = new string[4];
            //    temp[0] = record[0].ToString();
            //    temp[1] = record[1].ToString();
            //    temp[2] = record[3].ToString();
            //    temp[3] = record[4].ToString();
            //    ListViewItem temp2 = new ListViewItem(temp);
            //    characterSkillsList.Items.Add(temp2);
            //}
        }

        private void lCharacterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow record in DBConnect.AQuery("SELECT itemID FROM entity WHERE itemName = '" + lCharacterName.Text + "'").Rows)
            {
                characterIDTxtBox.Text = record[0].ToString();
            }

            lvCharacterSkills.Items.Clear();
            foreach (DataRow record in DBConnect.AQuery("SELECT typeID, itemName, itemID AS currentitemID, (SELECT valueInt FROM entity_attributes WHERE itemID = currentitemID AND attributeid = 280) AS level, (SELECT valueInt FROM entity_attributes WHERE itemID = currentitemID AND attributeid = 276) AS skillpoints FROM entity WHERE flag = 7 AND ownerid = " + characterIDTxtBox.Text).Rows)
            {
                string[] temp = new string[4];
                temp[0] = record[0].ToString();
                temp[1] = record[1].ToString();
                temp[2] = record[3].ToString();
                temp[3] = record[4].ToString();
                ListViewItem temp2 = new ListViewItem(temp);
                lvCharacterSkills.Items.Add(temp2);
            }

        }

        private void miEditSkill_Click(object sender, EventArgs e)
        {
            editCharacterSkill editSkill = new editCharacterSkill();
            editSkill.newskill = 1;
            editSkill.characterID.Text = characterIDTxtBox.Text;
            editSkill.ShowDialog();
            lCharacterName_SelectedIndexChanged(null, null);
        }

        private void miAddSkill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Too lazy to implement right now, use remove/add for now");
            //Code below is fine, too lazy to write the update queries

            //foreach (ListViewItem SelectedItem in characterSkills.SelectedItems)
            //{
            //editCharacterSkill editSkill = new editCharacterSkill();            
            //editSkill.skillID.Text = SelectedItem.SubItems[0].Text;
            //editSkill.skillName.Text = SelectedItem.SubItems[1].Text;
            //editSkill.skillLevel.Text = SelectedItem.SubItems[2].Text;
            //editSkill.skillPoints.Text = SelectedItem.SubItems[3].Text;
            //editSkill.characterID.Text = characterID.Text;
            //editSkill.newskill = 0;
            //editSkill.ShowDialog();
            //characterName_SelectedIndexChanged(null, null);
            //}  
        }

        private void miRemoveSkill_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem SelectedItem in lvCharacterSkills.SelectedItems)
            {
                DBConnect.SQuery("DELETE FROM entity_attributes WHERE itemID in (SELECT itemID FROM entity WHERE ownerID = " + characterIDTxtBox.Text + " AND typeID = " + SelectedItem.SubItems[0].Text + ")");
                DBConnect.SQuery("DELETE FROM entity WHERE ownerID = " + characterIDTxtBox.Text + " AND typeID = " + SelectedItem.SubItems[0].Text);
            }
            lCharacterName_SelectedIndexChanged(null, null);
        }

        private void populateAccountList()
        {
            lvAccounts.Items.Clear();
            string query = "SELECT accountID, accountName, role, banned, online FROM account WHERE(accountName like \'" + accountTxtBox.Text + "%\')";
            foreach (DataRow record in DBConnect.AQuery(query).Rows)
            {
                string[] list = { record[0].ToString(), record[1].ToString() };
                ListViewItem item = new ListViewItem(list);
                lvAccounts.Items.Add(item);
            }
        }
                
        private void lvAccounts_Click(object sender, EventArgs e) {
            populateCharacterList();
        }

        private void populateCharacterList()
        {
            lCharacterName.Items.Clear();
            if(lvAccounts.SelectedItems.Count==0) return;
            string query = "SELECT itemName, itemID FROM entity,character_ WHERE entity.itemID=character_.characterID AND character_.accountID = " + lvAccounts.SelectedItems[0].SubItems[0].Text;
            foreach (DataRow record in DBConnect.AQuery(query).Rows)
            {
                lCharacterName.Items.Add(record[0].ToString() );
            }
        }

    }
}
