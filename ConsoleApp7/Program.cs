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
            OnTeam.PlayerData();
            OnTeam.PlayerChanger();
            OnTeam.UpdatedList();
          
            Console.ReadLine();

            using (var writer = new StreamWriter($"../../mlb_players.csv"))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(ListRoster);
            }
        }
    }
}
