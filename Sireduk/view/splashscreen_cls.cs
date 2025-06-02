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
    public partial class splashscreen_cls: Form
    {
        public splashscreen_cls()
        {
            InitializeComponent();
        }

        private async void splashscreen_cls_Load(object sender, EventArgs e)
        {
            await Task.Delay(3000); // Tunggu 3 detik
            this.Hide();
            login_frm login = new login_frm();
            login.Show();
        }
    }
}
