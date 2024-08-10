using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFPAS.Models
{
    public class PERSONNEL
    {
        public int PERSONNEL_ID { get; set; }

        public int FORCE_NO { get; set; }

        public string RANK { get; set; }

        public string NAME { get; set; }

        public string ADDRESS { get; set; }

        [MinLength(10), MaxLength(10)]
        public string MOBILE_NO { get; set; }

        public DateOnly DOB { get; set; }

        public DateOnly DOJ_PRESENT_UNIT { get; set; }

        [ForeignKey("UNITS.LOC_ID")]
        public int PRESENT_UNIT { get; set; }
    }
}
