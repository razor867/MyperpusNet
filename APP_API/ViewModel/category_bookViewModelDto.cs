using System;
using System.Collections.Generic;

namespace APP_API.ViewModel
{
    public class category_bookViewModelDto
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public decimal CreatedDate { get; set; }
        public decimal CreatedTime { get; set; }
        public string? CreatedUser { get; set; }
        public decimal UpdatedDate { get; set; }
        public decimal UpdatedTime { get; set; }
        public string? UpdatedUser { get; set; }
    }
}