using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from List data class");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List database");
        }
    }
}
