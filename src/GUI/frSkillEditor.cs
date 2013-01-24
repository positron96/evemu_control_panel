using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Evemu_DB_Editor.src;

namespace Evemu_DB_Editor
{    
    public partial class frSkillEditor : Form
    {
        private bool newSkill = false;

        public frSkillEditor( ) : this(false)  {   }

        public frSkillEditor( bool isNewSkill )
        {
            InitializeComponent();
            newSkill = isNewSkill;
        }

        private void frEditSkill_Load(object sender, EventArgs e)
        {
            foreach (DataRow record in DBConnect.AQuery("SELECT typeName from invTypes WHERE groupid in (SELECT groupid from invGroups WHERE categoryid = 16) order by typeName").Rows)
            {
                lSkillName.Items.Add(record[0].ToString());
            }
        }

        private void lSkillName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow record in DBConnect.AQuery("SELECT typeID from invTypes WHERE typeName = '" + lSkillName.Text + "'").Rows)
            {
                lblSkillID.Text = record[0].ToString();
            }
        }

        private void btLevelUp_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(tbSkillLevel.Text) < 5)
            {
                tbSkillLevel.Text = Convert.ToString(Convert.ToInt16(tbSkillLevel.Text) + 1); 
            }
        }

        private void btLevelDown_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(tbSkillLevel.Text) > 0)
            {
                tbSkillLevel.Text = Convert.ToString(Convert.ToInt16(tbSkillLevel.Text) - 1);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            String keyword;
            if (newSkill) keyword = "INSERT"; else keyword = "REPLACE";
            
            DBConnect.SQuery(keyword+" INTO entity (itemName, typeID, ownerID, locationID, flag, contraband, singleton, quantity, x, y ,z) VALUES ('" + lSkillName.Text + "'," + lblSkillID.Text + "," + lblCharacterID.Text + "," + lblCharacterID.Text + ", 7,0,1,1,0,0,0)");
            Int64 sid = (Int64)DBConnect.AQueryScalar("SELECT itemID from entity WHERE ownerID = " + lblCharacterID.Text + " and itemName = '" + lSkillName.Text + "'");
            DBConnect.SQuery(keyword+" INTO entity_attributes (itemID, attributeID, valueInt) VALUES ("+sid+", 276, " + tbSkillLevel.Text + ")");
            DBConnect.SQuery(keyword+" INTO entity_attributes (itemID, attributeID, valueInt) VALUES ("+sid+", 280, " + tbSkillPoints.Text + ")");

            this.Close();
        }
    }
}
