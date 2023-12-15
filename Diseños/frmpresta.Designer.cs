namespace Sist_Biblioteca.Diseños
{
    partial class frmpresta
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox9 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button6 = new Button();
            groupBox2 = new GroupBox();
            textBox5 = new TextBox();
            button5 = new Button();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.BlueViolet;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(754, 147);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(26, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 207);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.BlueViolet;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.ForeColor = Color.LightGray;
            textBox9.Location = new Point(33, 152);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(251, 16);
            textBox9.TabIndex = 21;
            textBox9.Text = "Estado";
            textBox9.Enter += textBox9_Enter;
            textBox9.Leave += textBox9_Leave;
            // 
            // button4
            // 
            button4.BackColor = Color.Indigo;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(330, 123);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Indigo;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(330, 94);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Indigo;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(330, 65);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(330, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.BlueViolet;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.ForeColor = Color.LightGray;
            textBox4.Location = new Point(33, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(251, 16);
            textBox4.TabIndex = 8;
            textBox4.Text = "Nombre estudiante";
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.BlueViolet;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = Color.LightGray;
            textBox3.Location = new Point(33, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 16);
            textBox3.TabIndex = 7;
            textBox3.Text = "Id estudiante";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.BlueViolet;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.LightGray;
            textBox2.Location = new Point(33, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 16);
            textBox2.TabIndex = 6;
            textBox2.Text = "Id trabajador";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.BlueViolet;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.LightGray;
            textBox1.Location = new Point(33, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 16);
            textBox1.TabIndex = 5;
            textBox1.Text = "Titulo del libro";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGray;
            button6.Location = new Point(752, 12);
            button6.Name = "button6";
            button6.Size = new Size(36, 27);
            button6.TabIndex = 19;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(button5);
            groupBox2.ForeColor = Color.LightGray;
            groupBox2.Location = new Point(476, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 64);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.BlueViolet;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.ForeColor = Color.LightGray;
            textBox5.Location = new Point(6, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 16);
            textBox5.TabIndex = 8;
            textBox5.Text = "ID Prestamo";
            textBox5.Enter += textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            // 
            // button5
            // 
            button5.BackColor = Color.Indigo;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(216, 21);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "Buscar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 85);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 5;
            label8.Text = "Hasta";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(30, 104);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 30);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 3;
            label7.Text = "Desde";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(30, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(label8);
            groupBox3.ForeColor = Color.LightGray;
            groupBox3.Location = new Point(476, 115);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 144);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fecha";
            // 
            // frmpresta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmpresta";
            Opacity = 0.9D;
            Text = "frmpresta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button6;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private Button button5;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox9;
        private GroupBox groupBox3;
    }
}