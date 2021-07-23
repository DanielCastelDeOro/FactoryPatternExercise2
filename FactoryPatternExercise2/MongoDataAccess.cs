using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            
            Console.WriteLine($"I am reading data from Mongo Data Class"); 
            //var product = new list<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("Im am saving data from a Mongo database");
        }
    }
}
