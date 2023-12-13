namespace Sist_Biblioteca.Diseños
{
    partial class Main_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_));
            btncerrar = new Button();
            btnconf = new Button();
            btnestu = new Button();
            btnlib = new Button();
            button1 = new Button();
            btntrab = new Button();
            SuspendLayout();
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.IndianRed;
            btncerrar.Location = new Point(404, 358);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(170, 37);
            btncerrar.TabIndex = 0;
            btncerrar.Text = "Cerrar Sesion";
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnconf
            // 
            btnconf.BackColor = Color.DimGray;
            btnconf.Location = new Point(440, 201);
            btnconf.Name = "btnconf";
            btnconf.Size = new Size(168, 44);
            btnconf.TabIndex = 1;
            btnconf.Text = "Usuarios";
            btnconf.UseVisualStyleBackColor = false;
            btnconf.Click += btnconf_Click;
            // 
            // btnestu
            // 
            btnestu.BackColor = Color.FromArgb(0, 192, 192);
            btnestu.Location = new Point(458, 90);
            btnestu.Name = "btnestu";
            btnestu.Size = new Size(151, 33);
            btnestu.TabIndex = 2;
            btnestu.Text = "Estudiantes";
            btnestu.UseVisualStyleBackColor = false;
            btnestu.Click += btnestu_Click;
            // 
            // btnlib
            // 
            btnlib.BackColor = Color.DodgerBlue;
            btnlib.Location = new Point(135, 38);
            btnlib.Name = "btnlib";
            btnlib.Size = new Size(171, 39);
            btnlib.TabIndex = 3;
            btnlib.Text = "Libros";
            btnlib.UseVisualStyleBackColor = false;
            btnlib.Click += btnlib_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumOrchid;
            button1.Location = new Point(70, 145);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 4;
            button1.Text = "Prestamos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btntrab
            // 
            btntrab.BackColor = Color.Cyan;
            btntrab.Location = new Point(43, 334);
            btntrab.Name = "btntrab";
            btntrab.Size = new Size(180, 48);
            btntrab.TabIndex = 5;
            btntrab.Text = "Trabajadores";
            btntrab.UseVisualStyleBackColor = false;
            btntrab.Click += btntrab_Click;
            // 
            // Main_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(611, 442);
            Controls.Add(btntrab);
            Controls.Add(button1);
            Controls.Add(btnlib);
            Controls.Add(btnestu);
            Controls.Add(btnconf);
            Controls.Add(btncerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_";
            ResumeLayout(false);
        }

        #endregion

        private Button btncerrar;
        private Button btnconf;
        private Button btnestu;
        private Button btnlib;
        private Button button1;
        private Button btntrab;
    }
}