using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlagiarismChecker.Models
{
    public class User
    {
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string email { get; set; }
        public string Password { get; set; }
    }
}
