using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace trylangsamidtermquiz2.Models
{
    public class AdetPortal
    {
        [Key]
        public int Id { get; set; }
        public int StudentNumber { get; set; }
        public string StudentName { get; set; }

        //Details
        public double Quiz1 { get; set; }
        public double Quiz2 { get; set; }
        public double Quiz3 { get; set; }
        public double Ass1 { get; set; }
        public double Ass2 { get; set; }
        public double Ass3 { get; set; }
        
        //public double ComputedGrades { get; set; }
    }
}
