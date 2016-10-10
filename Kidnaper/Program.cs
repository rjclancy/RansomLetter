using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Kidnaper
{
    class Program
    {
        static void Main()
        {
            const string note = "I want your money";
            const string paper = "Shortly before Christmas, people Iin Athlone needlessly paid hundredI want your moneys of euro iwantn parking fees because theyour y were not aware moneyof a ‘freeI want your monyer";
           
            //Time method execution
            //start stopwatch
            var watch = Stopwatch.StartNew();

            //execute method
            checkNote(note, paper);

            //stop stopwatch
            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("\t" + elapsedMs + ":ms\n");
            Console.ReadLine();
        }

        //check note method(Regular)
        private static void checkNote(string note, string paper)
        {           
            var noteList = new List<char>(note);
            var paperList = new List<char>(paper);
            var letterSuccess = 0;

            //note interation
            foreach (var i in noteList)
            {
                if (!paperList.Contains(i)) continue;

                //increment successfull letter found, reset paperChar letter
                letterSuccess++;
                paperList.Remove(i);
            }

            //check letters count
            if (letterSuccess == noteList.Count)
            {
                Console.WriteLine("Success!!! Enough letters to create : " + note + "!");
            }
            else
            {
                Console.WriteLine("Not enough letters to create : " + note + "!");
            }
        }
    }
}
