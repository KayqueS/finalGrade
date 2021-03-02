using System;
using System.Collections.Generic;
using System.Text;

namespace finalGrade
{
    class FinalGrade
    {
        public string Name;
        public double Quarter1, Quarter2, Quarter3;

        public double Final()
        {
            return Quarter1 + Quarter2 + Quarter3;
        }

        public bool Approved()
        {
            if (Final() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double RemainingNote()
        {
            if (Approved())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - Final();
            }
        }
    }
}
