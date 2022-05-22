namespace E_Dnevnik
{
    partial class Ocena
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
            this.cmb_godina = new System.Windows.Forms.ComboBox();
            this.cmb_profesor = new System.Windows.Forms.ComboBox();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.cmb_odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_ucenik = new System.Windows.Forms.ComboBox();
            this.cmb_ocena = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.lbl_godina = new System.Windows.Forms.Label();
            this.lbl_profesor = new System.Windows.Forms.Label();
            this.lbl_predmet = new System.Windows.Forms.Label();
            this.lbl_odeljenje = new System.Windows.Forms.Label();
            this.lbl_ucenik = new System.Windows.Forms.Label();
            this.lbl_ocena = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_Datum = new System.Windows.Forms.Label();
            this.Grid_Ocene = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_godina
            // 
            this.cmb_godina.FormattingEnabled = true;
            this.cmb_godina.Location = new System.Drawing.Point(82, 57);
            this.cmb_godina.Name = "cmb_godina";
            this.cmb_godina.Size = new System.Drawing.Size(121, 24);
            this.cmb_godina.TabIndex = 0;
            this.cmb_godina.SelectedValueChanged += new System.EventHandler(this.cmb_godina_SelectedValueChanged);
            // 
            // cmb_profesor
            // 
            this.cmb_profesor.FormattingEnabled = true;
            this.cmb_profesor.Location = new System.Drawing.Point(230, 57);
            this.cmb_profesor.Name = "cmb_profesor";
            this.cmb_profesor.Size = new System.Drawing.Size(121, 24);
            this.cmb_profesor.TabIndex = 1;
            this.cmb_profesor.SelectedValueChanged += new System.EventHandler(this.cmb_profesor_SelectedValueChanged);
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(378, 57);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(121, 24);
            this.cmb_predmet.TabIndex = 2;
            this.cmb_predmet.SelectedValueChanged += new System.EventHandler(this.cmb_predmet_SelectedValueChanged);
            // 
            // cmb_odeljenje
            // 
            this.cmb_odeljenje.FormattingEnabled = true;
            this.cmb_odeljenje.Location = new System.Drawing.Point(527, 57);
            this.cmb_odeljenje.Name = "cmb_odeljenje";
            this.cmb_odeljenje.Size = new System.Drawing.Size(121, 24);
            this.cmb_odeljenje.TabIndex = 3;
            this.cmb_odeljenje.SelectedValueChanged += new System.EventHandler(this.cmb_odeljenje_SelectedValueChanged);
            // 
            // cmb_ucenik
            // 
            this.cmb_ucenik.FormattingEnabled = true;
            this.cmb_ucenik.Location = new System.Drawing.Point(82, 145);
            this.cmb_ucenik.Name = "cmb_ucenik";
            this.cmb_ucenik.Size = new System.Drawing.Size(121, 24);
            this.cmb_ucenik.TabIndex = 4;
            // 
            // cmb_ocena
            // 
            this.cmb_ocena.FormattingEnabled = true;
            this.cmb_ocena.Location = new System.Drawing.Point(230, 145);
            this.cmb_ocena.Name = "cmb_ocena";
            this.cmb_ocena.Size = new System.Drawing.Size(121, 24);
            this.cmb_ocena.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(378, 145);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 24);
            this.txt_id.TabIndex = 7;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(694, 57);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(83, 31);
            this.btn_insert.TabIndex = 8;
            this.btn_insert.Text = "Dodaj";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(694, 94);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(83, 31);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Izmeni";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(694, 130);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 31);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Brisi";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Datum
            // 
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum.Location = new System.Drawing.Point(527, 143);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(121, 22);
            this.Datum.TabIndex = 11;
            // 
            // lbl_godina
            // 
            this.lbl_godina.AutoSize = true;
            this.lbl_godina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_godina.Location = new System.Drawing.Point(79, 19);
            this.lbl_godina.Name = "lbl_godina";
            this.lbl_godina.Size = new System.Drawing.Size(71, 24);
            this.lbl_godina.TabIndex = 12;
            this.lbl_godina.Text = "Godina";
            // 
            // lbl_profesor
            // 
            this.lbl_profesor.AutoSize = true;
            this.lbl_profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_profesor.Location = new System.Drawing.Point(227, 19);
            this.lbl_profesor.Name = "lbl_profesor";
            this.lbl_profesor.Size = new System.Drawing.Size(80, 24);
            this.lbl_profesor.TabIndex = 13;
            this.lbl_profesor.Text = "Profesor";
            // 
            // lbl_predmet
            // 
            this.lbl_predmet.AutoSize = true;
            this.lbl_predmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_predmet.Location = new System.Drawing.Point(375, 19);
            this.lbl_predmet.Name = "lbl_predmet";
            this.lbl_predmet.Size = new System.Drawing.Size(81, 24);
            this.lbl_predmet.TabIndex = 14;
            this.lbl_predmet.Text = "Predmet";
            // 
            // lbl_odeljenje
            // 
            this.lbl_odeljenje.AutoSize = true;
            this.lbl_odeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_odeljenje.Location = new System.Drawing.Point(524, 19);
            this.lbl_odeljenje.Name = "lbl_odeljenje";
            this.lbl_odeljenje.Size = new System.Drawing.Size(92, 24);
            this.lbl_odeljenje.TabIndex = 15;
            this.lbl_odeljenje.Text = "Odeljenje";
            // 
            // lbl_ucenik
            // 
            this.lbl_ucenik.AutoSize = true;
            this.lbl_ucenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ucenik.Location = new System.Drawing.Point(79, 101);
            this.lbl_ucenik.Name = "lbl_ucenik";
            this.lbl_ucenik.Size = new System.Drawing.Size(68, 24);
            this.lbl_ucenik.TabIndex = 16;
            this.lbl_ucenik.Text = "Ucenik";
            // 
            // lbl_ocena
            // 
            this.lbl_ocena.AutoSize = true;
            this.lbl_ocena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ocena.Location = new System.Drawing.Point(227, 101);
            this.lbl_ocena.Name = "lbl_ocena";
            this.lbl_ocena.Size = new System.Drawing.Size(67, 24);
            this.lbl_ocena.TabIndex = 17;
            this.lbl_ocena.Text = "Ocena";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_id.Location = new System.Drawing.Point(375, 101);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(27, 24);
            this.lbl_id.TabIndex = 18;
            this.lbl_id.Text = "ID";
            // 
            // lbl_Datum
            // 
            this.lbl_Datum.AutoSize = true;
            this.lbl_Datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Datum.Location = new System.Drawing.Point(524, 101);
            this.lbl_Datum.Name = "lbl_Datum";
            this.lbl_Datum.Size = new System.Drawing.Size(64, 24);
            this.lbl_Datum.TabIndex = 19;
            this.lbl_Datum.Text = "Datum";
            // 
            // Grid_Ocene
            // 
            this.Grid_Ocene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Ocene.Location = new System.Drawing.Point(82, 212);
            this.Grid_Ocene.Name = "Grid_Ocene";
            this.Grid_Ocene.RowHeadersWidth = 51;
            this.Grid_Ocene.RowTemplate.Height = 24;
            this.Grid_Ocene.Size = new System.Drawing.Size(695, 320);
            this.Grid_Ocene.TabIndex = 20;
            this.Grid_Ocene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Ocene_CellClick);
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 573);
            this.Controls.Add(this.Grid_Ocene);
            this.Controls.Add(this.lbl_Datum);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_ocena);
            this.Controls.Add(this.lbl_ucenik);
            this.Controls.Add(this.lbl_odeljenje);
            this.Controls.Add(this.lbl_predmet);
            this.Controls.Add(this.lbl_profesor);
            this.Controls.Add(this.lbl_godina);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.cmb_ocena);
            this.Controls.Add(this.cmb_ucenik);
            this.Controls.Add(this.cmb_odeljenje);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.cmb_profesor);
            this.Controls.Add(this.cmb_godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_godina;
        private System.Windows.Forms.ComboBox cmb_profesor;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.ComboBox cmb_odeljenje;
        private System.Windows.Forms.ComboBox cmb_ucenik;
        private System.Windows.Forms.ComboBox cmb_ocena;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.Label lbl_godina;
        private System.Windows.Forms.Label lbl_profesor;
        private System.Windows.Forms.Label lbl_predmet;
        private System.Windows.Forms.Label lbl_odeljenje;
        private System.Windows.Forms.Label lbl_ucenik;
        private System.Windows.Forms.Label lbl_ocena;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_Datum;
        private System.Windows.Forms.DataGridView Grid_Ocene;
    }
}