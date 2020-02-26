using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVCSample.Models
{
    public class Kurs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Beginn { get; set; }
        public DateTime Ende { get; set; }
    }
}
