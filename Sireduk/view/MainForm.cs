using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sireduk.view
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Panel mainPanel;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.mainPanel = container;
            var dashboardControl = new dashboard();
            ShowControl(dashboardControl);

        }

        public void ShowControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

        private void pendudukLb_Click(object sender, EventArgs e)
        {
            var pendudukControl = new PendudukControl();
            ShowControl(pendudukControl);
        }

        private void kecamatanLb_Click(object sender, EventArgs e)
        {

            var kecamatanControl = new KecamatanControl();
            ShowControl(kecamatanControl);

        }

        private void kabupatenLb_Click(object sender, EventArgs e)
        {
            var kabupatenControl = new KabupatenControl();
            ShowControl(kabupatenControl);

        }

        private void dashboardLb_Click(object sender, EventArgs e)
        {
            var dashboardControl = new dashboard();
            ShowControl(dashboardControl);
        }

        private void keluarLb_Click(object sender, EventArgs e)
        {
            new login_frm().Show();
            this.Hide();
        }
    }
}
