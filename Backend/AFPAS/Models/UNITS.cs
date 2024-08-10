using System.ComponentModel.DataAnnotations;

namespace AFPAS.Models
{
    public class UNITS
    {
        [Key]
        public int LOC_ID { get; set; }

        [StringLength(50)]
        public string LOC_NAME { get; set; }

      
        public int LOC_POINTS { get; set; }
    }

}
