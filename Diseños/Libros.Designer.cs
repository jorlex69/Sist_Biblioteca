namespace Sist_Biblioteca.Diseños
{
    partial class Libros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(317, 118);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(317, 89);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(317, 54);
            button2.Name = "button2";
            button2.Size = new Size(75, 24);
            button2.TabIndex = 11;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(317, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 10;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(0, 122, 204);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.LightGray;
            textBox5.Location = new Point(18, 118);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(220, 18);
            textBox5.TabIndex = 9;
            textBox5.Text = "Existencia";
            textBox5.Enter += textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(0, 122, 204);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.LightGray;
            textBox4.Location = new Point(18, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 18);
            textBox4.TabIndex = 8;
            textBox4.Text = "Editorial";
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(0, 122, 204);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.LightGray;
            textBox3.Location = new Point(18, 59);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 18);
            textBox3.TabIndex = 7;
            textBox3.Text = "Autor";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 122, 204);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.LightGray;
            textBox2.Location = new Point(18, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 18);
            textBox2.TabIndex = 6;
            textBox2.Text = "Titulo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button5);
            groupBox2.ForeColor = Color.LightGray;
            groupBox2.Location = new Point(445, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 197);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 122, 204);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.LightGray;
            textBox1.Location = new Point(6, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 16);
            textBox1.TabIndex = 8;
            textBox1.Text = "ID Libro";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(247, 24);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "Buscar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(752, 205);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Location = new Point(759, 0);
            button6.Name = "button6";
            button6.Size = new Size(36, 27);
            button6.TabIndex = 9;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Libros";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
       
            Leave += Libros_Leave;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
        private GroupBox groupBox2;
        private Button button5;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button6;
    }
}