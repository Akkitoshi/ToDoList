using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ToDoList
{
    public partial class Ideas : UserControl
    {
        public Ideas()
        {
            InitializeComponent();
            getTargets();
        }

        public static int poss = 10;
        public static string targetIdEdit;
        public static string targetCreateEdit;

        public void addItem(string text, string date)
        {
            ToDoItem item = new ToDoList.ToDoItem(text, date);
            panel2.Controls.Add(item);
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tarName = textBox.Text;
            string createDate = DateTime.Now.ToString("MM.dd.yyyy");
            addTargets(tarName, createDate);
            textBox.Text = "";
        }
        void getTargets()
        {
            try
            {
                SqlConnection SQL = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Targets;Integrated Security=True;Pooling=False");
                using (SQL)
                {
                    SQL.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM TargetTab WHERE TargetId = 4", SQL);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tarName = reader["TargetText"].ToString();
                            string createDate = reader["TargetCreateDate"].ToString();
                            addItem(tarName, createDate);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Oops, something is wrong!");
            }
        }

        public void addTargets(string insert, string createDate)
        {
            string tarName = textBox.Text;
            if (tarName == "")
            {
                MessageBox.Show("Oops, something is wrong! It seems you were trying to add empty task.");
            }
            else
            {
                try
                {
                    SqlConnection SQL = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Targets;Integrated Security=True;Pooling=False");
                    using (SQL)
                    {
                        SQL.Open();
                        SqlCommand commandSec = new SqlCommand("INSERT INTO TargetTab (TargetText,TargetCreateDate,TargetId) VALUES ('" + insert + "','" + createDate + "','4')", SQL);
                        commandSec.ExecuteNonQuery();
                        addItem(tarName, createDate);
                        System.Media.SoundPlayer player = new
                        System.Media.SoundPlayer(@"C:\Users\anast\source\repos\ToDoList\ToDoList\Sounds\Add.wav");
                        player.Play();
                    }
                }
                catch
                {
                    MessageBox.Show("Oops, something is wrong! It seems you were trying to add a task that already exists.");
                }
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if (Regex.Match(c, @"\p{IsCyrillic}|\p{IsCyrillicSupplement}").Success)
            {
                e.Handled = true;
            }
        }
        private void buttonUpd_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            poss = 10;
            getTargets();
        }

        public void buttonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}

