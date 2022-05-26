using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CPE363Project
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source =db_users.mdb");

        
        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "" && txtMessage.Text == "")
            {
                MessageBox.Show("Please Fill up all TextBox before submitting.", "Submit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string database = "Insert Into about Values('" + "','" + frmLogin.passingText + "','" + txtEmail.Text + "','" + txtMessage.Text + "')";
                OleDbCommand cmd = new OleDbCommand(database, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                txtEmail.Text = "";
                txtMessage.Text = "";

                MessageBox.Show("message received will answer as soon as possible", "Submit success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            this.Hide();
        }
        private void about_Load(object sender, EventArgs e)
        {
                            
        }

       
    }
}
