using Notebook.Core.Domain;
using Notebook.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook.Infrastructure.Services
{
    public interface INoteService
    {
        NoteDTO Get(Guid Id);
        IEnumerable<NoteDTO> GetAll();
        NoteDTO Create(Guid Id, string title, string content, string keyWordsSummary);
        void Update(Guid Id, string title, string content, string keyWordsSummary);
        void Delete(Guid Id);
    }
}
