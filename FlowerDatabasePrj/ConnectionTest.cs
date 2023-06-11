using System;
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
    public partial class ConnectionTest : Form
    {
        MySqlConnection conn; // Connection variable
        string myConnectionString; // String for connection data
        bool myIsConnected = false; // Boolean value for whether the connection is open or not
        public ConnectionTest()
        {
            InitializeComponent();
        }

        private void ConnectionTest_Load(object sender, EventArgs e)
        {
            
        }

        private bool DatabaseConnection()
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
                return false;
            }
            return true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            myIsConnected = DatabaseConnection();
            if (myIsConnected)  // If the connectios is successful, changes the status text
            {
                lblState.Text = "Connected";
                lblState.ForeColor = Color.Green;
            }
            else
            {
                lblState.ForeColor = Color.Red;
            }
        }
    }
}
