using System;
using System.Collections.Generic;

namespace Cseresznye_OACMUT_API.Models
{
    public partial class Person
    {
        public Person()
        {
            Nutritions = new HashSet<Nutrition>();
            Workouts = new HashSet<Workout>();
        }

        public int PersonId { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }

        public virtual ICollection<Nutrition> Nutritions { get; set; }
        public virtual ICollection<Workout> Workouts { get; set; }
    }
}
