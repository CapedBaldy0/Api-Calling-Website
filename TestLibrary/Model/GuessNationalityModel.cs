using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Model
{
    internal class GuessNationalityModel
    {
        public List<Country> Country { get; set; }
    }

    internal class Country
    {
        public string Country_id { get; set; }
        public decimal Probability { get; set; }
    }
}
