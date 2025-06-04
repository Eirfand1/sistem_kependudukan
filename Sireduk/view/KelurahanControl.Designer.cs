namespace Sireduk.view
{
    partial class KelurahanControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formPanel = new System.Windows.Forms.Panel();
            this.nama_kelurahanTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kode_posTb = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.nikLb = new System.Windows.Forms.Label();
            this.id_kelurahanTb = new System.Windows.Forms.TextBox();
            this.nama_kecamatanLb = new System.Windows.Forms.Label();
            this.id_kecamatanTb = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.kelurahan_dgv = new System.Windows.Forms.DataGridView();
            this.cidk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidkecamatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnama_kelurahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckode_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchIcon = new System.Windows.Forms.Label();
            this.cariTb = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelurahan_dgv)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Controls.Add(this.nama_kelurahanTb);
            this.formPanel.Controls.Add(this.label2);
            this.formPanel.Controls.Add(this.label1);
            this.formPanel.Controls.Add(this.kode_posTb);
            this.formPanel.Controls.Add(this.deleteBtn);
            this.formPanel.Controls.Add(this.nikLb);
            this.formPanel.Controls.Add(this.id_kelurahanTb);
            this.formPanel.Controls.Add(this.nama_kecamatanLb);
            this.formPanel.Controls.Add(this.id_kecamatanTb);
            this.formPanel.Controls.Add(this.saveBtn);
            this.formPanel.Controls.Add(this.updateBtn);
            this.formPanel.Location = new System.Drawing.Point(10, 83);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(280, 329);
            this.formPanel.TabIndex = 35;
            // 
            // nama_kelurahanTb
            // 
            this.nama_kelurahanTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nama_kelurahanTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_kelurahanTb.Location = new System.Drawing.Point(20, 136);
            this.nama_kelurahanTb.Name = "nama_kelurahanTb";
            this.nama_kelurahanTb.Size = new System.Drawing.Size(240, 25);
            this.nama_kelurahanTb.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(19, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kode Pos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nama Kelurahan";
            // 
            // kode_posTb
            // 
            this.kode_posTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kode_posTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kode_posTb.Location = new System.Drawing.Point(20, 187);
            this.kode_posTb.Name = "kode_posTb";
            this.kode_posTb.Size = new System.Drawing.Size(240, 25);
            this.kode_posTb.TabIndex = 15;
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
            this.nikLb.Size = new System.Drawing.Size(74, 15);
            this.nikLb.TabIndex = 6;
            this.nikLb.Text = "ID Kelurahan";
            // 
            // id_kelurahanTb
            // 
            this.id_kelurahanTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_kelurahanTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_kelurahanTb.Location = new System.Drawing.Point(20, 30);
            this.id_kelurahanTb.Name = "id_kelurahanTb";
            this.id_kelurahanTb.Size = new System.Drawing.Size(240, 25);
            this.id_kelurahanTb.TabIndex = 3;
            // 
            // nama_kecamatanLb
            // 
            this.nama_kecamatanLb.AutoSize = true;
            this.nama_kecamatanLb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_kecamatanLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nama_kecamatanLb.Location = new System.Drawing.Point(17, 67);
            this.nama_kecamatanLb.Name = "nama_kecamatanLb";
            this.nama_kecamatanLb.Size = new System.Drawing.Size(80, 15);
            this.nama_kecamatanLb.TabIndex = 7;
            this.nama_kecamatanLb.Text = "ID Kecamatan";
            // 
            // id_kecamatanTb
            // 
            this.id_kecamatanTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_kecamatanTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_kecamatanTb.Location = new System.Drawing.Point(20, 85);
            this.id_kecamatanTb.Name = "id_kecamatanTb";
            this.id_kecamatanTb.Size = new System.Drawing.Size(240, 25);
            this.id_kecamatanTb.TabIndex = 4;
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
            // 
            // kelurahan_dgv
            // 
            this.kelurahan_dgv.AllowUserToAddRows = false;
            this.kelurahan_dgv.AllowUserToDeleteRows = false;
            this.kelurahan_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kelurahan_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kelurahan_dgv.BackgroundColor = System.Drawing.Color.White;
            this.kelurahan_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kelurahan_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.kelurahan_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kelurahan_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.kelurahan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kelurahan_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidk,
            this.cidkecamatan,
            this.cnama_kelurahan,
            this.ckode_pos});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kelurahan_dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.kelurahan_dgv.EnableHeadersVisualStyles = false;
            this.kelurahan_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.kelurahan_dgv.Location = new System.Drawing.Point(301, 83);
            this.kelurahan_dgv.Name = "kelurahan_dgv";
            this.kelurahan_dgv.ReadOnly = true;
            this.kelurahan_dgv.RowHeadersVisible = false;
            this.kelurahan_dgv.RowHeadersWidth = 62;
            this.kelurahan_dgv.RowTemplate.Height = 28;
            this.kelurahan_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kelurahan_dgv.Size = new System.Drawing.Size(439, 410);
            this.kelurahan_dgv.TabIndex = 36;
            this.kelurahan_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kelurahan_dgv_CellClick);
            this.kelurahan_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.penduduk_dgv_CellContentClick);
            // 
            // cidk
            // 
            this.cidk.DataPropertyName = "id_kelurahan";
            this.cidk.HeaderText = "ID KELURAHAN";
            this.cidk.MinimumWidth = 8;
            this.cidk.Name = "cidk";
            this.cidk.ReadOnly = true;
            // 
            // cidkecamatan
            // 
            this.cidkecamatan.DataPropertyName = "id_kecamatan";
            this.cidkecamatan.HeaderText = "ID KECAMATAN";
            this.cidkecamatan.MinimumWidth = 8;
            this.cidkecamatan.Name = "cidkecamatan";
            this.cidkecamatan.ReadOnly = true;
            // 
            // cnama_kelurahan
            // 
            this.cnama_kelurahan.DataPropertyName = "nama_kelurahan";
            this.cnama_kelurahan.HeaderText = "NAMA KELURAHAN";
            this.cnama_kelurahan.MinimumWidth = 8;
            this.cnama_kelurahan.Name = "cnama_kelurahan";
            this.cnama_kelurahan.ReadOnly = true;
            // 
            // ckode_pos
            // 
            this.ckode_pos.DataPropertyName = "kode_pos";
            this.ckode_pos.HeaderText = "KODE POS";
            this.ckode_pos.MinimumWidth = 8;
            this.ckode_pos.Name = "ckode_pos";
            this.ckode_pos.ReadOnly = true;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.searchIcon);
            this.searchPanel.Controls.Add(this.cariTb);
            this.searchPanel.Location = new System.Drawing.Point(301, 27);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(442, 34);
            this.searchPanel.TabIndex = 37;
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
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.headerLabel.Location = new System.Drawing.Point(17, 27);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(148, 25);
            this.headerLabel.TabIndex = 38;
            this.headerLabel.Text = "Data Kelurahan";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // KelurahanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.kelurahan_dgv);
            this.Controls.Add(this.formPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KelurahanControl";
            this.Size = new System.Drawing.Size(743, 506);
            this.Load += new System.EventHandler(this.KelurahanControl_Load);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelurahan_dgv)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kode_posTb;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label nikLb;
        private System.Windows.Forms.TextBox id_kelurahanTb;
        private System.Windows.Forms.Label nama_kecamatanLb;
        private System.Windows.Forms.TextBox id_kecamatanTb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView kelurahan_dgv;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label searchIcon;
        private System.Windows.Forms.TextBox cariTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidk;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidkecamatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnama_kelurahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckode_pos;
        private System.Windows.Forms.TextBox nama_kelurahanTb;
        private System.Windows.Forms.Label headerLabel;
    }
}
