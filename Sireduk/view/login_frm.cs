using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sireduk.model;

namespace Sireduk.view
{
    public partial class login_frm: Form
    {
        Pengguna_cls pengguna = new Pengguna_cls();
        public login_frm()
        {
            InitializeComponent();
        }

        private void login_cls_Load(object sender, EventArgs e)
        {
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(pengguna.login(userIdTb.Text, passwordTb.Text))
            {
                new MainForm().Show(); 
                this.Hide();
                return;
            }
            MessageBox.Show("Username or password salah", "GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
