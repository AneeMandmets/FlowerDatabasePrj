﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace FlowerDatabasePrj
{
    public partial class MainPage : Form
    {
        MySqlConnection conn; // Connection variable
        string myConnectionString; // String for connection data
        //bool myIsConnected = false; // Boolean value for whether the connection is open or not
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            DatabaseConnection();
        }

        private void DatabaseConnection()
        {
            myConnectionString = "server=localhost;uid=root;pwd=L4ste4i40pet4j4;database=lilled";

            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowFlowers_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            MySqlCommand allFlowers = new MySqlCommand("SELECT * FROM nimi", conn);
            allFlowers.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(allFlowers);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            tblFlowers.DataSource = dt;
        }

        
    }
}
