namespace Beats_Cary
{
    partial class fr_grafica
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.reg_ini = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_ini = new System.Windows.Forms.CheckBox();
            this.btn_ini = new System.Windows.Forms.Button();
            this.cla_ini = new System.Windows.Forms.TextBox();
            this.usu_ini = new System.Windows.Forms.TextBox();
            this.inicio_se = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.reg_ini);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.box_ini);
            this.panel1.Controls.Add(this.btn_ini);
            this.panel1.Controls.Add(this.cla_ini);
            this.panel1.Controls.Add(this.usu_ini);
            this.panel1.Controls.Add(this.inicio_se);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 633);
            this.panel1.TabIndex = 0;
            // 
            // reg_ini
            // 
            this.reg_ini.AutoSize = true;
            this.reg_ini.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_ini.LinkColor = System.Drawing.Color.DodgerBlue;
            this.reg_ini.Location = new System.Drawing.Point(223, 488);
            this.reg_ini.Name = "reg_ini";
            this.reg_ini.Size = new System.Drawing.Size(65, 15);
            this.reg_ini.TabIndex = 10;
            this.reg_ini.TabStop = true;
            this.reg_ini.Text = "Registrate";
            this.reg_ini.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reg_ini_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "¿No tienes cuenta?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            // 
            // box_ini
            // 
            this.box_ini.AutoSize = true;
            this.box_ini.Location = new System.Drawing.Point(81, 407);
            this.box_ini.Name = "box_ini";
            this.box_ini.Size = new System.Drawing.Size(84, 17);
            this.box_ini.TabIndex = 6;
            this.box_ini.Text = "Recordarme";
            this.box_ini.UseVisualStyleBackColor = true;
            this.box_ini.CheckedChanged += new System.EventHandler(this.box_ini_CheckedChanged);
            // 
            // btn_ini
            // 
            this.btn_ini.BackColor = System.Drawing.Color.Black;
            this.btn_ini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ini.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ini.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ini.Location = new System.Drawing.Point(81, 360);
            this.btn_ini.Name = "btn_ini";
            this.btn_ini.Size = new System.Drawing.Size(280, 41);
            this.btn_ini.TabIndex = 5;
            this.btn_ini.Text = "Ingresar";
            this.btn_ini.UseVisualStyleBackColor = false;
            this.btn_ini.Click += new System.EventHandler(this.button1_Click);
            // 
            // cla_ini
            // 
            this.cla_ini.Location = new System.Drawing.Point(81, 291);
            this.cla_ini.Multiline = true;
            this.cla_ini.Name = "cla_ini";
            this.cla_ini.Size = new System.Drawing.Size(280, 29);
            this.cla_ini.TabIndex = 2;
            this.cla_ini.TextChanged += new System.EventHandler(this.cla_ini_TextChanged);
            // 
            // usu_ini
            // 
            this.usu_ini.Location = new System.Drawing.Point(81, 215);
            this.usu_ini.Multiline = true;
            this.usu_ini.Name = "usu_ini";
            this.usu_ini.Size = new System.Drawing.Size(280, 29);
            this.usu_ini.TabIndex = 1;
            this.usu_ini.TextChanged += new System.EventHandler(this.usu_ini_TextChanged);
            // 
            // inicio_se
            // 
            this.inicio_se.AutoSize = true;
            this.inicio_se.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio_se.Location = new System.Drawing.Point(76, 128);
            this.inicio_se.Name = "inicio_se";
            this.inicio_se.Size = new System.Drawing.Size(178, 30);
            this.inicio_se.TabIndex = 0;
            this.inicio_se.Text = "Iniciar Sesion";
            this.inicio_se.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(434, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 633);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Beats_Cary.Properties.Resources.Untitled_design_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(128, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 495);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fr_grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fr_grafica";
            this.Text = "Grafica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label inicio_se;
        private System.Windows.Forms.CheckBox box_ini;
        private System.Windows.Forms.Button btn_ini;
        private System.Windows.Forms.TextBox cla_ini;
        private System.Windows.Forms.TextBox usu_ini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel reg_ini;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

