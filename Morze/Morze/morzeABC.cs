using System;
using System.Collections.Generic;
using System.Text;

namespace Morze
{
    class morzeABC
    {
        // Konstruktorban kapnak csak értéket
        public char Betu { get; }
        public string Kod { get; }

        public morzeABC(char b, string k)
        {
            Betu = b;
            Kod = k;
        }
    }
}
