namespace Sist_Biblioteca.Diseños
{
    partial class frmtrabj
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
            button6 = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            button5 = new Button();
            textBox6 = new TextBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.Gainsboro;
            button6.Location = new Point(752, 15);
            button6.Name = "button6";
            button6.Size = new Size(36, 27);
            button6.TabIndex = 16;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Cyan;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(754, 193);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Location = new Point(465, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 71);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
            // 
            // button5
            // 
            button5.Location = new Point(204, 24);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "Buscar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Cyan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(6, 23);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(177, 16);
            textBox6.TabIndex = 1;
            textBox6.Text = "ID";
            textBox6.Enter += textBox6_Enter;
            textBox6.Leave += textBox6_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 197);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // button4
            // 
            button4.Location = new Point(330, 123);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(330, 94);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(330, 65);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(330, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Cyan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(189, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 16);
            textBox4.TabIndex = 8;
            textBox4.Text = "Turno";
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Cyan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(189, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 16);
            textBox3.TabIndex = 7;
            textBox3.Text = "Telefono";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Cyan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(189, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 16);
            textBox2.TabIndex = 6;
            textBox2.Text = "Ciudad";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Cyan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(189, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 16);
            textBox1.TabIndex = 5;
            textBox1.Text = "Nombre";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // frmtrabj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmtrabj";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmtrabj";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button button5;
        private TextBox textBox6;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}