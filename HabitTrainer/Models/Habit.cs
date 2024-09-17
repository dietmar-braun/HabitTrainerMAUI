using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft;
using Newtonsoft.Json;

namespace HabitTrainer.Models
{
    public enum RepetitionInterval {
        Daily,
        Weekly,
        Monthly
    };

    public class Repetition
    {
        [JsonProperty("interval")]
        public RepetitionInterval? Interval { get; set; }

        [JsonProperty("repetitions")]
        public int Repetitions { get; set; } = 0;
    } 

    public class Reminder
    {
        [JsonProperty("time")]
        public TimeOnly Time { get; set; }

    }

    public class Habit
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("repetition")]
        public Repetition? Repetition { get; set; }

        public IEnumerable<Reminder>? Reminders { get; set; }
    }
}
