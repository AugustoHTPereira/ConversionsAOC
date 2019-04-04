using System;
using System.Linq;

namespace WFConversoes
{
    public static class Converter
    {
        public static string ParaBase2(int Decimal)
        {
            if (Decimal.Equals(1) || Decimal.Equals(0))
                return Decimal.ToString();

            int a;
            string Binario = string.Empty;

            while (!Decimal.Equals(0))
            {
                a = (Decimal % 2);
                Binario = a + Binario;
                Decimal = Decimal / 2;
            }

            return Binario;
        }

        public static string ParaBase10(string Binario)
        {
            char[] VetBin = Binario.ToArray();
            int Expoente = Binario.Length - 1;
            int i = 0;
            long Decimal = 0;
            while(Expoente >= 0)
            {
                int.TryParse(VetBin[i].ToString(), out int Element);
                Decimal += (Element * (long)(Math.Pow(2, Expoente)));
                i++;
                Expoente--;
            }
            return Decimal.ToString();
        }

        public static string ParaBase8(int Decimal)
        {
            if (Decimal.Equals(1) || Decimal.Equals(0))
                return Decimal.ToString();

            int a;
            string Octal = string.Empty;

            while (!Decimal.Equals(0))
            {
                a = (Decimal % 8);
                Octal = a + Octal;
                Decimal = Decimal / 8;
            }

            return Octal;
        }

        public static string ParaBase5(int Decimal)
        {
            if (Decimal.Equals(1) || Decimal.Equals(0))
                return Decimal.ToString();

            int a;
            string Base5 = string.Empty;

            while (!Decimal.Equals(0))
            {
                a = (Decimal % 5);
                Base5 = a + Base5;
                Decimal = Decimal / 5;
            }

            return Base5;
        }

        public static string ParaBase16(int Decimal)
        {
            string Hexadecimal = string.Empty;

            Hexadecimal = String.Format("{0:x}", Decimal);

            return Hexadecimal.ToUpper();
        }

        public static string OctalParaBase10(string Octal)
        {
            char[] VetBin = Octal.ToArray();
            int Expoente = Octal.Length - 1;
            int i = 0;
            long Decimal = 0;
            while (Expoente >= 0)
            {
                int.TryParse(VetBin[i].ToString(), out int Element);
                Decimal += (Element * (long)(Math.Pow(8, Expoente)));
                i++;
                Expoente--;
            }
            return Decimal.ToString();
        }

        public static string Base5ParaBase10(string Base5)
        {
            char[] VetBin = Base5.ToArray();
            int Expoente = Base5.Length - 1;
            int i = 0;
            long Decimal = 0;
            while (Expoente >= 0)
            {
                int.TryParse(VetBin[i].ToString(), out int Element);
                Decimal += (Element * (long)(Math.Pow(5, Expoente)));
                i++;
                Expoente--;
            }
            return Decimal.ToString();
        }

        public static string Base16ParaBase10(string Hexadecimal)
        {
            return 
                int.Parse(Hexadecimal, System.Globalization.NumberStyles.HexNumber).ToString();
        }

        public static bool IsBinary(string Binary)
        {
            if (Binary.Contains("2") || Binary.Contains("3") || Binary.Contains("4") || Binary.Contains("5") || Binary.Contains("6") || Binary.Contains("7") || Binary.Contains("8") || Binary.Contains("9") ||
                !long.TryParse(Binary, out long Result))
                return false;
            else return true;
        }
    }
}