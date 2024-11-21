using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_GroupProject
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
            homePage homeForm = new homePage();
            homeForm.TopLevel = false;
            homeForm.FormBorderStyle = FormBorderStyle.None;
            homeForm.Dock = DockStyle.Fill;
            contentpanel.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
