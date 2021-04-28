using System;
using System.Collections.Generic;
using System.Text;

namespace NFL
{
    class University
    {
        public string name;
        public Jatekos[] players;

        public University()
        {

        }

        public University(string uniName)
        {
            this.name = uniName;
        }
        public bool isItATopUniversity()
        {
            if (players.Length > 1)
                return true;
            
            else
                return false;
        }
    }
}
