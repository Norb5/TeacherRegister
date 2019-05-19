﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherRegister.BLL
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Teacher Teacher { get; set; }
    }
}
