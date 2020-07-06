using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task3
{
    class MusicFile:ICatalogUnity, IActionsForPlayableFiles
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }
        public int Size { get; set; }
        public string Director { get; private set; }
        public string MainActtress { get; private set; }
        public string MainActor { get; private set; }

        public void Play() { }
        public void RetrieveInformation() { }
    }
}
