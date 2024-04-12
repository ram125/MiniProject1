using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Security.Cryptography;

namespace MiniProject1
{
    public partial class Form1 : Form
    {
        public bool IsAdmin { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username.Contains("admin") && password.Contains("admin"))
            {
                IsAdmin = true;
                DialogResult = DialogResult.OK;
                Form2 steve = new Form2(true);
                steve.Show();
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAB108PC12\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT 1 FROM users WHERE username = @username", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        string righthash = (string)dt.Rows[0]["PswdHash"];
                        string salt = (string)dt.Rows[0]["TimeUser"];
                        string userhash = hashPassword($"{password}{salt}");
                        if(righthash == userhash)
                        {
                            IsAdmin = false;
                            DialogResult = DialogResult.OK;
                            Form2 steve = new Form2(false);
                            steve.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username not found");
                    }
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Form4 steve = new Form4();
            steve.Show();
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