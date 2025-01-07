﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HMS_GroupProject
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=DESKTOP-A3UB2QO\\MSSQLSERVER2022;Initial Catalog=HotelManagementDB;Integrated Security=True;Encrypt=False;";
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            LoginPage loginPage = new LoginPage(this);
            this.Controls.Add(loginPage);
            loginPage.Visible = true;
            loginPage.Dock = DockStyle.Fill;
        }
        public void ShowDashboard()
        {
            // Remove all controls from the main panel and add the Dashboard
            this.Controls.Clear();
            var dashboard = new Dashboard();
            this.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
        }
        private void InitializeDatabase()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connected to Database!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Failed: " + ex.Message);
            }
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

        //private void label7_Click(object sender, EventArgs e)
        //{
        //    Room roomForm = new Room();
        //    this.Hide();
        //    roomForm.Show();
        //    roomForm.FormClosed += (s, args) => this.Show();
        //}


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        //private void label8_Click(object sender, EventArgs e)
        //{
        //    Guest guestForm = new Guest();
        //    this.Hide();
        //    guestForm.Show();
        //    guestForm.FormClosed += (s, args) => this.Show();
        //}


        //    private void label10_Click(object sender, EventArgs e)
        //    {
        //        Form1 homeForm = new Form1();
        //        this.Hide();
        //        homeForm.Show();
        //        homeForm.FormClosed += (s, args) => this.Show();
        //    }

        //    private void button1_Click(object sender, EventArgs e)
        //    {
        //        Booking bookingForm = new Booking();
        //        this.Hide(); 
        //        bookingForm.Show(); 
        //        bookingForm.FormClosed += (s, args) => this.Show();
        //    }
    }
}
