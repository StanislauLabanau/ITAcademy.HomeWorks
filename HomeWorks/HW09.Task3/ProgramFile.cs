using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task3
{
    class ProgramFile:ICatalogUnity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }
        public int Size { get; set; }
    }
}
