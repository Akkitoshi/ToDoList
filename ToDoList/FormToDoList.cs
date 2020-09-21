using System;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList
{
    // добавить изменения задания -
    // персонализация +
    public partial class FormToDoList : Form
    {
        public FormToDoList()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonLearning_Click(object sender, EventArgs e)
        {
            learning1.BringToFront();
            System.Media.SoundPlayer player = new
            System.Media.SoundPlayer(@"C:\Users\anast\source\repos\ToDoList\ToDoList\Sounds\Switch.wav");
            player.Play();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            books1.BringToFront();
            System.Media.SoundPlayer player = new
            System.Media.SoundPlayer(@"C:\Users\anast\source\repos\ToDoList\ToDoList\Sounds\Switch.wav");
            player.Play();
        }

        private void buttonTargets_Click(object sender, EventArgs e)
        {
            targets1.BringToFront();
            System.Media.SoundPlayer player = new
            System.Media.SoundPlayer(@"C:\Users\anast\source\repos\ToDoList\ToDoList\Sounds\Switch.wav");
            player.Play();
        }

        private void buttonIdeas_Click(object sender, EventArgs e)
        {
            ideas1.BringToFront();
            System.Media.SoundPlayer player = new
            System.Media.SoundPlayer(@"C:\Users\anast\source\repos\ToDoList\ToDoList\Sounds\Switch.wav");
            player.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormToDoList_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToString("MM.dd.yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.LightGray)
            {
                BackColor = Color.White;
                button1.BackColor = Color.DimGray;
                button1.Text = "Dark mode";
                button1.ForeColor = Color.LightGray;
            }
            else
            {
                BackColor = Color.LightGray;
                button1.BackColor = Color.White;
                button1.Text = "Light mode";
                button1.ForeColor = Color.Black;

            }
        }

        public void UpdateForm()
        {
            FormToDoList.ActiveForm.Refresh();
        }

        private void learning1_Load(object sender, EventArgs e)
        {

        }
    }
}
