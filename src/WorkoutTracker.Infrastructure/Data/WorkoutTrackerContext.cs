using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutTracker.Core;
using WorkoutTracker.Core.Entities;

namespace WorkoutTracker.Infrastructure.Data
{
    public class WorkoutTrackerContext: DbContext
    {
        public DbSet<Routine> Routines { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<RoutineExercise> RoutineExercises { get; set; }
    }
}
