using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeacherRegister.BLL
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Subject Subject { get; set; }
    }
}
