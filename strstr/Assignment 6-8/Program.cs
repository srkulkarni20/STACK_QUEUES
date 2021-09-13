/*Your task  is to implement the function strstr. 
 The function takes two strings as arguments(s,x) and  locates the occurrence of the string x in the string s. The function returns and integer denoting  the first occurrence of the string x
 */

using System;
using System.Globalization;

namespace Assignment_6_8
{
    class Program
    {
       



        static public int  strstr(string text,string pattern)
        {
            int[] lps = new int[pattern.Length];

            construct_lps(pattern, lps);

            int text_len = text.Length, i = 0,j=0;
            int pat_len = pattern.Length;
            while(i<text.Length)
            {
                if(pattern[j]==text[i])
                {
                    i++;
                    j++;

                }

                if(j==pat_len)
                {
                    return (i - j);
                }

                else if(i<text_len && pattern[j]!= text[i])
                {

                    if (j!= 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i = i + 1;
                    }

                }
            }

            return -1;

        }
        static public void construct_lps(string pat,int[] lps)
        {
            int len = pat.Length;


            int j = 0, i = 0;
            lps[i] = 0;
            i = i + 1;


            while (i<len)
            {
               if(pat[i]==pat[j])
                {
                    lps[i] = j + 1;
                    j++;
                    i++;
                }
                else
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                        
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }

                }

            }

            for(int k=0;k<lps.Length;k++)
            {
                Console.Write(" " + lps[k]);
            }



        }
        
        
        static void Main(string[] args)
        {
            int i= strstr("acbacxacbacy", "acbacy");
            Console.WriteLine(i);
        }
    }
}
