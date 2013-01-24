using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Evemu_DB_Editor.src;
using System.Data.Common;

namespace Evemu_DB_Editor
{
    public partial class frAccountEditor : Form
    {
        public frAccountEditor()
        {
            InitializeComponent();
        }

        private static string CalculateMD5Hash(string strInput)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(strInput);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public void GetAccountInfo(string id)
        {
            //string acctLevel = "";
            foreach (DataRow record in DBConnect.AQuery("SELECT accountName, role FROM account WHERE accountID=" + id).Rows)
            {
                tbUsername.Text = record[0].ToString();
                //acctLevel = record[1].ToString();
            }
                        
            //switch (Int64.Parse(acctLevel))
            //{
            //    case 2:  lRole.SelectedIndex = 4;break;
            //    case 8:  lRole.SelectedIndex = 3;break;
            //    case 16:  lRole.SelectedIndex = 2;break;
            //    case 32:  lRole.SelectedIndex = 1;break;
            //    default:  lRole.SelectedIndex = 0;break;
            //}
        }

        private void cbChangePass_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.Enabled = cbChangePass.Checked ;
        }

        private void cbChangeRole_CheckedChanged(object sender, EventArgs e)
        {
            lRole.Enabled = cbChangeRole.Checked;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //string acctrole = lRole.Text;
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
            //else
            //{
            //    acctrole = "2";
            //}

            
            List<string> pars = new List<string>();
            pars.Add("accountName='" + tbUsername.Text + "'");
            if (cbChangePass.Checked) pars.Add("password='" + tbPassword.Text + "'");
            //if (cbChangeRole.Checked) pars.Add("role=" + acctrole);

            try {
                int res = DBConnect.SQuery("UPDATE account SET "+String.Join(", ", pars.ToArray() )+" WHERE accountID=" + tbUserID.Text);
                if(res==1) {
                    MessageBox.Show("Account modified!");
                    Close();
                } else {
                    MessageBox.Show(res+" rows affected, something went wrong");
                }
            } catch(DbException ex) {
                MessageBox.Show("Database error: "+ex);
            }                
        }

        private void btClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
