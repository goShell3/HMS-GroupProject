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
        GuestUserControl guest = new GuestUserControl();
        BookingListUserControl booking = new BookingListUserControl();

        public Form1()
        {
            InitializeComponent();
            //currentForm = null; // Initially, no form is displayed
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Room roomForm = new Room();
            this.Hide();
            roomForm.Show();
            roomForm.FormClosed += (s, args) => this.Show();
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(booking);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(guest);
           /* Guest guestForm = new Guest();
            this.Hide();
            guestForm.Show();
            guestForm.FormClosed += (s, args) => this.Show();*/


        }


        private void label10_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            this.Hide();
            homeForm.Show();
            homeForm.FormClosed += (s, args) => this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking bookingForm = new Booking();
            this.Hide(); 
            bookingForm.Show(); 
            bookingForm.FormClosed += (s, args) => this.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
