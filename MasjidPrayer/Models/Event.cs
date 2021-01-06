using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasjidPrayer.Models
{
    public class Event
    {
        [Key]
        public string EventId { get; set; }
        public string MyProperty { get; set; }
    }
}
