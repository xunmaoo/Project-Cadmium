﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCadmium.Model.DomainClass
{
    public class UserVersion : BaseEntity
    {
        public Guid Version { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }

        public Guid UserID { get; set; }
        public virtual User User { get; set; }
    }
}