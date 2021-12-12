using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }    
        public ICollection<Enrollment> Entrollments { get; set; }


    }
}
