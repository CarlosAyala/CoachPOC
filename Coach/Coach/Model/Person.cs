using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coach.Model
{
    class Person : RealmObject
    {
        [Indexed]
        public int Id { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IList<Group> Groups { get; }

        [Backlink(nameof(Assignment.Employee))]
        public IQueryable<Assignment> Assignments { get; }

        public IQueryable<Assignment> AssignmentsDue{
            get
            {
                return Assignments.Where(p => p.DueDate.DateTime <= DateTime.Now);
            }
        }
    }
}
