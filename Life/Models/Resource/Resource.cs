using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class Resource : Model
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double InitialValue { get; set; }

    }
}
