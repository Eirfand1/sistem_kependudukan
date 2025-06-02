namespace Sireduk.view
{
    partial class KecamatanControl
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.IdLb = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.nama_kecamatanLb = new System.Windows.Forms.Label();
            this.nama_kecamatanTb = new System.Windows.Forms.TextBox();
            this.id_kabupatenLb = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.kecamatan_dgv = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId_Kabupaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama_Kabupaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kabupatenCb = new System.Windows.Forms.ComboBox();
            this.searchPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kecamatan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.searchIcon);
            this.searchPanel.Controls.Add(this.cariTb);
            this.searchPanel.Location = new System.Drawing.Point(299, 13);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(470, 38);
            this.searchPanel.TabIndex = 28;
            // 
            // searchIcon
            // 
            this.searchIcon.AutoSize = true;
            this.searchIcon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIcon.ForeColor = System.Drawing.Color.Gray;
            this.searchIcon.Location = new System.Drawing.Point(12, 9);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(30, 20);
            this.searchIcon.TabIndex = 16;
            this.searchIcon.Text = "🔍";
            // 
            // cariTb
            // 
            this.cariTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cariTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariTb.Location = new System.Drawing.Point(51, 9);
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
            this.headerLabel.Location = new System.Drawing.Point(14, 29);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(154, 25);
            this.headerLabel.TabIndex = 27;
            this.headerLabel.Text = "Data kecamatan";
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Controls.Add(this.kabupatenCb);
            this.formPanel.Controls.Add(this.deleteBtn);
            this.formPanel.Controls.Add(this.IdLb);
            this.formPanel.Controls.Add(this.idTb);
            this.formPanel.Controls.Add(this.nama_kecamatanLb);
            this.formPanel.Controls.Add(this.nama_kecamatanTb);
            this.formPanel.Controls.Add(this.id_kabupatenLb);
            this.formPanel.Controls.Add(this.saveBtn);
            this.formPanel.Controls.Add(this.updateBtn);
            this.formPanel.Location = new System.Drawing.Point(9, 66);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(280, 236);
            this.formPanel.TabIndex = 26;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(103, 181);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(77, 32);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Hapus";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // IdLb
            // 
            this.IdLb.AutoSize = true;
            this.IdLb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IdLb.Location = new System.Drawing.Point(17, 12);
            this.IdLb.Name = "IdLb";
            this.IdLb.Size = new System.Drawing.Size(18, 15);
            this.IdLb.TabIndex = 6;
            this.IdLb.Text = "ID";
            // 
            // idTb
            // 
            this.idTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTb.Location = new System.Drawing.Point(20, 30);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(240, 25);
            this.idTb.TabIndex = 3;
            // 
            // nama_kecamatanLb
            // 
            this.nama_kecamatanLb.AutoSize = true;
            this.nama_kecamatanLb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_kecamatanLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nama_kecamatanLb.Location = new System.Drawing.Point(17, 67);
            this.nama_kecamatanLb.Name = "nama_kecamatanLb";
            this.nama_kecamatanLb.Size = new System.Drawing.Size(101, 15);
            this.nama_kecamatanLb.TabIndex = 7;
            this.nama_kecamatanLb.Text = "Nama Kecamatan";
            // 
            // nama_kecamatanTb
            // 
            this.nama_kecamatanTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nama_kecamatanTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_kecamatanTb.Location = new System.Drawing.Point(20, 85);
            this.nama_kecamatanTb.Name = "nama_kecamatanTb";
            this.nama_kecamatanTb.Size = new System.Drawing.Size(240, 25);
            this.nama_kecamatanTb.TabIndex = 4;
            // 
            // id_kabupatenLb
            // 
            this.id_kabupatenLb.AutoSize = true;
            this.id_kabupatenLb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_kabupatenLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_kabupatenLb.Location = new System.Drawing.Point(17, 122);
            this.id_kabupatenLb.Name = "id_kabupatenLb";
            this.id_kabupatenLb.Size = new System.Drawing.Size(64, 15);
            this.id_kabupatenLb.TabIndex = 9;
            this.id_kabupatenLb.Text = "Kabupaten";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(20, 181);
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
            this.updateBtn.Location = new System.Drawing.Point(184, 181);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(76, 32);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Ubah";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // kecamatan_dgv
            // 
            this.kecamatan_dgv.AllowUserToAddRows = false;
            this.kecamatan_dgv.AllowUserToDeleteRows = false;
            this.kecamatan_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kecamatan_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kecamatan_dgv.BackgroundColor = System.Drawing.Color.White;
            this.kecamatan_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kecamatan_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.kecamatan_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kecamatan_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.kecamatan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kecamatan_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.cNama,
            this.cId_Kabupaten,
            this.cNama_Kabupaten});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kecamatan_dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.kecamatan_dgv.EnableHeadersVisualStyles = false;
            this.kecamatan_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.kecamatan_dgv.Location = new System.Drawing.Point(300, 65);
            this.kecamatan_dgv.Name = "kecamatan_dgv";
            this.kecamatan_dgv.ReadOnly = true;
            this.kecamatan_dgv.RowHeadersVisible = false;
            this.kecamatan_dgv.RowTemplate.Height = 28;
            this.kecamatan_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kecamatan_dgv.Size = new System.Drawing.Size(731, 469);
            this.kecamatan_dgv.TabIndex = 25;
            this.kecamatan_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kecamatan_dgv_CellClick);
            // 
            // cid
            // 
            this.cid.DataPropertyName = "id_kecamatan";
            this.cid.HeaderText = "ID";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // cNama
            // 
            this.cNama.DataPropertyName = "nama_kecamatan";
            this.cNama.HeaderText = "NAMA KECAMATAN";
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            // 
            // cId_Kabupaten
            // 
            this.cId_Kabupaten.DataPropertyName = "id_kabupaten";
            this.cId_Kabupaten.HeaderText = "ID KABUPATEN";
            this.cId_Kabupaten.Name = "cId_Kabupaten";
            this.cId_Kabupaten.ReadOnly = true;
            // 
            // cNama_Kabupaten
            // 
            this.cNama_Kabupaten.DataPropertyName = "nama_kabupaten";
            this.cNama_Kabupaten.HeaderText = "NAMA KABUPATEN";
            this.cNama_Kabupaten.Name = "cNama_Kabupaten";
            this.cNama_Kabupaten.ReadOnly = true;
            // 
            // kabupatenCb
            // 
            this.kabupatenCb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kabupatenCb.FormattingEnabled = true;
            this.kabupatenCb.Location = new System.Drawing.Point(20, 140);
            this.kabupatenCb.Name = "kabupatenCb";
            this.kabupatenCb.Size = new System.Drawing.Size(240, 25);
            this.kabupatenCb.TabIndex = 14;
            // 
            // KecamatanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.kecamatan_dgv);
            this.Name = "KecamatanControl";
            this.Size = new System.Drawing.Size(1031, 537);
            this.Load += new System.EventHandler(this.KecamatanControl_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kecamatan_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label searchIcon;
        private System.Windows.Forms.TextBox cariTb;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label IdLb;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label nama_kecamatanLb;
        private System.Windows.Forms.TextBox nama_kecamatanTb;
        private System.Windows.Forms.Label id_kabupatenLb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView kecamatan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId_Kabupaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama_Kabupaten;
        private System.Windows.Forms.ComboBox kabupatenCb;
    }
}