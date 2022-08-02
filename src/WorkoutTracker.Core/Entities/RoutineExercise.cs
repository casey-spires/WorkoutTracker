using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker.Core.Entities
{
    public class RoutineExercise: BaseEntity
    {
        public int RoutineId { get; set; }
        public int ExcerciseId { get; set; }
        public int Sets { get; set; }
        public int Repetitions { get; set; }
    }
}
