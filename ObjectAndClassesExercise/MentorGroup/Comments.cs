using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    public class Comments
    {
        public string Comment { get; set; }
        public string Name { get; set; }
        
        public Comments(string comment, string name)
        {
            Comment = comment;
            Name = name;
        }
    }
}
