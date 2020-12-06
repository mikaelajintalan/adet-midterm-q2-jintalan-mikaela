using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace adet_midterm_q2_jintalan_mikaela.Models
{
    public class AdetPortal
    {
        private double pcg;//prelimComputedGrades
        private double mcg; //midtermComputedGrades
        private double pfcg; //pre-FinalsComputedGrades
        private double fcg; //finalsComputedGrades

        [Key]
        public int Id { get; set; }
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }

        //Details of Adet Students
        public double PQ1 { get; set; } //PrelimQuiz1
         public double PQ2 { get; set; } //PrelimQuiz2
         public double PQ3 { get; set; } //PrelimQuiz3
         public double PA1 { get; set; } //PrelimAss1
         public double PA2 { get; set; } //PrelimAss2
         public double PA3 { get; set; } //PrelimAss3
        public double PCG //PrelimComputedGrades
        {
            get { return pcg; }
            set { pcg = (PQ1 + PQ2 + PQ3 + PA1 + PA2 + PA3) / 6; }
        }
        public double MQ1 { get; set; } //MidtermQuiz1
         public double MQ2 { get; set; } //MidtermQuiz2
         public double MQ3 { get; set; } //MidtermQuiz3
         public double MA1 { get; set; } //MidtermAss1
         public double MA2 { get; set; } //MidtermAss2
         public double MA3 { get; set; } //MidtermAss3
        public double MCG //MidtermComputedGrades
        {
            get { return mcg; }
            set { mcg = (MQ1 + MQ2 + MQ3 + MA1 + MA2 + MA3) / 6; }
        }
        public double PFQ1 { get; set; } //PreFinalsQuiz1
         public double PFQ2 { get; set; } //PreFinalsQuiz2
         public double PFQ3 { get; set; } //PreFinalsQuiz3
         public double PFA1 { get; set; } //PreFinalsAss1
         public double PFA2 { get; set; } //PreFinalsAss2
         public double PFA3 { get; set; } //PreFinalsAss3
        public double PFCG //Pre-FinalsComputedGrades
        {
            get { return pfcg; }
            set { pfcg = (PFQ1 + PFQ2 + PFQ3 + PFA1 + PFA2 + PFA3) / 6; }
        }                                 
        public double FQ1 { get; set; } //FinalsQuiz1
         public double FQ2 { get; set; } //FinalsQuiz2
         public double FQ3 { get; set; } //FinalsQuiz3
         public double FA1 { get; set; } //FinalsAss1
         public double FA2 { get; set; } //FinalsAss2
         public double FA3 { get; set; } //FinalsAss3
        public double FCG ///FinalsComputedGradeS
        {
            get { return fcg; }
            set { fcg = (FQ1 + FQ2 + FQ3 + FA1 + FA2 + FA3) / 6; }
        }
        
}
}
