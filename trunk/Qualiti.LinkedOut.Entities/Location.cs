using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qualiti.LinkedOut.Entities {
    public class Location {
        public String Country { get; set; }
        public String City { get; set; }
        public Coordinate Coordinate { get; set; }
    }

    public struct Coordinate
    {
        public String Latitude { get; set; }
        public String Longitude { get; set; }
    }
}
