using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from SQL data class");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL database");
        }
    }
}
