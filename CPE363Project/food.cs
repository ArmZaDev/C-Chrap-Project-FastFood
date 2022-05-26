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
    public partial class food : UserControl
    {
        public food()
        {
            InitializeComponent();
        }

        public int count = 0;
        public double result = 0;

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();      

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {          
            if(pictureBox1.Image != null)
            {
                con.Open();                
                string database = "Insert Into fastfood Values('" + frmLogin.passingText + "','" + label1.Text + "','" + lblCheBur.Text + "')";
                cmd = new OleDbCommand(database, con);
                cmd.ExecuteNonQuery();
                con.Close();
                
                count += 1;
                txtAmount.Text = count.ToString();

                result += 1.75;
                txtPrice.Text = result.ToString();
            }
        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                con.Open();                
                string database = "Insert Into fastfood Values('" + frmLogin.passingText + "','" + label2.Text + "','" + lblDouChe.Text + "')";
                cmd = new OleDbCommand(database, con);
                cmd.ExecuteNonQuery();
                con.Close();

                count += 1;
                txtAmount.Text = count.ToString();

                result += 3.4;
                txtPrice.Text = result.ToString();
            }
        }
        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                con.Open();                
                string database = "Insert Into fastfood Values('" + frmLogin.passingText + "','" + label3.Text + "','" + lblBigKing.Text + "')";
                cmd = new OleDbCommand(database, con);
                cmd.ExecuteNonQuery();
                con.Close();

                count += 1;
                txtAmount.Text = count.ToString();

                result += 4;
                txtPrice.Text = result.ToString();
            }
        }
        private void btnComOder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Complete"," your order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAmount.Text = "";
            txtPrice.Text = "";          
        }











        private void pictureBox1_Click(object sender, EventArgs e)
        {
                         
        }

        
    }
}
