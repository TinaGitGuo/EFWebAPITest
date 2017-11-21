using System;
using System.Collections.Generic;

namespace EFWebAPITest.Models
{
    public partial class Notes
    {
        public long NoteId { get; set; }
        public string EntityType { get; set; }
        public long EntityId { get; set; }
        public string Text { get; set; }
        public int InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
