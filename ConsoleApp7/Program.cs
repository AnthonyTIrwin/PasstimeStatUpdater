using System;

namespace PlayerManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call UI Class
            UIClass OnTeam = new UIClass();
            //converts .cvs file to list
            OnTeam.TeamRoster();
            //sorts players from specific team
            OnTeam.TmSearch();
            //shows player profile
            OnTeam.PlayerData();
            //able to change player data
            OnTeam.PlayerChanger();
            //shows updated list
            OnTeam.UpdatedList();
            //saves updated list to .csv file
            OnTeam.SaveIt();
            Console.ReadLine();         
        }
    }
}
