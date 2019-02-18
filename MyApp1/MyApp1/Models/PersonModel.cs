using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MyApp1.Models
{
    public class PersonModel
    {
        public virtual int Id { get; set; }

        public virtual string ProfilePicture { get; set; }

        public virtual string Firstname { get; set; }

        public virtual string Lastname { get; set; }

        public virtual string Username { get; set; }

        public virtual string Password { get; set; }

        public virtual string Email { get; set; }

        public virtual DateTime DateOfBirth { get; set; }

        public virtual string Gender { get; set; }
        public virtual bool Status { get; set; }
    }
}
