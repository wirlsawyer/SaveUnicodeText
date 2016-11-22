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

namespace SaveUnicodeText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string profileName = "What is your name"; 
            string key = "搭配陣列使用 foreach (C# 程式設計手冊)";

            String fileName = "D:\\123.txt";
            Encoding encoding = Encoding.Unicode;

            using (FileStream fs = new FileStream(fileName, FileMode.Append))
            {
                using (StreamWriter writer = new StreamWriter(fs, encoding))
                {
                    writer.WriteLine(profileName);
                    writer.WriteLine(key);
                }
            }

        }
    }
}
