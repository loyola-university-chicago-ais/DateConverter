using System;


namespace DateConverter
{
    class Program
    {


        static void Main(string[] args)
        {

            EpochTimeConverter dtConverter = new EpochTimeConverter();
            DateTime convertedEpochTime = new DateTime();
            DateTime DateToBeConverted = new DateTime(2020, 6, 10, 15, 24, 16);
            long convertedDateTime = new long(); 

            convertedEpochTime = dtConverter.EpochToDateTime(1611795435000);
            convertedDateTime = dtConverter.DateTimeToEpoch(DateToBeConverted);


            Console.WriteLine(convertedEpochTime);
            Console.WriteLine(convertedDateTime);
        }
    }
}
