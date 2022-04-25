namespace E_Dnevnik
{
    partial class Login
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(327, 138);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(162, 22);
            this.txt_name.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(327, 191);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(162, 22);
            this.txt_pass.TabIndex = 1;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.Red;
            this.lbl_welcome.Location = new System.Drawing.Point(204, 63);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(324, 24);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "Dobrodosli! Da biste nastavili, unesite:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_email.Location = new System.Drawing.Point(233, 136);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(63, 24);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_pass.Location = new System.Drawing.Point(204, 189);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(92, 24);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Password";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ok.Location = new System.Drawing.Point(309, 261);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(95, 39);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "Login";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 389);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_ok;
    }
}