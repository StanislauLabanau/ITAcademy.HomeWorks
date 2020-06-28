using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task3
{
    class MovieFile:ICatalogUnity, IActionsForPlayableFiles
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }
        public int Size { get; set; }
        public string Singer { get; private set; }
        public int Length { get; private set; }

        public void Play() { }
        public void RetrieveInformation() { }

    }
}
