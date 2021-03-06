using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sporty.Models
{
    public class Event
    {
        public int ID { get; set; }

        // Photo
        // Date Time
        // Title of Event
        // Group Name
        // Number of Attendees
        // Actions: share link, star/favorite

        [Column("Title")]
        [Display(Name = "Title of Event")]
        [StringLength(256)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
                       ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:MM}",
                       ApplyFormatInEditMode = true)]
        [Display(Name = "Time")]
        public DateTime Time { get; set; }      // minutes

        public long Duration { get; set; }

        // Single/Double/Group can be inferred from number of users
        public IList<User> Members { get; set; }
    }
}
