using System;
namespace Qualiti.LinkedOut.Entities {
    public class User {
        public String Login { get; set; }
        public String Password { get; set; }
        public Profile Profile { get; set; }
        public String Email { get; set; }
    }
}
