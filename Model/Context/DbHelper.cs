using PrinterTonerCheck.Model.Entity;
using System.Data.Entity;

namespace PrinterTonerCheck.Model.Context
{
    public enum PrinterTip
    {
        HP = 1,
        Canon = 2,
        KyoceraColor = 3,
        KyoceraBlack = 4
    }

    public enum JobType
    {
        Gunluk = 1,
        Haftalik = 2,
        Saatlik = 3,
        HerDakika = 4
    }
    class DbHelper : DbContext
    {
        public DbSet<Printer> PrinterToners { get; set; }
    }
}
