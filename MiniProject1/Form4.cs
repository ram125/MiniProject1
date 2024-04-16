using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = passwordAgainTextBox.Text;
            string pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[?!@#$%_&*])[A-Za-z0-9?!@#$%_&*]{8,}$";

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            if (!Regex.IsMatch(password, pattern))
            {
                MessageBox.Show("Invalid password. Password should be at least 8 characters long with at least one capital letter, one lowercase letter, one digit, and one special character.");
                return;
            }

            // Generate salt (in this case, using DateandTime)
            string salt = DateTime.Now.ToString();

            // Hash the password
            string hashedPassword = hashPassword($"{password}{salt}");
            string connectionString = @"Data Source=LAB108PC12\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Prepare SQL query to insert data into the Users table
                string query = "INSERT INTO users (username, TimeUser, PswdHash) VALUES (@Username, @DateandTime, @Password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@DateandTime", salt); // Store salt
                    command.Parameters.AddWithValue("@Password", hashedPassword); // Store hashed password

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User registered successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to register user.");
                    }
                }
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }
        private byte[] savePhoto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAB108PC12\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Photos VALUES (@photo)", con);//"INSERT INTO (photo) Photos VALUES (@photo)"
                    cmd.Parameters.AddWithValue("@photo", savePhoto());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Photo was saved");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error occurred. Please try again." + ex.Message, "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error occurred. Please try again." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string hashPassword(string password)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(password);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
