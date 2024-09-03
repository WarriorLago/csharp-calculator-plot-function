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
using System.IO;

namespace _21计科2班_马菁含_010069_期末大作业_
{

    public partial class RegistrationForm : Form
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


        public RegistrationForm()
        {
            InitializeComponent();
        }

 

        private void ExecuteQuery(string query)
        {
            string decryptedString = jiemi("./config.txt", -9);
            string[] tokens = decryptedString.Split(new[] { "----" }, StringSplitOptions.None);
            string server = tokens[0];
            string port = tokens[1];
            string username = tokens[2];
            string password = tokens[3];
            string database = tokens[4];
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=user");
            MySqlCommand command;
            connection.Open();
            command = new MySqlCommand(query, connection);

            if (command.ExecuteNonQuery() == 1)
            {}
            else
            {
                MessageBox.Show("出错了！");
            }

            connection.Close();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "男";
            }
            else if (rbFemale.Checked)
            {
                gender = "女";
            }

            try
            {
                if (txtUserName.Text != "" && txtPassword.Text != "" && txtNickName.Text != "" && gender != "" && txtContact.Text != "" )
                {
                    if(vipbox.Text == "potatofish") { 
                    string query = "INSERT INTO users(username, password, nickname, gender, contact) VALUES('" + txtUserName.Text + "', '" + txtPassword.Text + "', '" + txtNickName.Text + "', '" + gender + "', '" + txtContact.Text + "')";
                    ExecuteQuery(query);
                    MessageBox.Show("注册成功");
                    this.Close();
                    }
                    else
                    {
                        MessageBox.Show("您的授权码不正确，如有需要购买vip授权码请联系qq2873655514");
                    }
                }
                else
                {
                    MessageBox.Show("您上述信息未填写完整，请检查。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败\n"+ex.Message);
            }
        }
    }
}
