using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sireduk.config;

namespace Sireduk.model
{
    class Kecamatan_cls
    {
        private string _id_kecamatan, _nama_kecamatan, _id_kabupaten;
        KoneksiDb_cls server;
        string Query;

        public Kecamatan_cls() {
            _id_kecamatan = "";
            _nama_kecamatan = "";
            _id_kabupaten = "";
            
            server = new KoneksiDb_cls();
            Query = "";
        }

        public string ID_Kecamatan
        {
            set { _id_kecamatan = value;}
        }

        public string Nama_kecamatan
        {
            set { _nama_kecamatan= value;}
        }

        public string ID_Kabupaten 
        {
            set { _id_kabupaten = value;}
        }
        public bool isExist(string id)
        {
            bool cek = false;
            Query = $"select * from kecamatan where id_kecamatan='{id}'";

            if (server.EksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public int simpanData()
        {
            int hasil = 1;
            Query = $"insert into kecamatan values('{_id_kecamatan}', '{_nama_kecamatan}', '{_id_kabupaten}')";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }
            return hasil;
        }


        public int updateData()
        {
            int hasil = 1;

            Query = $"update kecamatan set nama_kecamatan ='{_nama_kecamatan}', id_kabupaten='{_id_kabupaten}' where id_kecamatan='{_id_kecamatan}'";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }
            return hasil;
        }


        public int hapusData()
        {
            int hasil = 1;
            Query = $"delete from kecamatan where id_kecamatan='{_id_kecamatan}'";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }

            return hasil;
        }

        public DataTable index()
        {
            Query = "select kc.*, kb.nama_kabupaten from kecamatan kc join kabupaten kb on kb.id_kabupaten=kc.id_kabupaten";

            return server.EksekusiQuery(Query);
        }
        public DataTable search(string nama)
        {

            Query = $"select kc.*, kb.nama_kabupaten from kecamatan kc join kabupaten kb on kb.id_kabupaten=kc.id_kabupaten where nama_kecamatan like '%{nama}%'";
            return server.EksekusiQuery(Query);
        }

    }
}
