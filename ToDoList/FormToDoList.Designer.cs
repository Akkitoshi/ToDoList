namespace ToDoList
{
    partial class FormToDoList
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToDoList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonTargets = new System.Windows.Forms.Button();
            this.buttonIdeas = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonLearning = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.learning1 = new ToDoList.Learning();
            this.books1 = new ToDoList.Books();
            this.targets1 = new ToDoList.Targets();
            this.ideas1 = new ToDoList.Ideas();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.buttonTargets);
            this.panel1.Controls.Add(this.buttonIdeas);
            this.panel1.Controls.Add(this.buttonBooks);
            this.panel1.Controls.Add(this.buttonLearning);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Name = "panel1";
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.BackColor = System.Drawing.Color.Teal;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonMinimize
            // 
            resources.ApplyResources(this.buttonMinimize, "buttonMinimize");
            this.buttonMinimize.BackColor = System.Drawing.Color.Teal;
            this.buttonMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonTargets
            // 
            resources.ApplyResources(this.buttonTargets, "buttonTargets");
            this.buttonTargets.BackColor = System.Drawing.Color.Teal;
            this.buttonTargets.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonTargets.ForeColor = System.Drawing.Color.White;
            this.buttonTargets.Name = "buttonTargets";
            this.buttonTargets.UseVisualStyleBackColor = false;
            this.buttonTargets.Click += new System.EventHandler(this.buttonTargets_Click);
            // 
            // buttonIdeas
            // 
            resources.ApplyResources(this.buttonIdeas, "buttonIdeas");
            this.buttonIdeas.BackColor = System.Drawing.Color.Teal;
            this.buttonIdeas.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonIdeas.ForeColor = System.Drawing.Color.White;
            this.buttonIdeas.Name = "buttonIdeas";
            this.buttonIdeas.UseVisualStyleBackColor = false;
            this.buttonIdeas.Click += new System.EventHandler(this.buttonIdeas_Click);
            // 
            // buttonBooks
            // 
            resources.ApplyResources(this.buttonBooks, "buttonBooks");
            this.buttonBooks.BackColor = System.Drawing.Color.Teal;
            this.buttonBooks.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonBooks.ForeColor = System.Drawing.Color.White;
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonLearning
            // 
            resources.ApplyResources(this.buttonLearning, "buttonLearning");
            this.buttonLearning.BackColor = System.Drawing.Color.Teal;
            this.buttonLearning.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonLearning.ForeColor = System.Drawing.Color.White;
            this.buttonLearning.Name = "buttonLearning";
            this.buttonLearning.UseVisualStyleBackColor = false;
            this.buttonLearning.Click += new System.EventHandler(this.buttonLearning_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // Time
            // 
            resources.ApplyResources(this.Time, "Time");
            this.Time.ForeColor = System.Drawing.Color.Teal;
            this.Time.Name = "Time";
            // 
            // Date
            // 
            resources.ApplyResources(this.Date, "Date");
            this.Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Date.ForeColor = System.Drawing.Color.Teal;
            this.Date.Name = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Name = "panel3";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // learning1
            // 
            resources.ApplyResources(this.learning1, "learning1");
            this.learning1.Name = "learning1";
            // 
            // books1
            // 
            resources.ApplyResources(this.books1, "books1");
            this.books1.Name = "books1";
            // 
            // targets1
            // 
            resources.ApplyResources(this.targets1, "targets1");
            this.targets1.Name = "targets1";
            // 
            // ideas1
            // 
            resources.ApplyResources(this.ideas1, "ideas1");
            this.ideas1.Name = "ideas1";
            // 
            // FormToDoList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.Time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.learning1);
            this.Controls.Add(this.books1);
            this.Controls.Add(this.targets1);
            this.Controls.Add(this.ideas1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormToDoList";
            this.Load += new System.EventHandler(this.FormToDoList_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTargets;
        private System.Windows.Forms.Button buttonIdeas;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonLearning;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimize;
        private Books books1;
        private Targets targets1;
        private Ideas ideas1;
        private Learning learning1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}

