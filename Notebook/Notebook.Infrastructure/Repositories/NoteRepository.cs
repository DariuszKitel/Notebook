using Notebook.Core.Domain;
using Notebook.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notebook.Infrastructure.Repositories
{
    class NoteRepository : INoteRepository
    {
        //Simulating database fields
        private static readonly ISet<Note> _notes = new HashSet<Note>()
        {
            new Note(Guid.NewGuid(), "Title one", "Content one", "KeyWords one"),
            new Note(Guid.NewGuid(), "Title two", "Content two", "KeyWords two")
        };
        public Note Get(Guid id)
        {
            return _notes.SingleOrDefault(x => x.Id == id );
        }
        public IEnumerable<Note> GetAll()
        {
            return _notes;
        }
        public Note Add(Note note)
        {
            _notes.Add(note);
            return note;
        }
        public void Update(Note note)
        {
            throw new NotImplementedException();
        }
        public void Delete(Note note)
        {
            _notes.Remove(note);
        }

    }
}
