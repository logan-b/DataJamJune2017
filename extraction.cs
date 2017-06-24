using System.IO;



static void Main(string[] args)
{


    using(var fs = File.OpenRead(@"C:\test.csv"))
    using(var reader = new StreamReader(fs))
    {
      
        List<string> ID = new List<string>();
        List<string> Date = new List<string>();
        List<string> County = new List<string>();
        List<string> Outcome = new List<string>();
        List<string> Race = new List<string>();

        while (!reader.EndOfStream)
        {
          int idIndex = 0;
          int dateIndex = 2;
          int countyIndex = 5;
          int raceIndex = 12;
          int outcomeIndex = 20;
          int violationIndex = 15;


          var line = reader.ReadLine();
          string[] values = line.Split(',');

          if( values[countyIndex] == "Harris County" && values[violationIndex] == "Speeding")
          {
            ID.add()
          }
        }



            listA.Add(values[0]);
            listB.Add(values[1]);
        }
    }
}
