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
            const string paper = "Management at Tallaght Hospital say they plan to increase staffing levels at the facility in an effort to deal with overcrowding.51 mins agoPSNI arrest three amid chaos at Hardwell gig in BelfastPSNI chief inspector Mark McEwan has said a small quantity of suspected drugs was seized outside the Odyssey Arena in the wake of a major incident that saw 17 teenagers taken to hospital.1 hour, 10 mins ago";

            //start stopwatch
            var watch = Stopwatch.StartNew();

            //execute method
            CheckNote(note, paper);

            //stop stopwatch
            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("\t" + elapsedMs + ":ms\n");
            Console.ReadLine();
        }

        //check note method(Regular)
        private static void CheckNote(string note, string paper)
        {
            var noteSet = new HashSet<char>(note);
            var paperSet = new HashSet<char>(paper);
            var letterSuccess = 0;
            var flag = true;

            //note interation
            for (var i = 0; i < noteSet.Count; i++)
            {
                do
                {                   
                    if (!paperSet.Contains(noteSet.ElementAt(i))) continue;

                    //increment successfull letter found, then remove letter from paperSet
                    letterSuccess++;
                    paperSet.Remove(noteSet.ElementAt(i));
                    flag = false;
                } while (flag);
            }

            //check letters count
            if (letterSuccess == noteSet.Count)
            {
                Console.WriteLine("Success! Enough letters to create : " + note + "!");
            }
            else
            {
                Console.WriteLine("Not enough letters!" + note + "!");
            }           
        }
    }
}

