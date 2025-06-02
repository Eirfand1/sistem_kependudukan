using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sireduk.config
{
    abstract class Services_cls
    {
        // deklarasi abstarct method insert, update, delete
        public abstract int EksekusiBukanQuery(string query);
        // deklarasi abstarct untuk menganani select
        public abstract DataTable EksekusiQuery(string query);
    }
}
