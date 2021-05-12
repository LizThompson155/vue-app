using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Liz.VueApp.Books.Dto;

namespace Liz.VueApp.Books
{
    public interface IBookAppService 
    {
        Task<List<BookDto>> GetBooks();
    }
}
