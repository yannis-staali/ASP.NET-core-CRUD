using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebJoky.Models
{
    public class Joke
    {
        public long id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        public Joke()
        {

        }
    }
}
