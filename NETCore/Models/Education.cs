using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NETCore.Models
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public string GPA { get; set; }
        [Required]
        public int UniversityId { get; set; }
        public virtual University Universities { get; set; }
        public virtual ICollection<Profiling> Profilings { get; set; }

        public Education(string degree, string gPA)
        {
            Degree = degree;
            GPA = gPA;
        }

        public Education(string degree, string gPA, int universityId) : this(degree, gPA)
        {
            UniversityId = universityId;
        }
    }
}
