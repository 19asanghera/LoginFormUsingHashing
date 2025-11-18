using MySqlConnector;
using System.Security.Cryptography;

namespace LoginFormUsingHashing
{
    public partial class Form1 : Form
    {
        const int KeySize = 128;
        const int iterations = 350000;
        static HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
        public Form1()
        {
            InitializeComponent();
            lblPwd2.Visible = false;
            txtPwd2.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnLogin.Text = "Create Account";

            }
            else
            {
                btnLogin.Text = "Login";
            }
            changeType();
        }
        private void changeType()
        {
            lblPwd2.Visible = !lblPwd2.Visible;
            txtPwd2.Visible = !txtPwd2.Visible;
        }
        //https://github.com/MrAStone/HashingAndSaltingPasswords
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mysqlDetails = "server =...";
            MySqlConnection con = new MySqlConnection(mysqlDetails);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            if (checkBox1.Checked) //NEW PERSON LOGIN
            {
                // check pwd is entered the same twice!
                string SQL = "INSERT INTO users(username,password) VALUES(@uname,@pwd)";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@uname",txtUserName.Text); 
                var hash = HashPassword(txtPwd.Text, out var salt);
                string hpwd = hash + Convert.ToHexString(salt);
                cmd.Parameters.AddWithValue("@pwd", hpwd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string SQL = "SELECT password FROM users WHERE username=@uname";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@uname",txtUserName.Text);
                MySqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    string pwd = result.GetString(0);
                    string hpwd = pwd.Substring(0, 256);
                    byte[] hsalt =Convert.FromHexString( pwd.Substring(256));
                    MessageBox.Show(VerifyPassword(txtUserName.Text, hpwd, hsalt).ToString());
                }
                
            }
            
        }
        private string HashPassword(string password, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(KeySize);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgorithm, KeySize);
            return Convert.ToHexString(hash);
        }
        private bool VerifyPassword(string password, string hash, byte[] salt)
        {
            byte[] hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgorithm, KeySize);

            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }

    }
}
