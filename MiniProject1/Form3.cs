using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void UpdateTownButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(townTextBox.Text) && !string.IsNullOrWhiteSpace(replacedTownTextBox.Text))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Tourism;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Towns SET TownName = @city WHERE TownName = @replacedCity", con))
                    {
                        cmd.Parameters.AddWithValue("@city", townTextBox.Text);
                        cmd.Parameters.AddWithValue("@replacedCity", replacedTownTextBox.Text);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Town updated successfully");
                            townTextBox.Clear();
                            replacedTownTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Town not found for replacement");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid town names");
            }
        }

        private void AddTownButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(townTextBox.Text))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Tourism;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Towns (TownName) VALUES (@city)", con))
                    {
                        cmd.Parameters.AddWithValue("@city", townTextBox.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Town added successfully");
                        townTextBox.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid town name");
            }
        }

        private void DeleteTownButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(townTextBox.Text))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Tourism;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Towns WHERE TownName = @city", con))
                    {
                        cmd.Parameters.AddWithValue("@city", townTextBox.Text);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Town deleted successfully");
                            townTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Town not found for deletion");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid town name");
            }
        }
    }
}
