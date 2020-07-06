using System;
using System.Collections.Generic;
using System.Text;

namespace AssamblyOne
{
    public class Motorcycle
    {
        public string _vinNumberPublic = "";
        internal string _vinNumberInternal = "";
        protected string _vinNumberProtected = "";
        protected internal string _vinNumberProtectedInternal = "";
        string _vinNumberPrivate = "vin number";
        private protected string _vinNumberPrivateProtected = "";

        public void StartEnginePublic()
        {
            Console.WriteLine("Engine has started");
        }

        internal void StartEngineInternal()
        {
            Console.WriteLine("Engine has started");
        }

        protected void StartEngineProtected()
        {
            Console.WriteLine("Engine has started");
        }

        protected internal void StartEngineProtectedInternal()
        {
            Console.WriteLine("Engine has started");
        }

        void StartEnginePrivate()
        {
            Console.WriteLine("Engine has started");
        }

        private protected void StartEnginePrivateProtected()
        {
            Console.WriteLine("Engine has started");
        }
    }
}
