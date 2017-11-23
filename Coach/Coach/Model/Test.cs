using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coach.Model
{
    class Test : RealmObject
    {
        [Indexed]
        public int Id { get; set; }

        [Backlink(nameof(Coach.Model.Assignment.Test))]
        public IQueryable<Assignment> Assignment { get; }
    }
}
