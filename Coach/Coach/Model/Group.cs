using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coach.Model
{
    class Group : RealmObject
    {
        [Indexed]
        public int Id { get; set; }

        public string Type { get; set; }
        public string Name { get; set; }
    }
}
