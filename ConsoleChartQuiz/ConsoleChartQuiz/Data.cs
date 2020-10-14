using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChartQuiz {
    class Data {
        public Data(string country, string timeOfDay, string animal, int attack) {
            Country = country;
            TimeOfDay = timeOfDay;
            Animal = animal;
            Attacks = attack;
        }

        public string Country { get; set; }
        public string TimeOfDay { get; set; }
        public string Animal { get; set; }
        public int Attacks { get; set; }
    }
}
