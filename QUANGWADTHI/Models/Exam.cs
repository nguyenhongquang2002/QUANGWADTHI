using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QUANGWADTHI.Models
{
    public class Exam
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please choose the exam. ")]
        public string ExamSubject { get; set; }
        [Required(ErrorMessage = "Please choose the start time of the exam. ")]
        public string StartTime { get; set; }
        [Required(ErrorMessage = "Please enter the test date  ")]
        public DateTime ExamDate { get; set; }
        [Required(ErrorMessage = "Please choose the test time  ")]
        public string ExamDuration { get; set; }
        [Required(ErrorMessage = "Please select the exam room  ")]
        public string Classroom { get; set; }
        [Required(ErrorMessage = "Please choose the faculty  ")]
        public string Faculty { get; set; }
        public string Status { get; set; }
    }
}