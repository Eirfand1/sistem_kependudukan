using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sireduk.config;

namespace Sireduk.model
{
    class Kabupaten_cls
    {
        private string _id_kabupaten, _nama_kabupaten;
        KoneksiDb_cls server;
        string Query;
        public Kabupaten_cls()
        {
            _id_kabupaten = "";
            _nama_kabupaten = "";

            server = new KoneksiDb_cls();
            Query = "";
        }

        public string ID_Kabupaten
        {
            set { _id_kabupaten = value;}
        }

        public string Nama_Kabupaten
        {
            set { _nama_kabupaten= value;}
        }


        public bool isExist(string id)
        {
            bool cek = false;
            Query = $"select * from kabupaten where id_kabupaten='{id}'";

            if (server.EksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public int simpanData()
        {
            int hasil = 1;
            Query = $"insert into kabupaten values('{_id_kabupaten}', '{_nama_kabupaten}')";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }
            return hasil;
        }

        public int updateData()
        {
            int hasil = 1;

            Query = $"update kabupaten set nama_kabupaten ='{_nama_kabupaten}' where id_kabupaten='{_id_kabupaten}'";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }
            return hasil;
        }


        public int hapusData()
        {
            int hasil = 1;
            Query = $"delete from kabupaten where id_kabupaten='{_id_kabupaten}'";

            if (!(server.EksekusiBukanQuery(Query) > 0))
            {
                hasil = -1;
            }

            return hasil;
        }

        public DataTable index()
        {
            Query = "select * from kabupaten";

            return server.EksekusiQuery(Query);
        }
        public DataTable search(string nama)
        {
            Query = $"select * from kabupaten where nama_kabupaten like '%{nama}%'";

            return server.EksekusiQuery(Query);
        }
    }
}
