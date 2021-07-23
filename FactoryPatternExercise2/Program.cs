using System;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What database do you want to use?\nYou can choose List, SQL, or Mongo" );
            var response = Console.ReadLine();

            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(response);
            dataAccess.LoadData();
            dataAccess.SaveData();
        }
    }
}
