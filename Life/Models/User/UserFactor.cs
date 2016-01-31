using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class UserFactor : Model
    {
        public int Id { get; set; }

        public double Value { get; set; }

        public Factor Factor { get; set; }

        public User User { get; set; }

    }
}
