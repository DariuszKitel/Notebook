using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook.Infrastructure.DTO
{
    public class NoteDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string KeyWordsSummary { get; set; }
    }
}
