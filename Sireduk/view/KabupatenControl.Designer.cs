namespace Sireduk.view
{
    partial class KabupatenControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchIcon = new System.Windows.Forms.Label();
            this.cariTb = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.IdLb = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.nama_kecamatanLb = new System.Windows.Forms.Label();
            this.nama_kabupatenTb = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.kabupaten_dgv = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kabupaten_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.searchIcon);
            this.searchPanel.Controls.Add(this.cariTb);
            this.searchPanel.Location = new System.Drawing.Point(304, 14);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(470, 38);
            this.searchPanel.TabIndex = 32;
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
            this.headerLabel.Location = new System.Drawing.Point(10, 12);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(154, 25);
            this.headerLabel.TabIndex = 31;
            this.headerLabel.Text = "Data kabupaten";
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Controls.Add(this.deleteBtn);
            this.formPanel.Controls.Add(this.IdLb);
            this.formPanel.Controls.Add(this.idTb);
            this.formPanel.Controls.Add(this.nama_kecamatanLb);
            this.formPanel.Controls.Add(this.nama_kabupatenTb);
            this.formPanel.Controls.Add(this.saveBtn);
            this.formPanel.Controls.Add(this.updateBtn);
            this.formPanel.Location = new System.Drawing.Point(15, 60);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(280, 187);
            this.formPanel.TabIndex = 30;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(103, 134);
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
            this.nama_kecamatanLb.Size = new System.Drawing.Size(99, 15);
            this.nama_kecamatanLb.TabIndex = 7;
            this.nama_kecamatanLb.Text = "Nama Kabupaten";
            // 
            // nama_kabupatenTb
            // 
            this.nama_kabupatenTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nama_kabupatenTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_kabupatenTb.Location = new System.Drawing.Point(20, 85);
            this.nama_kabupatenTb.Name = "nama_kabupatenTb";
            this.nama_kabupatenTb.Size = new System.Drawing.Size(240, 25);
            this.nama_kabupatenTb.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(20, 134);
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
            this.updateBtn.Location = new System.Drawing.Point(184, 134);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(76, 32);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Ubah";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // kabupaten_dgv
            // 
            this.kabupaten_dgv.AllowUserToAddRows = false;
            this.kabupaten_dgv.AllowUserToDeleteRows = false;
            this.kabupaten_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kabupaten_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kabupaten_dgv.BackgroundColor = System.Drawing.Color.White;
            this.kabupaten_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kabupaten_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.kabupaten_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kabupaten_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.kabupaten_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kabupaten_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.cNama});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kabupaten_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.kabupaten_dgv.EnableHeadersVisualStyles = false;
            this.kabupaten_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.kabupaten_dgv.Location = new System.Drawing.Point(304, 64);
            this.kabupaten_dgv.Name = "kabupaten_dgv";
            this.kabupaten_dgv.ReadOnly = true;
            this.kabupaten_dgv.RowHeadersVisible = false;
            this.kabupaten_dgv.RowTemplate.Height = 28;
            this.kabupaten_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kabupaten_dgv.Size = new System.Drawing.Size(559, 449);
            this.kabupaten_dgv.TabIndex = 29;
            this.kabupaten_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kabupaten_dgv_CellClick);
            // 
            // cid
            // 
            this.cid.DataPropertyName = "id_kabupaten";
            this.cid.HeaderText = "ID";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // cNama
            // 
            this.cNama.DataPropertyName = "nama_kabupaten";
            this.cNama.HeaderText = "NAMA KABUPATEN";
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            // 
            // KabupatenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.kabupaten_dgv);
            this.Name = "KabupatenControl";
            this.Size = new System.Drawing.Size(863, 516);
            this.Load += new System.EventHandler(this.KabupatenControl_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kabupaten_dgv)).EndInit();
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
        private System.Windows.Forms.TextBox nama_kabupatenTb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView kabupaten_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
    }
}