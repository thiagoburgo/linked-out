using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qualiti.LinkedOut.Entities {
    public class Wall
    {
        private Profile owner;
        public Wall(Profile owner)
        {
            this.Owner = owner;
        }
        public List<Post> Posts { get; set; }
        public Profile Owner {
            get { return this.owner; }
            set {
                if (value != null) {
                    this.owner = value;
                } else {
                    throw new ArgumentNullException("Um mural deve ter um dono!");
                }
            }
        }
    }
}
