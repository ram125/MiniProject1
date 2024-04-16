using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private bool isAdmin;
        private String index;
        public Form2(bool isAdmin)
        {
            InitializeComponent();
            PopulateCountriesComboBox();
            PopulateTownsComboBox();
            if (!isAdmin)
            {
                adminButton.Enabled = false;
                adminButton.Visible = false;
            }
            this.index = "0";//this.index = index;//received from prev form
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PopulateCountriesComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAB108PC12\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True"))
                {
                    string query = "SELECT CountryName FROM Country";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxCountries.Items.Add(reader["CountryName"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving countries from the database: " + ex.Message);
            }
        }

        private void PopulateTownsComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAB108PC12\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True"))
                {
                    string query = "SELECT CapitalName FROM Capital";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxTowns.Items.Add(reader["CapitalName"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving towns from the database: " + ex.Message);
            }
        }
        private Image GetImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            return Image.FromStream(ms);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAB108PC12\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from Photos where id = @id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(index));
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);
                pictureBox1.Image = GetImage((byte[])resultTable.Rows[0]["photo"]);
            }
        }

        private void adminButton_Click_1(object sender, EventArgs e)
        {
            Form3 loginForm = new Form3();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }

        }
    }
}
