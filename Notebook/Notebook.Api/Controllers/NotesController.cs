﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notebook.Infrastructure.DTO;
using Notebook.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var notes = _noteService.GetAll();
            return Ok(notes);
        }

        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            var note = _noteService.Get(id);
            if (note == null)
            {
                return NotFound();
            }
            return Ok(note);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NoteDTO note)
        {
            var newId = Guid.NewGuid();
            note = _noteService.Create(newId, note.Title, note.Content, note.KeyWordsSummary);
            return Created($"api/notes/{newId}", note);
        }

        [HttpPut("id")]
        public IActionResult Put(Guid id, [FromBody] NoteDTO note)
        {
            _noteService.Update(id, note.Title, note.Content, note.KeyWordsSummary);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _noteService.Delete(id);
            return NoContent();
        }
    }
}
