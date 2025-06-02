namespace Sireduk.view
{
    partial class MainForm
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
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.keluarLb = new System.Windows.Forms.Label();
            this.kabupatenLb = new System.Windows.Forms.Label();
            this.kecamatanLb = new System.Windows.Forms.Label();
            this.pendudukLb = new System.Windows.Forms.Label();
            this.dashboardLb = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.appTitle = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.sidebarPanel.Controls.Add(this.menuPanel);
            this.sidebarPanel.Controls.Add(this.headerPanel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(220, 517);
            this.sidebarPanel.TabIndex = 34;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.keluarLb);
            this.menuPanel.Controls.Add(this.kabupatenLb);
            this.menuPanel.Controls.Add(this.kecamatanLb);
            this.menuPanel.Controls.Add(this.pendudukLb);
            this.menuPanel.Controls.Add(this.dashboardLb);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 80);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.menuPanel.Size = new System.Drawing.Size(220, 437);
            this.menuPanel.TabIndex = 1;
            // 
            // keluarLb
            // 
            this.keluarLb.AutoSize = true;
            this.keluarLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keluarLb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluarLb.ForeColor = System.Drawing.Color.White;
            this.keluarLb.Location = new System.Drawing.Point(30, 170);
            this.keluarLb.Name = "keluarLb";
            this.keluarLb.Size = new System.Drawing.Size(77, 20);
            this.keluarLb.TabIndex = 34;
            this.keluarLb.Text = "< KELUAR";
            this.keluarLb.Click += new System.EventHandler(this.keluarLb_Click);
            // 
            // kabupatenLb
            // 
            this.kabupatenLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kabupatenLb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kabupatenLb.ForeColor = System.Drawing.Color.White;
            this.kabupatenLb.Location = new System.Drawing.Point(30, 129);
            this.kabupatenLb.Name = "kabupatenLb";
            this.kabupatenLb.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.kabupatenLb.Size = new System.Drawing.Size(190, 30);
            this.kabupatenLb.TabIndex = 9;
            this.kabupatenLb.Text = "KABUPATEN";
            this.kabupatenLb.Click += new System.EventHandler(this.kabupatenLb_Click);
            // 
            // kecamatanLb
            // 
            this.kecamatanLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kecamatanLb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kecamatanLb.ForeColor = System.Drawing.Color.White;
            this.kecamatanLb.Location = new System.Drawing.Point(30, 95);
            this.kecamatanLb.Name = "kecamatanLb";
            this.kecamatanLb.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.kecamatanLb.Size = new System.Drawing.Size(190, 30);
            this.kecamatanLb.TabIndex = 8;
            this.kecamatanLb.Text = "KECAMATAN";
            this.kecamatanLb.Click += new System.EventHandler(this.kecamatanLb_Click);
            // 
            // pendudukLb
            // 
            this.pendudukLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pendudukLb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendudukLb.ForeColor = System.Drawing.Color.White;
            this.pendudukLb.Location = new System.Drawing.Point(30, 63);
            this.pendudukLb.Name = "pendudukLb";
            this.pendudukLb.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pendudukLb.Size = new System.Drawing.Size(190, 30);
            this.pendudukLb.TabIndex = 7;
            this.pendudukLb.Text = "PENDUDUK";
            this.pendudukLb.Click += new System.EventHandler(this.pendudukLb_Click);
            // 
            // dashboardLb
            // 
            this.dashboardLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardLb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardLb.ForeColor = System.Drawing.Color.White;
            this.dashboardLb.Location = new System.Drawing.Point(30, 30);
            this.dashboardLb.Name = "dashboardLb";
            this.dashboardLb.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dashboardLb.Size = new System.Drawing.Size(190, 30);
            this.dashboardLb.TabIndex = 35;
            this.dashboardLb.Text = "DASHBOARD";
            this.dashboardLb.Click += new System.EventHandler(this.dashboardLb_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.appTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(220, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // appTitle
            // 
            this.appTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.ForeColor = System.Drawing.Color.White;
            this.appTitle.Location = new System.Drawing.Point(0, 0);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(220, 80);
            this.appTitle.TabIndex = 1;
            this.appTitle.Text = "SIREDUK";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.container);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(220, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(922, 517);
            this.mainContainer.TabIndex = 35;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Padding = new System.Windows.Forms.Padding(20);
            this.container.Size = new System.Drawing.Size(922, 517);
            this.container.TabIndex = 35;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 517);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.sidebarPanel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Informasi Kependudukan";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label keluarLb;
        private System.Windows.Forms.Label kabupatenLb;
        private System.Windows.Forms.Label kecamatanLb;
        private System.Windows.Forms.Label pendudukLb;
        private System.Windows.Forms.Label dashboardLb;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Panel mainContainer;
    }
}