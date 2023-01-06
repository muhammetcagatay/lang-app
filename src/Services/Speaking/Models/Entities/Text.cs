using System;
using System.Collections.Generic;

namespace Speaking.Models.Entities
{
    public partial class Text
    {
        public Text()
        {
            Scors = new HashSet<Scor>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDelete { get; set; }
        public string TextContent { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Scor> Scors { get; set; }
    }
}
