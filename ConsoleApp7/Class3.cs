using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Class3
    {



        List<RosterData> ListRoster = new List<RosterData>();

        public void Charlie()
        {

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
        }
    }
}