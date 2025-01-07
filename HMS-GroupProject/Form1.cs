using HMS_GroupProject.user_control;
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
    public partial class Form1 : Form
    {
        GuestUserControl ucguest = new GuestUserControl();
        BookingListUserControl ucbooking = new BookingListUserControl();
        HomeUserControl uchome = new HomeUserControl();
        RoomUserControl ucroom = new RoomUserControl();


        public Form1()
        {
            InitializeComponent();
            //c = null; // Initially, no form is displayed
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (LoginPage loginForm = new LoginPage())
            {
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    // If login is not successful, close the application
                    Application.Exit();
                    return;
                }
            }
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uchome);
            uchome.Dock = DockStyle.Fill;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void homeButton_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uchome);
            uchome.Dock = DockStyle.Fill;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucroom);
            ucroom.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucguest);
            ucguest.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucbooking);
            ucbooking.Dock = DockStyle.Fill;
        }
    }
}
