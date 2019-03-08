using System;
using System.Collections.Generic;

namespace planets
{
    class Program {
            static void Main(string[] args)
            {
                /*
                Not only do you have to say what type the variable is, you also
                have to instantiate that exact same type of object on assignment.
                This may seem redundant, but it's part of the C# language compiler's
                type checking constraints.
            */
            List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };


            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
            probes.Add(new Dictionary <string, string>() { {"Venus", "Mariner"} });
            probes.Add(new Dictionary <string, string>() { {"Venus", "Venera"} });
            probes.Add(new Dictionary <string, string>() { {"Mars", "Viking"} });
            probes.Add(new Dictionary <string, string>() { {"Mars", "Opportunity"} });
            probes.Add(new Dictionary <string, string>() { {"Mars", "Curiosity"} });


            foreach (string planet in planetList) // iterate planets

            {
                // Console.WriteLine($"Planet : {planet}");

                List<string> matchingProbes = new List<string>();

            foreach(Dictionary <string, string> probe in probes) // iterate probes
                {
                    /*
                        Does the current Dictionary contain the key of
                        the current planet? Investigate the ContainsKey()
                        method on a Dictionary.

                        If so, add the current spacecraft to `matchingProbes`.
                    */


                    if (probe.ContainsKey(planet)) {
                        matchingProbes.Add(probe[planet]);
                   }
                    // else {Console.WriteLine("");};
                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                // Console.WriteLine($"{}: {}");
            };
                        Console.WriteLine($"{planet}: {string.Join(", ", matchingProbes)}");


    }
}
}
}