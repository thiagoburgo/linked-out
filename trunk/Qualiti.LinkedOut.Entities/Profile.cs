using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qualiti.LinkedOut.Entities {
    public class Profile {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        
        public DateTime Birthday { get; set; }
        public String Language { get; set; }

        public List<UserHangLoose> HangLooses { get; set; }
    }
}
