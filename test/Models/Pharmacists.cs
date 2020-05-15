using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Pharmacists
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Boolean IsEmailVerified { get; set; }
        public Guid ActivationCode { get; set; }
    }
}