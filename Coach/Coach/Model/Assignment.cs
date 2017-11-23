using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coach.Model
{
    class Assignment : RealmObject
    {
        [Indexed]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public Person Employee { get; set; }
        public Test Test { get; set; }
        public DateTimeOffset DueDate { get; set; }

        public string StatusName
        {
            get
            {
                string Name;
                switch (StatusId)
                {
                    case 1:
                        Name = "Not Started";
                        break;
                    case 2:
                        Name = "In Progress";
                        break;
                    case 3:
                        Name = "Compliant";
                        break;
                    case 4:
                        Name = "Not Compliant";
                        break;
                    case 5:
                        Name = "Not Compliant Corrective Action Pending";
                        break;
                    case 6:
                        Name = "Not Compliant Corrective Action Complete";
                        break;
                    default:
                        Name = "";
                        break;
                }
                return Name;
            }
        }
    }
}
