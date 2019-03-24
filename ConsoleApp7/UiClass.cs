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



        public void TeamRoster()
        {


            Console.WriteLine("Please enter team name using initials from following list.");
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
            //makes new list object of .csv file
            ListMaker listMaker = new ListMaker();
            listMaker.GenList();
            List<RosterData> TeamList = listMaker.ListRoster;

            Console.WriteLine("put in team initials:");
                
               Console.ReadLine();
            //string xyz = Console.ReadLine();

            //int index = TeamList.FindIndex(x => x.Popcorn.Contains(xyz));

            //Console.WriteLine("This is {0}", TeamList[index].Name);
          
            foreach (var item in TeamList)
            {
                
                

                    Console.WriteLine(item.Popcorn);

                
              


            }




        }


        public void xyz()
        {

            



        }




    }
}

    
         
 