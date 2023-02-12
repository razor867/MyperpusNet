using System;
using System.Collections.Generic;

namespace APP_API.ViewModel
{
    public class bookViewModelDto
    {
        public string? BookId { get; set; }
        public string? BookName { get; set; }
        public int BookCategory { get; set; }
        public string? BookAuthor { get; set; }
        public DateTime PublicationDate { get; set; }
        public string? Publisher { get; set; }
        public int BookStock { get; set; }
        public int Status { get; set; }
    }
}