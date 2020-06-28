using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task3
{
    interface ICatalogUnity
    {
        string Name { get; set; }
        int Code { get; set; }
        string Category { get; set; }
        int Size { get; set; }
    }
}
