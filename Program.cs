using System;
using System.Collections.Generic;

namespace CSh_Lab_7
{
    
    class Program
    { 
        static void Main(string[] args)
        {
            //1
            Person Men = new Person("Ainur", "Beluaev", new DateTime(2002, 6, 7));
            Console.WriteLine(Men.Name);
            Console.WriteLine(Men.ToString());
            Console.WriteLine(Men.ToShortString());
            //2
            ResearchTeam RT = new ResearchTeam("Book1", "Org1", 13, TimeFrame.Long);
            Console.WriteLine(RT.ToShortString());
            Console.WriteLine(TimeFrame.Year + " " + TimeFrame.TwoYears + " " + TimeFrame.Long);    
            RT.AddPepers(new List<Paper>() { new Paper("B2", Men, new DateTime(1997, 7, 7)) });
            Console.WriteLine(RT.ToString());
            Console.WriteLine(RT.LastPublication);
        }
    }
}