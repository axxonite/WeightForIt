using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WeightForIt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Instance = this;
            Username = "Ashley";
            Exercises = new List<ExerciseDetails>();
        }

        public string Username;

        public static App Instance { get; private set; }

        public List<ExerciseDetails> Exercises;
    }

    public class ExerciseDetails

    {
        public string ExerciseType;
        public int TotalSets;
        public float Weight;
        public bool BarIncluded;
        public List<WeightTypeAndCount> PlateConfiguration;

    }

    public class WeightTypeAndCount
    {
        public int NumberOfPlates;
        public float WeightOfPlate;

    }

}
