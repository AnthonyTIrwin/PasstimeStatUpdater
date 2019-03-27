using CsvHelper;
using System.Collections.Generic;
using System.IO;

namespace PlayerManager
{
    class ListMaker
    {
        public List<RosterData> ListRoster { get; set; }
        public void GenList()
        {
            //uses Csvhelper to convert .csv to the LisRoster list
            List<RosterData> listRoster = new List<RosterData>();
            using (TextReader reader = File.OpenText(path: $"../../mlb_players.csv"))
            {
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    RosterData Record = csv.GetRecord<RosterData>();
                    listRoster.Add(Record);
                }
                ListRoster = listRoster;
            }
        }
    }
}