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
    public partial class dashboard : Form
    {
        
        public dashboard()
        {
            InitializeComponent();           
            home1.BringToFront();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string imgageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "png file(*.png) | *.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgageLocation = dialog.FileName;

                    pictureBox1.ImageLocation = imgageLocation;
                }
            }
            catch (Exception)
            {

            }
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            label1.Text = frmLogin.passingText;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(255, 192, 192);
            home1.BringToFront();
        }
                 
        private void button1_Click(object sender, EventArgs e)//btnFood
        {
            pnlNav.Height = btnFood.Height;
            pnlNav.Top = btnFood.Top;
            pnlNav.Left = btnFood.Left;
            btnFood.BackColor = Color.FromArgb(255, 192, 192);
            food1.BringToFront();
        }
        
        private void btnOder_Click(object sender, EventArgs e)
        {            
            pnlNav.Height = btnOrder.Height;
            pnlNav.Top = btnOrder.Top;
            pnlNav.Left = btnOrder.Left;
            btnOrder.BackColor = Color.FromArgb(255, 192, 192);  
            new order().Show();
            this.Hide();       
        }
        
        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAbout.Height;
            pnlNav.Top = btnAbout.Top;
            pnlNav.Left = btnAbout.Left;
            btnAbout.BackColor = Color.FromArgb(255, 192, 192);
            new about().Show();
            this.Hide();
        }
        
        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(188, 32, 20); 
        }

        private void btnFood_Leave(object sender, EventArgs e)
        {
            btnFood.BackColor = Color.FromArgb(188, 32, 20);
        }

        private void btnOder_Leave(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(188, 32, 20);
        }

        private void btnAbout_Leave(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.FromArgb(188, 32, 20);
        }

       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are sure to log out", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                new frmLogin().Show();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //Exit
        {
            this.Close();
        }
 
        private void order1_Load(object sender, EventArgs e)
        {
                  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void food1_Load(object sender, EventArgs e)
        {

        }
    }
}
