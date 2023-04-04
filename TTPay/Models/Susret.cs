using System.ComponentModel.DataAnnotations;

namespace TTPay.Models
{
    public class Susret
    {
        [Key]
        public int SusretId { get; set; }

        public DateTime Datum { get; set; }

        public int BojanPotrosio { get; set; }
        public int BojanPlatio { get; set; }

        public int ZecPotrosio { get; set; }
        public int ZecPlatio { get; set; }

        public int ManicPotrosio { get; set; }
        public int ManicPlatio { get; set; }
    }
}
