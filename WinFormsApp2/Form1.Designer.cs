namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPosition = new DataGridViewTextBoxColumn();
            colSalary = new DataGridViewTextBoxColumn();
            colHoursworked = new DataGridViewTextBoxColumn();
            colTax = new DataGridViewTextBoxColumn();
            colInsurance = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            panel5 = new Panel();
            label12 = new Label();
            label9 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPosition, colSalary, colHoursworked, colTax, colInsurance });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(745, 150);
            dataGridView1.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // colName
            // 
            colName.HeaderText = "Имя";
            colName.Name = "colName";
            // 
            // colPosition
            // 
            colPosition.HeaderText = "Должность";
            colPosition.Name = "colPosition";
            // 
            // colSalary
            // 
            colSalary.HeaderText = "Зарплата";
            colSalary.Name = "colSalary";
            // 
            // colHoursworked
            // 
            colHoursworked.HeaderText = "Отработанные часы";
            colHoursworked.Name = "colHoursworked";
            // 
            // colTax
            // 
            colTax.HeaderText = "Налог";
            colTax.Name = "colTax";
            // 
            // colInsurance
            // 
            colInsurance.HeaderText = "Страховка";
            colInsurance.Name = "colInsurance";
            // 
            // button1
            // 
            button1.Location = new Point(751, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 150);
            button1.TabIndex = 1;
            button1.Text = "Доступ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(832, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(262, 475);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(12, 35);
            button2.Name = "button2";
            button2.Size = new Size(153, 40);
            button2.TabIndex = 3;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(17, 64);
            button3.Name = "button3";
            button3.Size = new Size(142, 46);
            button3.TabIndex = 4;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(601, 420);
            button6.Name = "button6";
            button6.Size = new Size(225, 55);
            button6.TabIndex = 7;
            button6.Text = "Читать файл";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(52, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(107, 23);
            textBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(153, 22);
            label1.TabIndex = 9;
            label1.Text = "Добавить узлы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 10);
            label2.Name = "label2";
            label2.Size = new Size(142, 22);
            label2.TabIndex = 10;
            label2.Text = "Удалить узел";
            // 
            // button7
            // 
            button7.Location = new Point(17, 64);
            button7.Name = "button7";
            button7.Size = new Size(152, 46);
            button7.TabIndex = 13;
            button7.Text = "Копировать";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(37, 128);
            button8.Name = "button8";
            button8.Size = new Size(107, 46);
            button8.TabIndex = 14;
            button8.Text = "Добавить";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(44, 128);
            button9.Name = "button9";
            button9.Size = new Size(107, 46);
            button9.TabIndex = 15;
            button9.Text = "Удалить";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(186, 22);
            label5.TabIndex = 16;
            label5.Text = "Копирование узла";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(62, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(107, 23);
            textBox3.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 16);
            label6.Name = "label6";
            label6.Size = new Size(186, 22);
            label6.TabIndex = 18;
            label6.Text = "Добавить атрибут";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(10, 15);
            label7.Name = "label7";
            label7.Size = new Size(175, 22);
            label7.TabIndex = 19;
            label7.Text = "Удалить атрибут";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(87, 38);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(107, 23);
            textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(87, 67);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(107, 23);
            textBox5.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(87, 96);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(107, 23);
            textBox6.TabIndex = 22;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(67, 41);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(107, 23);
            textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(67, 70);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(107, 23);
            textBox8.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 127);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(183, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 127);
            panel2.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 38);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 27;
            label3.Text = "Id:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(button7);
            panel3.Location = new Point(366, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(193, 127);
            panel3.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 38);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 27;
            label4.Text = "Id:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(textBox6);
            panel4.Location = new Point(0, 289);
            panel4.Name = "panel4";
            panel4.Size = new Size(201, 186);
            panel4.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 99);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 29;
            label11.Text = "Data:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 70);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 28;
            label10.Text = "Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 44);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 27;
            label8.Text = "Id:";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(button9);
            panel5.Controls.Add(textBox7);
            panel5.Controls.Add(textBox8);
            panel5.Location = new Point(207, 289);
            panel5.Name = "panel5";
            panel5.Size = new Size(198, 186);
            panel5.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 73);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 30;
            label12.Text = "Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 44);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 28;
            label9.Text = "Id:";
            // 
            // button4
            // 
            button4.Location = new Point(751, 156);
            button4.Name = "button4";
            button4.Size = new Size(75, 77);
            button4.TabIndex = 30;
            button4.Text = "Проверка XML файла";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 478);
            Controls.Add(button4);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPosition;
        private DataGridViewTextBoxColumn colSalary;
        private DataGridViewTextBoxColumn colHoursworked;
        private DataGridViewTextBoxColumn colTax;
        private DataGridViewTextBoxColumn colInsurance;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button6;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        private Label label8;
        private Panel panel5;
        private Label label11;
        private Label label10;
        private Label label12;
        private Label label9;
        private Button button4;
    }
}
