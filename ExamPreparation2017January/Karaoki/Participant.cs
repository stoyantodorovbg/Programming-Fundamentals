using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoki
{
   public class Participant
    {
        public string Name { get; set; }
        public string Song { get; set; }
        public string Award { get; set; }

        public Participant(string name, string song, string award)
        {
            Name = name;
            Song = song;
            Award = award;
        }

    }
}
