using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManager
{
    class UIClass
    {
        public List<RosterData> CvsList { get; set; }
        public string ABC { get; set; }
        //displays initials key for list
        public void TeamRoster()
        {
            Console.WriteLine("           Please enter team name using initials from following list.");
            Console.WriteLine("=================================================================================");
            Console.WriteLine("Baltimore Orieoles = BAL  Chicago White Sox    = CWS  California Angels     = ANA");
            Console.WriteLine("Boston Red Sox     = BOS  Cleveland Indians    = CLE  Oakland A's           = OAK");
            Console.WriteLine("New York Yankees   = NYY  Detroit Tigers       = DET  Seattle Mainers       = SEA");
            Console.WriteLine("Tampa Bay Rays     = TB   Kansas City Royals   = KC   Texas Rangers         = TEX");
            Console.WriteLine("Toronto Blue Jays  = TOR  Minnesota Twins      = MIN  Atlanta Braves        = ATL");
            Console.WriteLine("Chicago Cubs       = CHC  Arizona Diamondbacks = ARZ  Miami Marlins         = FLA");
            Console.WriteLine("Cincinnati Reds    = CIN  Colorado Rockies     = COL  New York Mets         = NYM");
            Console.WriteLine("Houstan Astros     = HOU  LA Dodgers           = LA   Philidephia Phillies  = PHI");
            Console.WriteLine("Millawakee Brewers = MLW  San Diego Padres     = SD   Washington Nationals  = WAS");
            Console.WriteLine("Pittsburg Pirates  = PIT  San Francisco Giants = SF   Saint Louis Cardinals = STL");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
        //Method for getting list of players from specific team
        public void TmSearch()
        {
            ListMaker listMaker = new ListMaker();
            listMaker.GenList();
            List<RosterData> TeamList = listMaker.ListRoster;
            Console.WriteLine("Enter Team Initials Here:");
            string xyz = Console.ReadLine();
            Console.WriteLine("__________________________");
            foreach (var item in TeamList)
            {
                if (xyz.ToLower() == item.Popcorn.ToLower())
                {
                    item.PrintName();
                }
            }
            CvsList = TeamList;
        }
        //Pull up all the data on a specific player
        public void PlayerData()
        {
            Console.WriteLine("_________________________");
            Console.WriteLine("Please Input Player Name:");
            string abc = Console.ReadLine();
            foreach (var thing in CvsList)
            {
                if (abc == thing.Name)
                {
                    thing.Print();
                }
            }
            ABC = abc;
        }
        //Change Data for specific player
        public void PlayerChanger()
        {
            Console.WriteLine("______________________");
            Console.WriteLine("What's the new team?");
            var NewTeam = Console.ReadLine();

            int index = CvsList.FindIndex(x => x.Name.Contains(ABC));
            CvsList[index].Popcorn = NewTeam;

            Console.WriteLine("Would you like to change player's weight? Y or N ");
            var AskWeight = Console.ReadLine();
            if (AskWeight.ToLower() == "y")
            {
                Console.WriteLine("What's {0}'s new weight?", ABC);
                var NewWeight = Console.ReadLine();
                CvsList[index].Weight = NewWeight;

            }

        }

        //calls list again so user can verify change
        public void UpdatedList()
        {
            foreach (var part in CvsList)
            {
                if (ABC.ToLower() == part.Name.ToLower())
                {
                    part.Print();
                }
            }
        }

        //saves modified list to .csv file
        public void SaveIt()
        {
            Console.WriteLine("Press enter to save it to file");
            using (var writer = new StreamWriter($"../../mlb_players.csv"))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(CvsList);
            }
        }
    }
}

    
         
 
