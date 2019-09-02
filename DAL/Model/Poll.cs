using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Poll
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(200)]
        public string Cellphone { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        [MaxLength(200)]
        public string Area { get; set; }
        public string TimeToParticipate { get; set; }
        [MaxLength(200)]
        public string OtherTimeToParticipate { get; set; }
        [Required]
        public string TypeOfHelp { get; set; }
        [MaxLength(200)]
        public string OtherTypeOfHelp { get; set; }
        [MaxLength(200)]
        public string ProfessionInstitution { get; set; }
        [MaxLength(200)]
        public string Profession { get; set; }

        public Poll()
        {
            CreatedDate = DateTime.Now;
        }

        public string Name()
        {
            return FirstName + " " + LastName;
        }
    }
}
