using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qualiti.LinkedOut.Entities {
    public class Album : Content {
        public Album(Profile owner) : base(owner)
        {
            
        }
        public List<Photo> Photos { get; set; }
        public String Name { get; set; }
        public String Description{ get; set; }
    }
}
