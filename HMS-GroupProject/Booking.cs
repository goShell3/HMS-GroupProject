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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            Panel panel = new Panel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill, // Adjust this as needed
                BorderStyle = BorderStyle.FixedSingle };
                this.Controls.Add(panel); // Create an instance of the form you want to display Form formToAdd = new FormToAdd { TopLevel = false, // Important: allow it to be a child control Visible = true, Dock = DockStyle.Top // Adjust the dock style as needed }; // Add the form to the panel panel.Controls.Add(formToAdd); }
            }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            AutoScroll = true;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
