using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreKurs_Berlin.Data
{
    public class Aufgaben
    {
        public int ID { get; set; }

        [MaxLength(20, ErrorMessage="maximal 20 Zeichen")]
        [MinLength(2, ErrorMessage ="mindesten 2 Zeichen")]
        public string Text { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        
        public DateTime DeadlineDatum { get; set; }

        public bool AufgabeFertig { get; set; }

    }
}
