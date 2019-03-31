using System;
using System.Collections.Generic;

namespace SearchApi
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Streetaddress { get; set; }
        public string Suburb { get; set; }
        public string Dwellingtype { get; set; }
        public int? Dwellingnumber { get; set; }
        public string Xcoordinate { get; set; }
        public string Ycoordinate { get; set; }
        public string Location { get; set; }
    }
}
