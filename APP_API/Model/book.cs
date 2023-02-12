using System;
using System.Collections.Generic;

namespace APP_API.Model
{
    public class book
    {
        public string? book_id { get; set; }
        public string? book_name { get; set; }
        public int book_category { get; set; }
        public string? book_author { get; set; }
        public decimal publication_date { get; set; }
        public string? publisher { get; set; }
        public int book_stock { get; set; }
        public int status { get; set; }
        public decimal created_date { get; set; }
        public decimal created_time { get; set; }
        public string? created_user { get; set; }
        public decimal updated_date { get; set; }
        public decimal updated_time { get; set; }
        public string? updated_user { get; set; }
    }
}