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
            else if (username.Contains("user") && password.Contains("user"))
            {
                IsAdmin = false;
                DialogResult = DialogResult.OK;
                Form2 steve = new Form2(false);
                steve.Show();
            }
            else
            {
                MessageBox.Show("enter valid credentials");
            }
        }
    }
}