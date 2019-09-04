using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTOs
{
    public class PollDTO
    {
        public Poll NewPoll { get; set; }
        public IList<MultipleChoiceDto> MultipleChoiceHelps { get; set; }
        public IList<MultipleChoiceDto> MultipleChoiceParticipation { get; set; }
        public IList<string> SelectedHelps { get; set; }
        public IList<string> SelectedParticipation { get; set; }
        public PollDTO()
        {
            MultipleChoiceHelps = new List<MultipleChoiceDto>();
            SelectedHelps = new List<string>();
            MultipleChoiceParticipation = new List<MultipleChoiceDto>();
            SelectedParticipation = new List<string>();
        }
    }

    public class MultipleChoiceDto
    {
        public bool Selected { get; set; }
        public string Name { get; set; }
    }
}
