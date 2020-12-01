using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2
{
    public partial class New_User : Form
    {
        public New_User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Boolean exists(String userName)
        {
            string[] lines = File.ReadAllLines("login.txt");
            foreach (String line in lines)
            {
                if (line.Split(',')[0].Equals(userName))
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userName = textBox1.Text;
            String passWord = textBox2.Text;
            String confirm = textBox3.Text;
            String firstName = textBox4.Text;
            String lastName = textBox5.Text;
            String dateOfBirth = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            String userType = comboBox1.Text;
            if (exists(userName) && passWord.Equals(confirm))
            {
                User user = new User(userName, passWord, userType, firstName, lastName, dateOfBirth);
                user.addAccount();
                Close();
            }

        }
    }
}
