using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            UpdateUserList();
        }

        private void UpdateUserList()
        {
            listBox_users.Items.Clear();
            
            for (int i = 0; i < Login.RegularUsernames.Count; i++)
                listBox_users.Items.Add(Login.RegularUsernames[i] + " - Score: " + Login.RegularScores[i]);
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login.login.Show();
            this.Close();
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUID.Text) || string.IsNullOrEmpty(txtUPW.Text))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            bool success = Login.AddUser(txtUID.Text, txtUPW.Text);
            
            if (success)
            {
                MessageBox.Show("User added successfully!");
                UpdateUserList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Username already exists!");
            }
        }

        private void btn_removeUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUID.Text))
            {
                MessageBox.Show("Please enter username to remove");
                return;
            }

            bool success = Login.RemoveUser(txtUID.Text);
            
            if (success)
            {
                MessageBox.Show("User removed successfully!");
                UpdateUserList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("User not found!");
            }
        }

        private void btn_removeSelectedUser_Click(object sender, EventArgs e)
        {
            if (listBox_users.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user from the list");
                return;
            }

            string selectedItem = listBox_users.SelectedItem.ToString();
            string username = selectedItem.Split('-')[0].Trim();
            
            bool success = Login.RemoveUser(username);
            
            if (success)
            {
                MessageBox.Show("User removed successfully!");
                UpdateUserList();
                ClearInputFields();
            }
        }

        private void btn_updateUserInfo_Click(object sender, EventArgs e)
        {
            if (listBox_users.SelectedIndex == -1 && string.IsNullOrEmpty(txtUID.Text))
            {
                MessageBox.Show("Please select a user or enter username");
                return;
            }

            string oldUsername;
            
            if (listBox_users.SelectedIndex != -1)
            {
                string selectedItem = listBox_users.SelectedItem.ToString();
                oldUsername = selectedItem.Split('-')[0].Trim();
            }
            else
            {
                oldUsername = txtUID.Text;
            }

            bool success = Login.UpdateUser(oldUsername, txtUID.Text, txtUPW.Text);
            
            if (success)
            {
                MessageBox.Show("User updated successfully!");
                UpdateUserList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("User not found!");
            }
        }

        private void listBox_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_users.SelectedIndex != -1)
            {
                string selectedItem = listBox_users.SelectedItem.ToString();
                string username = selectedItem.Split('-')[0].Trim();
                
                int userIndex = Login.GetUserIndex(username);
                if (userIndex != -1)
                {
                    txtUID.Text = Login.RegularUsernames[userIndex];
                    txtUPW.Text = Login.RegularPasswords[userIndex];
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearInputFields()
        {
            txtUID.Clear();
            txtUPW.Clear();
            listBox_users.SelectedIndex = -1;
        }
    }
}