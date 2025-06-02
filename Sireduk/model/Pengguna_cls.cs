using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sireduk.config;

namespace Sireduk.model
{
    class Pengguna_cls
    {
        private string _user_id, _password, _nama_pengguna;
        KoneksiDb_cls server;
        string Query;

        public Pengguna_cls()
        {
            _user_id = "";
            _password = "";
            _nama_pengguna = "";

            server = new KoneksiDb_cls();
            Query = "";
        }

        public bool login(string id, string password)
        {
            bool cek = false;
            Query = $"select * from pengguna where user_id='{id}' and password = '{password}'";

            if (server.EksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }
    }
}
