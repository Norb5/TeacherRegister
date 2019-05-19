using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeacherRegister.BLL
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public int UserType { get; set; }

        public Teacher Teacher { get; set; }
        [ForeignKey("Teacher")]
        public int? TeacherId { get; set; }


    }
}
