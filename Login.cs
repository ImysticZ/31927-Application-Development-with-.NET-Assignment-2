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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = matchUser(textBox1.Text, textBox2.Text);
            if (!(user is null))
            {
                Hide();
                new Text_Editor(user.UserName, user.UserType).ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Invalid Username/Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new New_User().ShowDialog();
            Show();
        }

        private User matchUser(String userName, String passWord)
        {
            String[] lines = File.ReadAllLines("login.txt");
            foreach (String line in lines)
            {
                String[] l = line.Split(',');
                if (l[0].Equals(userName) && l[1].Equals(passWord))
                {
                    return new User(l[0], l[1], l[2], l[3], l[4], l[5]);
                }
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
