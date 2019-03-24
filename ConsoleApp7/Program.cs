using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace PlayerManager
{
    class Program
    {
        static void Main(string[] args)
        {

            //calls on ListMaker to read .cvs file and makes it into a list
            ListMaker FirstList = new ListMaker();
            FirstList.GenList();
            List<RosterData> ListRoster = FirstList.ListRoster;



            //Call UI Class to get names of members on team

            UIClass OnTeam = new UIClass();
            OnTeam.TeamRoster();
            OnTeam.TmSearch();





            Console.WriteLine("Please input name of MLB Player:");
            var plnm = Console.ReadLine();
            int index = ListRoster.FindIndex(x => x.Name.Contains(plnm));
            Console.WriteLine("_______________________");
            Console.WriteLine("Player:   {0}", ListRoster[index].Name); 
            Console.WriteLine("Team:     {0}", ListRoster[index].Popcorn);
            Console.WriteLine("Position: {0}", ListRoster[index].Position);
            Console.WriteLine("Height:   {0}", ListRoster[index].Height);
            Console.WriteLine("Weight:   {0}", ListRoster[index].Weight);
            Console.WriteLine("Age:      {0}", ListRoster[index].Age);
            Console.WriteLine("_______________________");
            Console.WriteLine("Enter New Team for {0}", plnm);
            var item = Console.ReadLine();
            ListRoster[index].Popcorn = item;
            Console.WriteLine("Player:   {0}", ListRoster[index].Name);
            Console.WriteLine("Team:     {0}", ListRoster[index].Popcorn);
            Console.WriteLine("Position: {0}", ListRoster[index].Position);
            Console.WriteLine("Height:   {0}", ListRoster[index].Height);
            Console.WriteLine("Weight:   {0}", ListRoster[index].Weight);
            Console.WriteLine("Age:      {0}", ListRoster[index].Age);
            Console.WriteLine("_______________________");
            Console.WriteLine("Press Enter To Write To File");

            Console.ReadLine();

            using (var writer = new StreamWriter($"../../mlb_players.csv"))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(ListRoster);
            }
        }
    }
}
