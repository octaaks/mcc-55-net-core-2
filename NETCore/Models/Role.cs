using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCore.Models
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        [Required]
        public int RoleId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AccountRole> AccountRoles { get; set; }
    }
}
