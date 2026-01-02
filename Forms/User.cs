using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Login
{

    public partial class User : Form
    {
        public string CurrentUsername;

        public User()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UpdateUserList();
            label1.Text = "Welcome, " + CurrentUsername;
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


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Please select a problem!");
                return;
            }


            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Java files (*.java)|*.java"
            };

            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            string javaFile = openFile.FileName;
            string directory = Path.GetDirectoryName(javaFile);
            string className = Path.GetFileNameWithoutExtension(javaFile);


            if (!CompileJavaFile(javaFile))
                return;

            TestJavaCode(directory, className);
        }


        private bool CompileJavaFile(string javaFile)
        {
            Process compile = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c javac \"{javaFile}\"",
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            });

            string errors = compile.StandardError.ReadToEnd();
            compile.WaitForExit();

            if (!string.IsNullOrEmpty(errors))
            {
                MessageBox.Show("Compilation Error:\n" + errors);
                return false;
            }

            return true;
        }

        private void TestJavaCode(string directory, string className)
        {
            string input = "";
            string expected = "";
            string problemName = "";


            if (radioButton1.Checked)
            {
                input = "5 7";
                expected = "12";
                problemName = "SumTwoNumbers";
            }
            else if (radioButton2.Checked)
            {
                input = "3\n3\n1\n2";
                expected = "1 2 3";
                problemName = "SortArray";
            }
            else if (radioButton3.Checked)
            {
                input = "3\n1 2 3";
                expected = "3 2 1";
                problemName = "ReverseArray";
            }


            Process run = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c java -cp \"{directory}\" {className}",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            });


            run.StandardInput.WriteLine(input);
            run.StandardInput.Close();


            string output = run.StandardOutput.ReadToEnd().Trim();
            string runtimeError = run.StandardError.ReadToEnd().Trim();

            run.WaitForExit();


            if (!string.IsNullOrEmpty(runtimeError))
            {
                MessageBox.Show("Runtime Error:\n" + runtimeError);
            }
            else if (output == expected)
            {
                int userIndex = Login.GetUserIndex(CurrentUsername);

                if (userIndex != -1)
                {
                    if (!Login.SolvedProblems[userIndex].Contains(problemName))
                    {
                        Login.SolvedProblems[userIndex].Add(problemName);
                        Login.RegularScores[userIndex]++;
                        UpdateUserList();
                        MessageBox.Show("Correct! You earned 1 point!");
                    }
                    else
                    {
                        MessageBox.Show("Correct! (No points - you already solved this)");
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong Answer\nExpected: " + expected + "\nYour Output: " + output);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateUserList();
        }
    }
}