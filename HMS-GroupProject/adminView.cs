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
    public partial class adminView : UserControl
    {
        public GuestUserControl ucguest = new GuestUserControl();
        public BookingListUserControl ucbooking = new BookingListUserControl();
        public HomeUserControl uchome = new HomeUserControl();
        public RoomUserControl ucroom = new RoomUserControl();
        public adminView()
        {
            InitializeComponent();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uchome);
            uchome.Dock = DockStyle.Fill;

        }

        private void adminView_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uchome);
            uchome.Dock = DockStyle.Fill;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucroom);
            ucroom.Dock = DockStyle.Fill;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucguest);
            ucguest.Dock = DockStyle.Fill;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucbooking);
            ucbooking.Dock = DockStyle.Fill;
        }
    }
}
