using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace AkilliHatirlatici.Models
{

    [Table("reminders")]
    public class Reminder : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("reminder_time")]
        public DateTime ReminderTime { get; set; }
    }
}

