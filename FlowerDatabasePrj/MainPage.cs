﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlConnector;

namespace FlowerDatabasePrj
{
    public partial class MainPage : Form
    {
        MySqlConnection conn; // Connection variable
        string myConnectionString = "server=localhost;uid=root;pwd=L4ste4i40pet4j4;database=lilled"; // String for connection data
        //bool myIsConnected = false; // Boolean value for whether the connection is open or not
        string tableName = "nimi"; // Table name for choosing what data to get from database
        string id; // id of type
        string removableID; // ID for something to be deleted
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            DatabaseConnection();
            fillComboBox();
            tblFlowers.DefaultCellStyle.Font = new Font("Comic mono", 12);
            tblFlowers.ColumnHeadersDefaultCellStyle.Font = new Font("Comic mono", 12);
        }

        private void DatabaseConnection()
        {
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
            tableName = "nimi";
            BindGrid();
            tbName.Enabled = false;
            btnAddFlower.Enabled = false;
            btnAddType.Enabled = false;
        }

        private void BindGrid()
        {
            DatabaseConnection();
            MySqlCommand data = new MySqlCommand("SELECT * FROM " + tableName, conn);
            data.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(data);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            tblFlowers.DataSource = dt;
            tblFlowers.Columns[0].Width = 50;
            try
            {
                tblFlowers.Columns[2].Width = 40;
            } catch(Exception ex) { }
            lblCount.Text = "Count: " + (tblFlowers.Rows.Count - 1).ToString();
            conn.Close();
        }

        private void BindGridType()
        {
            DatabaseConnection();
            MySqlCommand data = new MySqlCommand("SELECT * FROM nimi WHERE liik_idliik='" + id + "'", conn);
            data.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(data);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            tblFlowers.DataSource = dt;
            tblFlowers.Columns[0].Width = 50;
            tblFlowers.Columns[2].Width = 40;
            lblCount.Text = "Count: " + (tblFlowers.Rows.Count - 1).ToString();
            conn.Close();
        }

        private void btnShowTypes_Click(object sender, EventArgs e)
        {
            tableName= "liigid";
            BindGrid();
            tbName.Enabled = true;
            btnAddFlower.Enabled = false;
            btnAddType.Enabled = true;
        }

        private void fillComboBox()
        {
            MySqlCommand options = new MySqlCommand("SELECT idliik,liik FROM liigid", conn);
            options.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(options);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            cbTypes.DataSource = dt;
            cbTypes.DisplayMember= "liik";
            cbTypes.ValueMember = "idliik";
            
        }

        private void cbTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            id = cbTypes.SelectedValue.ToString();
            BindGridType();
            tbName.Enabled = true;
            btnAddFlower.Enabled = true;
            btnAddType.Enabled = false;
        }

        private void addFlower(string name)
        {
            DatabaseConnection();
            try
            {
                MySqlCommand adding = new MySqlCommand("INSERT INTO nimi(nimi, liik_idliik) VALUES('" + name + "','" + id + "')", conn);
                adding.CommandType = CommandType.Text;
                MySqlDataAdapter sda = new MySqlDataAdapter(adding);

                MySqlDataReader rdr = adding.ExecuteReader();
                while (rdr.Read()) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void addType(string name)
        {
            DatabaseConnection();
            try
            {
                MySqlCommand adding = new MySqlCommand("INSERT INTO liigid(liik) VALUES('" + name + "')", conn);
                adding.CommandType = CommandType.Text;
                MySqlDataAdapter sda = new MySqlDataAdapter(adding);

                MySqlDataReader rdr = adding.ExecuteReader();
                while (rdr.Read()) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnAddFlower_Click(object sender, EventArgs e)
        {
            var response = tbName.Text;
            addFlower(response);
            BindGrid();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            var response = tbName.Text;
            addType(response);
            BindGrid();
        }

        private void remove()
        {
            DatabaseConnection();

            if(tableName == "liigid")
            {
                try
                {
                    MySqlCommand removing = new MySqlCommand("DELETE FROM liigid WHERE idliik=" + removableID, conn);
                    removing.CommandType = CommandType.Text;
                    MySqlDataAdapter sda = new MySqlDataAdapter(removing);

                    MySqlDataReader rdr = removing.ExecuteReader();
                    while (rdr.Read()) { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    MySqlCommand removing = new MySqlCommand("DELETE FROM nimi WHERE idnimi=" + removableID, conn);
                    removing.CommandType = CommandType.Text;
                    MySqlDataAdapter sda = new MySqlDataAdapter(removing);

                    MySqlDataReader rdr = removing.ExecuteReader();
                    while (rdr.Read()) { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            btnRemove.Enabled = false;
            conn.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            remove();
            BindGrid();
        }

        private void tblFlowers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnRemove.Enabled = true;
            removableID = tblFlowers.SelectedRows[0].Cells[0].Value.ToString();
            Console.WriteLine(removableID);
        }

        private void search(string name)
        {
            DatabaseConnection();
            try
            {
                MySqlCommand search = new MySqlCommand("SELECT * FROM nimi WHERE nimi LIKE '%%" + name + "%%'", conn);
                search.CommandType = CommandType.Text;
                MySqlDataAdapter sda = new MySqlDataAdapter(search);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                tblFlowers.DataSource = dt;
                lblCount.Text = "Count: " + (tblFlowers.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var response = txtSearch.Text;
            search(response);
        }
    }
}
