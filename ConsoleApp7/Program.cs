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
