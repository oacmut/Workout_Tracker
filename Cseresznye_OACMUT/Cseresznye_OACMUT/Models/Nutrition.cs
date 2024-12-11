using System;
using System.Collections.Generic;

namespace Cseresznye_OACMUT.Models
{
    public partial class Nutrition
    {
        public int NutritionId { get; set; }
        public int PersonId { get; set; }
        public DateTime Date { get; set; }
        public string? MealType { get; set; }
        public int? Calories { get; set; }
        public string? Notes { get; set; }

        public virtual Person Person { get; set; } = null!;
    }
}
