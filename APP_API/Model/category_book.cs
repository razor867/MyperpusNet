using System;
using System.Collections.Generic;

namespace APP_API.Model
{
    public class category_book
    {
        public int category_id { get; set; }
        public string? category_name { get; set; }
        public decimal created_date { get; set; }
        public decimal created_time { get; set; }
        public string? created_user { get; set; }
        public decimal updated_date { get; set; }
        public decimal updated_time { get; set; }
        public string? updated_user { get; set; }
    }
}