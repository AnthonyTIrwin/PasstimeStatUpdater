using System;

namespace PlayerManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call UI Class
            UIClass OnTeam = new UIClass();
            OnTeam.TeamRoster();
            OnTeam.TmSearch();
            OnTeam.PlayerData();
            OnTeam.PlayerChanger();
            OnTeam.UpdatedList();
            OnTeam.SaveIt();
            Console.ReadLine();         
        }
    }
}
