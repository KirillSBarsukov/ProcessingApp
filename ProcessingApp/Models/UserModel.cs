﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessingApp.Models
{
    public class UserModel:IdentityUser
    {
        [Key]
        public virtual int UserId { get; set; }
        public virtual String Name { get; set; }
    }
}
