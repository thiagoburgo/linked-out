using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qualiti.LinkedOut.Entities {
    public class Comment : Content{
        public Comment(Profile owner)
            : base(owner)
        {
            
        }
    }
}
