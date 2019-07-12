using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Poll
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string Age { get; set; }
        public string Province { get; set; }
        public string Area { get; set; }
        public string TimeToParticipate { get; set; }
        public string TypeOfHelp { get; set; }
        public string University { get; set; }
        public string Profession { get; set; }

        public Poll()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
