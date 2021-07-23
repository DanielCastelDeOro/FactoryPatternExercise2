using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    interface IDataAccess
    {
        public void LoadData();
        public void SaveData();
    }
}
