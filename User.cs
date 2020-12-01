using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment_2
{
    public class User
    {
        private String userName, passWord, firstName, lastName, userType, dateOfBirth;

        public User(String userName, String passWord, String userType, String firstName, String lastName, String dateOfBirth)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.userType = userType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }

        public String UserName
        {
            get
            {
                return userName;
            }
        }

        public String UserType
        {
            get
            {
                return userType;
            }
        }

        public void addAccount()
        {
            File.AppendAllText("login.txt", String.Format("\n{0},{1},{2},{3},{4},{5}", userName, passWord, userType, firstName, lastName, dateOfBirth));
        }
    }
}
