namespace Racun
{
    partial class Form1
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_br_racuna = new System.Windows.Forms.TextBox();
            this.txt_kupac = new System.Windows.Forms.TextBox();
            this.txt_datum = new System.Windows.Forms.TextBox();
            this.txt_vrednost = new System.Windows.Forms.TextBox();
            this.txt_br_stavki = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_r = new System.Windows.Forms.Button();
            this.button_l = new System.Windows.Forms.Button();
            this.button_rr = new System.Windows.Forms.Button();
            this.button_ll = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_isprazni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(305, 64);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(138, 22);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_br_racuna
            // 
            this.txt_br_racuna.Location = new System.Drawing.Point(305, 108);
            this.txt_br_racuna.Name = "txt_br_racuna";
            this.txt_br_racuna.Size = new System.Drawing.Size(138, 22);
            this.txt_br_racuna.TabIndex = 1;
            this.txt_br_racuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_kupac
            // 
            this.txt_kupac.Location = new System.Drawing.Point(305, 154);
            this.txt_kupac.Name = "txt_kupac";
            this.txt_kupac.Size = new System.Drawing.Size(138, 22);
            this.txt_kupac.TabIndex = 2;
            this.txt_kupac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_datum
            // 
            this.txt_datum.Location = new System.Drawing.Point(305, 201);
            this.txt_datum.Name = "txt_datum";
            this.txt_datum.Size = new System.Drawing.Size(138, 22);
            this.txt_datum.TabIndex = 3;
            this.txt_datum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_vrednost
            // 
            this.txt_vrednost.Location = new System.Drawing.Point(305, 247);
            this.txt_vrednost.Name = "txt_vrednost";
            this.txt_vrednost.Size = new System.Drawing.Size(138, 22);
            this.txt_vrednost.TabIndex = 4;
            this.txt_vrednost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_br_stavki
            // 
            this.txt_br_stavki.Location = new System.Drawing.Point(305, 290);
            this.txt_br_stavki.Name = "txt_br_stavki";
            this.txt_br_stavki.Size = new System.Drawing.Size(138, 22);
            this.txt_br_stavki.TabIndex = 5;
            this.txt_br_stavki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(171, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(171, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Broj računa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(171, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kupac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(171, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(171, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vrednost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(171, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Broj stavki";
            // 
            // button_r
            // 
            this.button_r.Location = new System.Drawing.Point(343, 357);
            this.button_r.Name = "button_r";
            this.button_r.Size = new System.Drawing.Size(85, 35);
            this.button_r.TabIndex = 12;
            this.button_r.Text = ">";
            this.button_r.UseVisualStyleBackColor = true;
            this.button_r.Click += new System.EventHandler(this.button_r_Click);
            // 
            // button_l
            // 
            this.button_l.Location = new System.Drawing.Point(226, 357);
            this.button_l.Name = "button_l";
            this.button_l.Size = new System.Drawing.Size(85, 35);
            this.button_l.TabIndex = 13;
            this.button_l.Text = "<";
            this.button_l.UseVisualStyleBackColor = true;
            this.button_l.Click += new System.EventHandler(this.button_l_Click);
            // 
            // button_rr
            // 
            this.button_rr.Location = new System.Drawing.Point(434, 357);
            this.button_rr.Name = "button_rr";
            this.button_rr.Size = new System.Drawing.Size(85, 35);
            this.button_rr.TabIndex = 14;
            this.button_rr.Text = ">>";
            this.button_rr.UseVisualStyleBackColor = true;
            this.button_rr.Click += new System.EventHandler(this.button_rr_Click);
            // 
            // button_ll
            // 
            this.button_ll.Location = new System.Drawing.Point(135, 357);
            this.button_ll.Name = "button_ll";
            this.button_ll.Size = new System.Drawing.Size(85, 35);
            this.button_ll.TabIndex = 15;
            this.button_ll.Text = "<<";
            this.button_ll.UseVisualStyleBackColor = true;
            this.button_ll.Click += new System.EventHandler(this.button_ll_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(176, 434);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(85, 35);
            this.button_insert.TabIndex = 16;
            this.button_insert.Text = "INSERT";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(288, 434);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(85, 35);
            this.button_update.TabIndex = 17;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(396, 434);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(85, 35);
            this.button_delete.TabIndex = 18;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_isprazni
            // 
            this.button_isprazni.Location = new System.Drawing.Point(478, 284);
            this.button_isprazni.Name = "button_isprazni";
            this.button_isprazni.Size = new System.Drawing.Size(90, 35);
            this.button_isprazni.TabIndex = 19;
            this.button_isprazni.Text = "ISPRAZNI\r\n";
            this.button_isprazni.UseVisualStyleBackColor = true;
            this.button_isprazni.Click += new System.EventHandler(this.button_isprazni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 568);
            this.Controls.Add(this.button_isprazni);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_ll);
            this.Controls.Add(this.button_rr);
            this.Controls.Add(this.button_l);
            this.Controls.Add(this.button_r);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_br_stavki);
            this.Controls.Add(this.txt_vrednost);
            this.Controls.Add(this.txt_datum);
            this.Controls.Add(this.txt_kupac);
            this.Controls.Add(this.txt_br_racuna);
            this.Controls.Add(this.txt_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_br_racuna;
        private System.Windows.Forms.TextBox txt_kupac;
        private System.Windows.Forms.TextBox txt_datum;
        private System.Windows.Forms.TextBox txt_vrednost;
        private System.Windows.Forms.TextBox txt_br_stavki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_r;
        private System.Windows.Forms.Button button_l;
        private System.Windows.Forms.Button button_rr;
        private System.Windows.Forms.Button button_ll;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_isprazni;
    }
}

