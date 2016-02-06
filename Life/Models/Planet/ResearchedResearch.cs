using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class ResearchedResearch
    {

        public int Id { get; set; }

        public User User { get; set; }

        public ResearchLevel ResearchLevel { get; set; }

    }
}
