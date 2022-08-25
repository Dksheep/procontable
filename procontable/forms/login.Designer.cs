namespace procontable.forms
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.btnIngresar1 = new System.Windows.Forms.Button();
            this.picUserpass1 = new System.Windows.Forms.PictureBox();
            this.txtpass1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picUser2 = new System.Windows.Forms.PictureBox();
            this.txtuser1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picUserpass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LuzSans-Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(117, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "ProContable";
            // 
            // btnSalir1
            // 
            this.btnSalir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir1.Location = new System.Drawing.Point(70, 303);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(199, 37);
            this.btnSalir1.TabIndex = 18;
            this.btnSalir1.Text = "Salir";
            this.btnSalir1.UseVisualStyleBackColor = true;
            this.btnSalir1.Click += new System.EventHandler(this.btnSalir1_Click);
            // 
            // btnIngresar1
            // 
            this.btnIngresar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnIngresar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar1.Location = new System.Drawing.Point(70, 260);
            this.btnIngresar1.Name = "btnIngresar1";
            this.btnIngresar1.Size = new System.Drawing.Size(199, 37);
            this.btnIngresar1.TabIndex = 16;
            this.btnIngresar1.Text = "Ingresar";
            this.btnIngresar1.UseVisualStyleBackColor = false;
            this.btnIngresar1.Click += new System.EventHandler(this.btnIngresar1_Click);
            // 
            // picUserpass1
            // 
            this.picUserpass1.Image = ((System.Drawing.Image)(resources.GetObject("picUserpass1.Image")));
            this.picUserpass1.Location = new System.Drawing.Point(68, 200);
            this.picUserpass1.Name = "picUserpass1";
            this.picUserpass1.Size = new System.Drawing.Size(29, 27);
            this.picUserpass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserpass1.TabIndex = 20;
            this.picUserpass1.TabStop = false;
            // 
            // txtpass1
            // 
            this.txtpass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtpass1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpass1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtpass1.Location = new System.Drawing.Point(104, 204);
            this.txtpass1.Name = "txtpass1";
            this.txtpass1.PasswordChar = '*';
            this.txtpass1.Size = new System.Drawing.Size(165, 18);
            this.txtpass1.TabIndex = 15;
            this.txtpass1.Text = "Clave";
            this.txtpass1.Enter += new System.EventHandler(this.txtpass1_Enter);
            this.txtpass1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass1_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(68, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 19;
            // 
            // picUser2
            // 
            this.picUser2.Image = ((System.Drawing.Image)(resources.GetObject("picUser2.Image")));
            this.picUser2.Location = new System.Drawing.Point(68, 150);
            this.picUser2.Name = "picUser2";
            this.picUser2.Size = new System.Drawing.Size(29, 27);
            this.picUser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser2.TabIndex = 17;
            this.picUser2.TabStop = false;
            // 
            // txtuser1
            // 
            this.txtuser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtuser1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtuser1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtuser1.Location = new System.Drawing.Point(103, 156);
            this.txtuser1.Name = "txtuser1";
            this.txtuser1.Size = new System.Drawing.Size(165, 18);
            this.txtuser1.TabIndex = 13;
            this.txtuser1.Text = "Usuario";
            this.txtuser1.Enter += new System.EventHandler(this.txtuser1_Enter);
            this.txtuser1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser1_KeyPress);
            this.txtuser1.Leave += new System.EventHandler(this.txtuser1_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(68, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 14;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(347, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir1);
            this.Controls.Add(this.btnIngresar1);
            this.Controls.Add(this.picUserpass1);
            this.Controls.Add(this.txtpass1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picUser2);
            this.Controls.Add(this.txtuser1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserpass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button btnSalir1;
        private Button btnIngresar1;
        private PictureBox picUserpass1;
        private TextBox txtpass1;
        private Panel panel2;
        private PictureBox picUser2;
        private TextBox txtuser1;
        private Panel panel1;
    }
}