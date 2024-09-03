using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using _21计科2班_马菁含_010069_期末大作业_;
using System.IO;

namespace UserRegistration
{
    public partial class LoginForm : Form
    {


        static string jiemi(string path, int key)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                StringBuilder result = new StringBuilder();
                while (!reader.EndOfStream)
                {
                    char c = (char)reader.Read();
                    int after2 = c - key;
                    char afterall = (char)after2;
                    result.Append(afterall);
                }
                
                return result.ToString();
            }
            
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        int count;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string decryptedString = jiemi("./config.txt", -9);
                string[] tokens = decryptedString.Split(new[] { "----" }, StringSplitOptions.None);
                string server = tokens[0];
                string port = tokens[1];
                string username = tokens[2];
                string password = tokens[3];
                string database = tokens[4];

                MySqlConnection connection = new MySqlConnection($"server={server};port={port};username={username};password={password};database={database}");
                MySqlCommand command;
                string query = "SELECT COUNT(*) FROM users WHERE username='" + txtUserName.Text + "' AND password='" + txtPassword.Text + "'";
                command = new MySqlCommand(query, connection);
                connection.Open();
                count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();

                if (count == 1)
                {
                    MessageBox.Show("登陆成功！");
                    yemian1 form = new yemian1();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("账号或密码错误");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }


        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
    
}
