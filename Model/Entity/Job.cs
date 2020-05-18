using PrinterTonerCheck.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterTonerCheck.Model.Entity
{
    public class Job
    {
        public JobType JobTipi { get; set; }
        public string MailAdresi { get; set; }
        public bool OtoMail { get; set; }
        public int Min { get; set; }
    }
}
