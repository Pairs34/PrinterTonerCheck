using PrinterTonerCheck.Model.Context;
using System;
using System.ComponentModel.DataAnnotations;

namespace PrinterTonerCheck.Model
{
    class Printer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int SnmpVersion { get; set; }
        public PrinterTip Tip { get; set; }
        public string Ip { get; set; }
        public DateTime? LastRun { get; set; }
        public DateTime? NextRun { get; set; }
        public int? CLevel { get; set; }
        public int? MLevel { get; set; }
        public int? YLevel { get; set; }
        public int? KLevel { get; set; }
        public string CName { get; set; }
        public string MName { get; set; }
        public string YName { get; set; }
        public string KName { get; set; }
        public bool MailNeed { get; set; }
    }
}
