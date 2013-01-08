using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qualiti.LinkedOut.Entities {
    public class Post : Content {
        public Post(Profile owner)
            : base(owner)
        {
            
        }
        public String Text { get; set; }
    }
}
