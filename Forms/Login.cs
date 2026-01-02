using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public static Login login;
        
        public static List<string> RegularUsernames = new List<string>();
        public static List<string> RegularPasswords = new List<string>();
        public static List<int> RegularScores = new List<int>();
        public static List<List<string>> SolvedProblems = new List<List<string>>();
        
        public static List<string> AdminUsernames = new List<string>();
        public static List<string> AdminPasswords = new List<string>();

        public Login()
        {
            InitializeComponent();
            login = this;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // add normal users
            RegularUsernames.Add("user1");
            RegularPasswords.Add("u1");
            RegularScores.Add(0);
            SolvedProblems.Add(new List<string>());
            
            RegularUsernames.Add("user2");
            RegularPasswords.Add("u2");
            RegularScores.Add(0);
            SolvedProblems.Add(new List<string>());
            
            RegularUsernames.Add("user3");
            RegularPasswords.Add("u3");
            RegularScores.Add(0);
            SolvedProblems.Add(new List<string>());
            
            RegularUsernames.Add("user4");
            RegularPasswords.Add("u4");
            RegularScores.Add(0);
            SolvedProblems.Add(new List<string>());
            
            // add admin user
            AdminUsernames.Add("admin");
            AdminPasswords.Add("admin");
        }

        private void chk_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtUPW.PasswordChar = chk_showPassword.Checked ? '\0' : '#';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool isAdmin = false;
            bool loginSuccess = false;
            
            for (int i = 0; i < RegularUsernames.Count; i++)
            {
                if (RegularUsernames[i] == txtUID.Text && RegularPasswords[i] == txtUPW.Text)
                {
                    isAdmin = false;
                    loginSuccess = true;
                    break;
                }
            }
            
            if (!loginSuccess)
            {
                for (int i = 0; i < AdminUsernames.Count; i++)
                {
                    if (AdminUsernames[i] == txtUID.Text && AdminPasswords[i] == txtUPW.Text)
                    {
                        isAdmin = true;
                        loginSuccess = true;
                        break;
                    }
                }
            }
            
            if (loginSuccess)
            {
                if (isAdmin)
                {
                    MessageBox.Show("Login Succeeded As Admin");
                    Admin adminForm = new Admin();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Succeeded As User");
                    User userForm = new User();
                    userForm.CurrentUsername = txtUID.Text;
                    userForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }

            txtUID.Clear();
            txtUPW.Clear();
            chk_showPassword.Checked = false;
        }
        
        public static bool AddUser(string username, string password)
        {
            for (int i = 0; i < RegularUsernames.Count; i++)
            {
                if (RegularUsernames[i] == username)
                    return false;
            }
            
            RegularUsernames.Add(username);
            RegularPasswords.Add(password);
            RegularScores.Add(0);
            SolvedProblems.Add(new List<string>());
            return true;
        }
        
        public static bool RemoveUser(string username)
        {
            for (int i = 0; i < RegularUsernames.Count; i++)
            {
                if (RegularUsernames[i] == username)
                {
                    RegularUsernames.RemoveAt(i);
                    RegularPasswords.RemoveAt(i);
                    RegularScores.RemoveAt(i);
                    SolvedProblems.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        
        public static bool UpdateUser(string oldUsername, string newUsername, string newPassword)
        {
            for (int i = 0; i < RegularUsernames.Count; i++)
            {
                if (RegularUsernames[i] == oldUsername)
                {
                    RegularUsernames[i] = newUsername;
                    RegularPasswords[i] = newPassword;
                    return true;
                }
            }
            return false;
        }
        
        public static int GetUserIndex(string username)
        {
            for (int i = 0; i < RegularUsernames.Count; i++)
            {
                if (RegularUsernames[i] == username)
                    return i;
            }
            return -1;
        }
    }
}