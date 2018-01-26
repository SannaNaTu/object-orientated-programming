using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPrice2
{
    class YesNo
    {
        private static bool YesNou (string yesnocheck)
        {
            while (true)
            {
                Console.Write("{0} Y/N : ", yesnocheck);
                char c = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if(c == 'Y')
                {
                    return true;
                }
                if (c =='N')
                {
                    return false;
                }
                Console.WriteLine("Vastaa Y (Kyllä) tai N (Ei)");
            }
        }
    }
}
