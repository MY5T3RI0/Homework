using System.Collections.Generic;

namespace MyDB
{
    class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<Song> Song { get; set; }

        public override string ToString()
        {
           return $"{Name} ({Year})";
        }
    }
}
