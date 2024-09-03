using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21计科2班_马菁含_010069_期末大作业_
{
    public partial class 使用说明 : Form
    {
        public 使用说明()
        {
            InitializeComponent();
        }

        private void 使用说明_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 打开文件的路径
            string filePath = Path.Combine(Application.StartupPath, "shiyongshuoming.xml");


            // 打开文件
            try
            {
                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开失败，请检查："+ex.Message);
            }
        }
    }
}
