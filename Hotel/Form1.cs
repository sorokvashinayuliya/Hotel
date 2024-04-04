using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using Npgsql;

namespace Hotel
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Port=5432;Database=guest; User Id = postgres; Password=1234";
        public Form1()
        {
            InitializeComponent();
            SqlConnectionReader();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void reserveredCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void availableСheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
        private void SqlConnectionReader()
        {
            
            NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM guests.users";
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows) 
            {
                DataTable data = new DataTable();
                data.Load(dataReader);
                dataGridView1.DataSource = data;
            }
            command.Dispose();
            sqlConnection.Close();
        }
    }
    }

