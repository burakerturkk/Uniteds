using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Uniteds.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<SubNote> SubNote { get; set; } = new List<SubNote>();
    }
}
