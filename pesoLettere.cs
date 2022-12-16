using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {
        int p = 0;
        input = input.ToLower();
        foreach (char n in input)
        {
           
            if (n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u' || n == 'l' || n == 'n' || n == 'r' || n == 's' || n == 't')
            {
                p += 1;
            }
            if(n == 'd' || n == 'g')
            {
               p += 2;
            }
            if(n == 'b' || n == 'c'||n == 'm' || n == 'p'){
               p += 3;
            }
            if(n == 'f' || n == 'h'||n == 'v' || n == 'w'||n == 'y' ){
               p += 4;
            }
            if(n == 'k' ){
               p += 5;
            }
            if(n == 'j' || n == 'x'){
               p += 8;
            }
            if(n == 'q' || n == 'z'){
               p += 10;
            }
        }
        return p;
    }
}