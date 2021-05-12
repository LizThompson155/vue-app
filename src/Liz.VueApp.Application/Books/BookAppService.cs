using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Liz.VueApp.Authorization;
using Liz.VueApp.Books;
using Liz.VueApp.Books.Dto;

namespace Liz.VueApp.Users
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class BookAppService : IBookAppService
    {
        private readonly IRepository<Book> _bookRepository;

        public BookAppService (
            IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<BookDto>> GetBooks()
        {
            var books = await _bookRepository.GetAllListAsync();
            return new List<BookDto>();
        }
    }
}

