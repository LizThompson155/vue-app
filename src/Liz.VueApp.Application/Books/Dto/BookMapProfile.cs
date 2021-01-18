using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liz.VueApp.Books.Dto
{
    public class BookMapProfile : Profile
    {
        public BookMapProfile()
        {
            CreateMap<BookDto, Book>();
        }
    }
}
