using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sireduk.model;

namespace Sireduk.view
{
    public partial class KelurahanControl: UserControl
    {
        Kelurahan_cls kelurahan = new Kelurahan_cls();
        public KelurahanControl()
        {
            InitializeComponent();
        }

        private void penduduk_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void KelurahanControl_Load(object sender, EventArgs e)
        {
            indexGrid();
            DataTable kelurahan = new Kelurahan_cls().index();
            
        }

        void indexGrid()
        {

            if (cariTb.Text.Length == 0)
            {
                kelurahan_dgv.DataSource = kelurahan.index();

                warnaBelang(kelurahan_dgv);
                return;
            }

            warnaBelang(kelurahan_dgv);
            kelurahan_dgv.DataSource = kelurahan.search(cariTb.Text);
        }

        void warnaBelang(DataGridView grid)
        {
            foreach (DataGridViewRow baris in grid.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 0)
                    {
                        kolom.Style.BackColor = Color.White;
                    }
                    else
                    {
                        kolom.Style.BackColor = Color.LightBlue;
                    }
                }
            }
        }
    }
}
