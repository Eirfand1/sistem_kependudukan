namespace Sireduk.view
{
    partial class PendudukControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchIcon = new System.Windows.Forms.Label();
            this.cariTb = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desaTb = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.nikLb = new System.Windows.Forms.Label();
            this.nikTb = new System.Windows.Forms.TextBox();
            this.nama_kecamatanLb = new System.Windows.Forms.Label();
            this.nama_pendudukTb = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.penduduk_dgv = new System.Windows.Forms.DataGridView();
            this.cnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJenis_kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId_kecamatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama_kecamatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kecamatanCb = new System.Windows.Forms.ComboBox();
            this.lakiRb = new System.Windows.Forms.RadioButton();
            this.perempuanRb = new System.Windows.Forms.RadioButton();
            this.searchPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penduduk_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.searchIcon);
            this.searchPanel.Controls.Add(this.cariTb);
            this.searchPanel.Location = new System.Drawing.Point(302, 20);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(478, 34);
            this.searchPanel.TabIndex = 36;
            // 
            // searchIcon
            // 
            this.searchIcon.AutoSize = true;
            this.searchIcon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIcon.ForeColor = System.Drawing.Color.Gray;
            this.searchIcon.Location = new System.Drawing.Point(12, 6);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(30, 20);
            this.searchIcon.TabIndex = 16;
            this.searchIcon.Text = "🔍";
            // 
            // cariTb
            // 
            this.cariTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cariTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariTb.Location = new System.Drawing.Point(51, 8);
            this.cariTb.Name = "cariTb";
            this.cariTb.Size = new System.Drawing.Size(397, 20);
            this.cariTb.TabIndex = 15;
            this.cariTb.TextChanged += new System.EventHandler(this.cariTb_TextChanged);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.headerLabel.Location = new System.Drawing.Point(14, 22);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(150, 25);
            this.headerLabel.TabIndex = 35;
            this.headerLabel.Text = "Data Penduduk";
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Controls.Add(this.perempuanRb);
            this.formPanel.Controls.Add(this.lakiRb);
            this.formPanel.Controls.Add(this.kecamatanCb);
            this.formPanel.Controls.Add(this.label3);
            this.formPanel.Controls.Add(this.label2);
            this.formPanel.Controls.Add(this.label1);
            this.formPanel.Controls.Add(this.desaTb);
            this.formPanel.Controls.Add(this.deleteBtn);
            this.formPanel.Controls.Add(this.nikLb);
            this.formPanel.Controls.Add(this.nikTb);
            this.formPanel.Controls.Add(this.nama_kecamatanLb);
            this.formPanel.Controls.Add(this.nama_pendudukTb);
            this.formPanel.Controls.Add(this.saveBtn);
            this.formPanel.Controls.Add(this.updateBtn);
            this.formPanel.Location = new System.Drawing.Point(13, 67);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(280, 329);
            this.formPanel.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(19, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Id Kecamatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(19, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Desa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Jenis Kelamin";
            // 
            // desaTb
            // 
            this.desaTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desaTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desaTb.Location = new System.Drawing.Point(20, 183);
            this.desaTb.Name = "desaTb";
            this.desaTb.Size = new System.Drawing.Size(240, 25);
            this.desaTb.TabIndex = 15;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(102, 276);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(77, 32);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Hapus";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // nikLb
            // 
            this.nikLb.AutoSize = true;
            this.nikLb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nikLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nikLb.Location = new System.Drawing.Point(17, 12);
            this.nikLb.Name = "nikLb";
            this.nikLb.Size = new System.Drawing.Size(26, 15);
            this.nikLb.TabIndex = 6;
            this.nikLb.Text = "NIK";
            // 
            // nikTb
            // 
            this.nikTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nikTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nikTb.Location = new System.Drawing.Point(20, 30);
            this.nikTb.Name = "nikTb";
            this.nikTb.Size = new System.Drawing.Size(240, 25);
            this.nikTb.TabIndex = 3;
            // 
            // nama_kecamatanLb
            // 
            this.nama_kecamatanLb.AutoSize = true;
            this.nama_kecamatanLb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_kecamatanLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nama_kecamatanLb.Location = new System.Drawing.Point(17, 67);
            this.nama_kecamatanLb.Name = "nama_kecamatanLb";
            this.nama_kecamatanLb.Size = new System.Drawing.Size(96, 15);
            this.nama_kecamatanLb.TabIndex = 7;
            this.nama_kecamatanLb.Text = "Nama Penduduk";
            // 
            // nama_pendudukTb
            // 
            this.nama_pendudukTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nama_pendudukTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_pendudukTb.Location = new System.Drawing.Point(20, 85);
            this.nama_pendudukTb.Name = "nama_pendudukTb";
            this.nama_pendudukTb.Size = new System.Drawing.Size(240, 25);
            this.nama_pendudukTb.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(19, 276);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(79, 32);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Simpan";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(183, 276);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(76, 32);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Ubah";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // penduduk_dgv
            // 
            this.penduduk_dgv.AllowUserToAddRows = false;
            this.penduduk_dgv.AllowUserToDeleteRows = false;
            this.penduduk_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.penduduk_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.penduduk_dgv.BackgroundColor = System.Drawing.Color.White;
            this.penduduk_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.penduduk_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.penduduk_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.penduduk_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.penduduk_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.penduduk_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnik,
            this.cNama,
            this.cJenis_kelamin,
            this.cDesa,
            this.cId_kecamatan,
            this.cNama_kecamatan});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.penduduk_dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.penduduk_dgv.EnableHeadersVisualStyles = false;
            this.penduduk_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.penduduk_dgv.Location = new System.Drawing.Point(302, 67);
            this.penduduk_dgv.Name = "penduduk_dgv";
            this.penduduk_dgv.ReadOnly = true;
            this.penduduk_dgv.RowHeadersVisible = false;
            this.penduduk_dgv.RowTemplate.Height = 28;
            this.penduduk_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.penduduk_dgv.Size = new System.Drawing.Size(679, 461);
            this.penduduk_dgv.TabIndex = 33;
            this.penduduk_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.penduduk_dgv_CellClick);
            // 
            // cnik
            // 
            this.cnik.DataPropertyName = "nik";
            this.cnik.HeaderText = "NIK";
            this.cnik.Name = "cnik";
            this.cnik.ReadOnly = true;
            // 
            // cNama
            // 
            this.cNama.DataPropertyName = "nama_penduduk";
            this.cNama.HeaderText = "NAMA PENDUDUK";
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            // 
            // cJenis_kelamin
            // 
            this.cJenis_kelamin.DataPropertyName = "jenis_kelamin";
            this.cJenis_kelamin.HeaderText = "JENIS KELAMIN";
            this.cJenis_kelamin.Name = "cJenis_kelamin";
            this.cJenis_kelamin.ReadOnly = true;
            // 
            // cDesa
            // 
            this.cDesa.DataPropertyName = "desa";
            this.cDesa.HeaderText = "DESA";
            this.cDesa.Name = "cDesa";
            this.cDesa.ReadOnly = true;
            // 
            // cId_kecamatan
            // 
            this.cId_kecamatan.DataPropertyName = "id_kecamatan";
            this.cId_kecamatan.HeaderText = "ID KECAMATAN";
            this.cId_kecamatan.Name = "cId_kecamatan";
            this.cId_kecamatan.ReadOnly = true;
            // 
            // cNama_kecamatan
            // 
            this.cNama_kecamatan.DataPropertyName = "nama_kecamatan";
            this.cNama_kecamatan.HeaderText = "KECAMATAN";
            this.cNama_kecamatan.Name = "cNama_kecamatan";
            this.cNama_kecamatan.ReadOnly = true;
            // 
            // kecamatanCb
            // 
            this.kecamatanCb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kecamatanCb.FormattingEnabled = true;
            this.kecamatanCb.Location = new System.Drawing.Point(20, 235);
            this.kecamatanCb.Name = "kecamatanCb";
            this.kecamatanCb.Size = new System.Drawing.Size(239, 25);
            this.kecamatanCb.TabIndex = 20;
            // 
            // lakiRb
            // 
            this.lakiRb.AutoSize = true;
            this.lakiRb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lakiRb.Location = new System.Drawing.Point(118, 135);
            this.lakiRb.Name = "lakiRb";
            this.lakiRb.Size = new System.Drawing.Size(72, 21);
            this.lakiRb.TabIndex = 21;
            this.lakiRb.TabStop = true;
            this.lakiRb.Text = "Laki-laki";
            this.lakiRb.UseVisualStyleBackColor = true;
            // 
            // perempuanRb
            // 
            this.perempuanRb.AutoSize = true;
            this.perempuanRb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perempuanRb.Location = new System.Drawing.Point(22, 135);
            this.perempuanRb.Name = "perempuanRb";
            this.perempuanRb.Size = new System.Drawing.Size(92, 21);
            this.perempuanRb.TabIndex = 22;
            this.perempuanRb.TabStop = true;
            this.perempuanRb.Text = "Perempuan";
            this.perempuanRb.UseVisualStyleBackColor = true;
            // 
            // PendudukControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.penduduk_dgv);
            this.Name = "PendudukControl";
            this.Size = new System.Drawing.Size(984, 531);
            this.Load += new System.EventHandler(this.PendudukControl_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penduduk_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label searchIcon;
        private System.Windows.Forms.TextBox cariTb;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox desaTb;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label nikLb;
        private System.Windows.Forms.TextBox nikTb;
        private System.Windows.Forms.Label nama_kecamatanLb;
        private System.Windows.Forms.TextBox nama_pendudukTb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView penduduk_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cJenis_kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_kecamatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama_kecamatan;
        private System.Windows.Forms.ComboBox kecamatanCb;
        private System.Windows.Forms.RadioButton perempuanRb;
        private System.Windows.Forms.RadioButton lakiRb;
    }
}