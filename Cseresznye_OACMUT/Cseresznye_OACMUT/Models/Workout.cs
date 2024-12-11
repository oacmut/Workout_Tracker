using System;
using System.Collections.Generic;

namespace Cseresznye_OACMUT.Models
{
    public partial class Workout
    {
        public int WorkoutId { get; set; }
        public int PersonId { get; set; }
        public string WorkoutName { get; set; } = null!;
        public DateTime Date { get; set; }
        public int? DurationMinutes { get; set; }
        public int? CaloriesBurned { get; set; }

        public virtual Person Person { get; set; } = null!;
    }
}
