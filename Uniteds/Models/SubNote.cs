using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Uniteds.Models
{
    public class SubNote
    {
        public int Id { get; set; }
        public string Content { get; set; }
        [ForeignKey("NoteId")]
        public int? NoteId { get; set; }

    }
}
