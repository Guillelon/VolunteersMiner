using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PollRepository
    {
        private VolunteersMinerDBContext _context;

        public PollRepository()
        {
            _context = new VolunteersMinerDBContext();
        }

        public IList<Poll> GetAll()
        {
            return _context.Poll.ToList();
        }

        public Poll Add(Poll poll)
        {
            try
            {
                poll = _context.Poll.Add(poll);
                _context.SaveChanges();
                return poll;
            }
            catch
            {
                throw new Exception("Tenemos problemas en el servidor, estamos trabajando para eso.");
            }
        }
    }
}
