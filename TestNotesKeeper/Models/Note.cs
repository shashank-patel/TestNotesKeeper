using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestNotesKeeper.Models
{
    public class Note
    {
        public int NoteId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        //[ScaffoldColumn(false)]
        //public User Author { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Created On")]
        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.Date)]
        [ScaffoldColumn(false)]
        [Display(Name = "Updated On")]
        public DateTime UpdatedDate { get; set; }

        [ScaffoldColumn(false)]
        public bool IsActive { get; set; }
    }
}
