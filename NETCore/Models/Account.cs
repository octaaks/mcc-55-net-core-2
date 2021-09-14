using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCore.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key] [Required]
        public string NIK { get; set; }
        [Required]
        public string Password { get; set; }

        [JsonIgnore]
        public virtual Person Person { get; set; }

        //[JsonIgnore]
        public virtual Profiling Profiling { get; set; }

        public Account(string nIK, string password)
        {
            NIK = nIK;
            Password = password;
        }
        public virtual ICollection<AccountRole> AccountRoles { get; set; }
    }
}
