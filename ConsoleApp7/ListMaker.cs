using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManager
{
    class ListMaker
    {

        public List<RosterData> ListRoster { get; set; }


        static void GenList()
        {

            List<RosterData> listRoster = new List<RosterData>();
            using (TextReader reader = File.OpenText($"../../mlb_players.csv"))
            {
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())

                {


                    RosterData Record = csv.GetRecord<RosterData>();
                    listRoster.Add(Record);

                    var ListRoster = listRoster;




                }

            }

        }
    }
}