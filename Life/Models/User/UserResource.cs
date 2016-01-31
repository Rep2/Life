using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class UserResource : Model
    {
        public int Id { get; set; }

        public double Amount { get; set; }

        public Resource Resource { get; set; }

        public User User { get; set; }

    }
}
