using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NETCore.ViewModel
{
    public class PersonVM
    {
        [Key]
        public string NIK{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        //public enum Gender
        //{
        //    Male,
        //    Female
        //}
        //[JsonConverter(typeof(StringEnumConverter))]
        //public Gender gender { get; set; }
        public string Password { internal get; set; }
        public string Degree { get; set; }
        public string GPA { get; set; }
        public string Token { get; set; }
        public int UniversityId { get; set; }
    }
}
