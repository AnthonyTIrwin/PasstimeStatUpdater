using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<RosterData> ListRoster = new List<RosterData>();
            using (TextReader reader = File.OpenText(@"C:\\temp\mlb_players.csv"))
            {
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())

                {

                    // does this go into a {get;set;} property?  
                    RosterData Record = csv.GetRecord<RosterData>();
                    ListRoster.Add(Record);



                }                

            }
            Console.WriteLine("Please input name of MLB Player:");
            var plnm = Console.ReadLine();
            int index = ListRoster.FindIndex(x => x.Name.Contains(plnm));
            Console.WriteLine("Player:   {0}", ListRoster[index].Name); 
            Console.WriteLine("Team:     {0}", ListRoster[index].Popcorn);
            Console.WriteLine("Position: {0}", ListRoster[index].Position);
            Console.WriteLine("Height:   {0}", ListRoster[index].Height);
            Console.WriteLine("Weight:   {0}", ListRoster[index].Weight);
            Console.WriteLine("Age:      {0}", ListRoster[index].Age);
            Console.WriteLine("Enter New Team");
            var item = Console.ReadLine();
            ListRoster[index].Popcorn = item;
            Console.WriteLine("Player:   {0}", ListRoster[index].Name);
            Console.WriteLine("Team:     {0}", ListRoster[index].Popcorn);
            Console.WriteLine("Position: {0}", ListRoster[index].Position);
            Console.WriteLine("Height:   {0}", ListRoster[index].Height);
            Console.WriteLine("Weight:   {0}", ListRoster[index].Weight);
            Console.WriteLine("Age:      {0}", ListRoster[index].Age);
            Console.ReadLine();

            using (var writer = new StreamWriter(@"c:\temp\csvThing.csv"))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(ListRoster);
            }
        }
    }
}
