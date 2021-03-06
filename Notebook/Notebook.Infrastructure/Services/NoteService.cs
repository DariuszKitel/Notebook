﻿using AutoMapper;
using Notebook.Core.Domain;
using Notebook.Core.Repositories;
using Notebook.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notebook.Infrastructure.Services
{
    public class NoteService : INoteService
    {

        private readonly INoteRepository _noteRepository;
        private readonly IMapper _mapper;

        public NoteService(INoteRepository noteRepository, IMapper mapper)
        {
            _noteRepository = noteRepository;
            _mapper = mapper;
        }

        public NoteDTO Get(Guid Id)
        {
            var note = _noteRepository.Get(Id);

            return _mapper.Map<NoteDTO>(note);
        }

        public IEnumerable<NoteDTO> GetAll()
        {
            var notes = _noteRepository.GetAll();
            return _mapper.Map<IEnumerable<NoteDTO>>(notes);
        }

        public NoteDTO Create(Guid Id, string title, string content, string keyWordsSummary)
        {
            var note = new Note(Id, title, content, keyWordsSummary);
            _noteRepository.Add(note);
            return _mapper.Map<NoteDTO>(note);
        }

        public void Update(Guid Id, string title, string content, string keyWordsSummary)
        {
            var note = _noteRepository.Get(Id);
            note.SetTitle(title);
            note.SetContent(content);
            note.SetKeyWordsSummary(keyWordsSummary);
            _noteRepository.Update(note);
        }

        public void Delete(Guid Id)
        {
            var note = _noteRepository.Get(Id);
            _noteRepository.Delete(note);
        }        
    }
}
