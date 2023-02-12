using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using APP_API.Data;
using APP_API.ViewModel;
using APP_API.Model;
using APP_API.Helpers;
using AutoMapper;

namespace APP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _repo;
        private readonly IMapper _mapper;

        public BookController(
            IBookRepository repo,
            IMapper mapper
        )
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetListBooks([FromQuery] Params prm)
        {
            var data = await _repo.GetListBooks(prm);
            if (data.Count() == 0)
                return BadRequest("Buku tidak ditemukan");

            var result = _mapper.Map<IEnumerable<bookViewModelDto>>(data);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest("Buku tidak ditemukan");

            var data = await _repo.GetBookById(id);
            if (data == null)
                return BadRequest("Buku tidak ditemukan");

            var result = _mapper.Map<bookViewModelDto>(data);
            return Ok(result);
        }
    }
}