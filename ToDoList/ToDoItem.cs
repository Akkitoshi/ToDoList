﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ToDoList
{
    public partial class ToDoItem : UserControl
    {
        public ToDoItem()
        {
            InitializeComponent();
        }

        public ToDoItem(string text, string date)
        {
            InitializeComponent();
            lbl.Text = text;
            lblDate.Text = date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new
            System.Media.SoundPlayer(@"C:\Users\anast\source\repos\ToDoList\ToDoList\Sounds\Delete.wav");
            player.Play();

            SqlConnection SQL = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Targets;Integrated Security=True;Pooling=False");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("DELETE FROM TargetTab WHERE TargetText = '" + lbl.Text + "'", SQL);
                command.ExecuteNonQuery();
               
            }
            this.BackColor = Color.LightSalmon;
            lbl.Text = "Deleted";
            lbl.ForeColor = Color.White;
            this.button1.Enabled = false;
            lblDate.Text = "";
            
        }
    }
}
