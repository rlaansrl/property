using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Property.Models
{
    public class Board
    {
        [Key]
        public int BoardNo { get; set; }
        public string BoardTitle { get; set; }
        public string BoardContent { get; set; }

        public int UserNo { get; set; }
        [ForeignKey("UserNo")]
        public virtual User User { get; set; }
    }
}
