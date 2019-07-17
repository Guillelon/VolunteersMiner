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
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Cellphone { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string Area { get; set; }
        public string TimeToParticipate { get; set; }
        public string OtherTimeToParticipate { get; set; }
        [Required]
        public string TypeOfHelp { get; set; }
        public string OtherTypeOfHelp { get; set; }
        public string ProfessionInstitution { get; set; }
        public string Profession { get; set; }

        public Poll()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
