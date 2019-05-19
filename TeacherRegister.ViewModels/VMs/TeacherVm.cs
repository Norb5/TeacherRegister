using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherRegister.ViewModels.VMs
{
    public class TeacherVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        

    }
}
