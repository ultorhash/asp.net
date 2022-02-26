using AutoMapper;
using LibApp.Data;
using LibApp.Dtos;
using LibApp.Interfaces;
using LibApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _repository;
        public BooksController(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet()]
        public IEnumerable<BookDto> GetBooks(string query = null)
        {
            var booksQuery = _repository.GetAllBooks();

            if (!String.IsNullOrWhiteSpace(query))
            {
                booksQuery = _repository.GetBookByPrefixMatch(query);
            }

            return booksQuery.ToList().Select(_mapper.Map<Book, BookDto>);
        }
    }
}
