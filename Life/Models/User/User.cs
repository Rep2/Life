using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class User : Model
    {

        public int Id { get; set; }

        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateTime ResourcesUpdatedAt { get; set; }


        public IList<UserResource> UserResources { get; set; }

        public IList<UserFactor> UserFactors { get; set; }

        public IList<Planet> Planets { get; set; }
    }
}
