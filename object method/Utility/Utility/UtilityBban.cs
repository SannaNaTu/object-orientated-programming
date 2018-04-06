using System;
using System.Collections.Generic;
using System.Text;

namespace DigiTrade.Utility
{
    class UtilityBBAN
       
    {
        /// <summary>
        /// Change account to machineformat
        /// </summary>
        /// <param name="accauntNumber"></param>
        /// <returns>machineformat account</returns>
       
        public static string CorrectNumber(string accauntNumber)
        {
            accauntNumber = accauntNumber.Replace("-","").Replace(" ",""); // Poistaa väliviivan ( voi lyhentää myös ) .Trim();
                                                                           //           accauntNumber = accauntNumber.Trim();
                                                                           // Poistaa välilyönnit
            int positionOfZeros = 0; // = 6; voi esim. laittaa oletuksen paikalleen
            if (accauntNumber[0] == '1' || accauntNumber[0] == '2' ||  accauntNumber[0] == '6' || accauntNumber[0] == '8') //Substring(0,1));
                positionOfZeros = 6;
            else if (accauntNumber[0] == '3')
            {
                if (accauntNumber[1] == '0' || accauntNumber[1] == '2' || accauntNumber[1] == '5')
                    return " Account incorrect Format!";
                positionOfZeros = 6;
            }
            else if (accauntNumber[0] =='4' || accauntNumber[0]=='5' )
                positionOfZeros = 7;
            else
            {
                return "Account unknown format!";
            }
            for(int i=accauntNumber.Length; i < 14; i++) //accountNumber.Lenght lähtee lisäämään nollia oikeasta kohdasta
            {
                accauntNumber = accauntNumber.Insert(positionOfZeros, "0"); // Insertillä saadaan lisättyä tavaraa
            }
            //Voi tehdä myös while:llä
            //while ( accauntNumber.Length < 14)
            //{
            //    accauntNumber = accauntNumber.Insert(positionOfZeros, "0");
            //}

            return accauntNumber;
        }
        public static bool IsValidAccount(string machineFormatAccount)// Tarkistaa tilinumeron oikeellisuuden
        {
            int checkNumber = int.Parse(machineFormatAccount[machineFormatAccount.Length-1].ToString());
            machineFormatAccount = machineFormatAccount.Remove(machineFormatAccount.Length-1, 1); // poistetaan tarkistenumero!

            //string multiplex = "2121212121212"; MALLI MITEN VOI ESIM TEHDÄ KANSSA
            int[] multiplex = new int[2] { 2, 1 };
            int m = 0;
            for (int i = 0; i < machineFormatAccount.Length; i++) // Laskenta tilinumeron oikeellisuudesta
            {
                //int xxx = machineFormatAccount[i] * multiplex[i]; LIITTYY TUOHON YLEMPÄÄN MALLIIN!
                int n = int.Parse(machineFormatAccount[i].ToString()) * multiplex[i%2]; // i lukee nyt vasemmalta oikealle, jos halutaan lukea oikealta vasemmalta machineFormatAccount.Lenght-1
                                                                                        // Yllä int.Parse ja ToString:gillä muutettu intille luettavaan muotoon
                if (n >= 10) // Jos yli 10 nro ->

                    m += n / 10 + (n - 10); // Tässä tehdään numeroiden erotus esim. 16 on 1 ja 6 
                else
                    m += n; // muuten vain nro
            }
            int calculatedCheckNumber = ((m / 10 + 1) * 10) -m;

            return checkNumber == calculatedCheckNumber; // Tämä palauttaa true tai falsen
            //if (checkNumber == calculatedCheckNumber)
            //    return true;
            //else {
            //   return false;

            //}
        }
           

    }
}
