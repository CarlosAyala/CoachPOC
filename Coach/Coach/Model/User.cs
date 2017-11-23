using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coach.Model
{
    class User : RealmObject
    {
        [Indexed]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public IList<Group> Groups { get; }
    }
}
