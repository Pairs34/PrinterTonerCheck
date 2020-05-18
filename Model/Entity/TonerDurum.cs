using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterTonerCheck.Model.Entity
{
    class TonerDurum
    {
        public int CLevel { get; set; }
        public int MLevel { get; set; }
        public int YLevel { get; set; }
        public int KLevel { get; set; }

        public string CName { get; set; }
        public string MName { get; set; }
        public string YName { get; set; }
        public string KName { get; set; }

    }
}
