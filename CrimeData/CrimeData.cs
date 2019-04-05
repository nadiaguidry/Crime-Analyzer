using System;
using System.Collections.Generic;
using System.IO;

namespace CrimeData
{
    class Crime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<crime_csv_file_path> <report_file_path>");
            try
            {
                crimeStatsList = CrimeStatsLoader(cvsDataFilePath);
                } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(1);
                }

            try
            {

            }   catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(3);
            }       
        }

        public class CrimeStats
        {
            public int Year;
            public int Population;
            public int ViolentCrime;
            public int Murder;
            public int Rape;
            public int Robbery;
            public int AggravatedAssault;
            public int PropertyCrime;
            public int Burglary;
            public int Theft;
            public int MotorVehicleTheft;

            public CrimeStats(int year, int population, int violentCrime, int murder, int rape, int robbery, 
                int aggravatedAssault, int propertyCrime, int burglary, int theft, int motorVehicleTheft);

            {

                Year = year;
                Population = population;
                ViolentCrime = violentCrime;
                Murder = murder;
                Rape = rape;
                Robbery = robbery;
                AggravatedAssault = aggravatedAssault;
                PropertyCrime = propertyCrime;
                Burglary = blurglary;
                Theft = theft;
                MotorVehicleTheft = motorVehicleTheft;


        }

    }
}

public class CrimeStatsReport
{
    var line = reader.ReadLine();
    var values = line.Split(',');

    $"Row {lineNumber} contains {values.Length} values. It should contain {NumItemsInRow}."
    var years = from crimeStats in crimeStatsList where crimeStats.Rape < 85000 select crimeStats.Year;
}
    foreach (var year in years)
{
    Console.WriteLine(year);
}



public class crimeAnalyzerReport
{
        Console.WriteLine("Period:\n");
        Console.WriteLine("Years murders per year < 1500:\n");
        Console.WriteLine("Robberies per year > 500000:\n");
        Console.WriteLine("Violent crime per capita rate (2010):\n");
        Console.WriteLine("Average murder per year (all years):\n");
        Console.WriteLine("Average murder per year (1994 - 1997):\n");
        Console.WriteLine("Average murder per year(2010 - 2014) :\n");
        Console.WriteLine("Minimum thefts per year(1999 - 2004):\n");
        Console.WriteLine("Maximum thefts per year (1999 - 2004):\n");
        Console.WriteLine("Year of highest number of motor vehicle thefts:\n");



}
