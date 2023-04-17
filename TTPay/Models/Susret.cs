using System.ComponentModel.DataAnnotations;

namespace TTPay.Models
{
    public class Susret
    {
        [Key]
        public int SusretId { get; set; }

        public DateTime Datum { get; set; }

        public double BojanPotrosio { get; set; }
        public double BojanPlatio { get; set; }

        public double ZecPotrosio { get; set; }
        public double ZecPlatio { get; set; }

        public double ManicPotrosio { get; set; }
        public double ManicPlatio { get; set; }
    }
}
