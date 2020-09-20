namespace ToDoList
{
    partial class Learning
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonSelectEdit = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ToDoList | Learning";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(7, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 316);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(24, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 316);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(192, 373);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(599, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 35);
            this.button3.TabIndex = 16;
            this.button3.Text = "+";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(24, 366);
            this.textBox.MaxLength = 140;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(550, 23);
            this.textBox.TabIndex = 15;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // buttonSelectEdit
            // 
            this.buttonSelectEdit.AutoEllipsis = true;
            this.buttonSelectEdit.BackColor = System.Drawing.Color.Teal;
            this.buttonSelectEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectEdit.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.buttonSelectEdit.ForeColor = System.Drawing.Color.White;
            this.buttonSelectEdit.Location = new System.Drawing.Point(24, 393);
            this.buttonSelectEdit.Name = "buttonSelectEdit";
            this.buttonSelectEdit.Size = new System.Drawing.Size(208, 24);
            this.buttonSelectEdit.TabIndex = 17;
            this.buttonSelectEdit.Text = "Select item";
            this.buttonSelectEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSelectEdit.UseVisualStyleBackColor = false;
            this.buttonSelectEdit.Click += new System.EventHandler(this.buttonSelectEdit_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoEllipsis = true;
            this.buttonEdit.BackColor = System.Drawing.Color.Teal;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(238, 393);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(197, 24);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Edit item";
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(441, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 24);
            this.button1.TabIndex = 19;
            this.button1.Text = "Update list";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // Learning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSelectEdit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Learning";
            this.Size = new System.Drawing.Size(650, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonSelectEdit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button button1;
    }
}
