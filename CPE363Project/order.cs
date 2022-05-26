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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }
      
        private void order_Load(object sender, EventArgs e)
        {
            txtUsername.Text = frmLogin.passingText;

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=db_users.mdb");
            conn.Open();
            string sql = "Select * from fastfood";
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "food");
            OleDbDataReader reader = cmd.ExecuteReader();
            if(reader.Read() == true)
            {
                dataGridView1.DataSource = ds.Tables["food"];
                conn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e) //Exit
        {
            new dashboard().Show();
            this.Hide();
        }
    }
}
