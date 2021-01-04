using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_APIs.Data
{
    public class Positions
    {
        [Key]
        public Guid PositionID { get; set; }
        public string Position { get; set; }
        public string SortOrder { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Rates> Staffs { get; set; }
    }
}
