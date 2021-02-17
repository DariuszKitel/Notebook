using AutoMapper;
using Notebook.Core.Domain;
using Notebook.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(config =>
            {
                config.CreateMap<Note, NoteDTO>();
            })
            .CreateMapper();
    }
}
