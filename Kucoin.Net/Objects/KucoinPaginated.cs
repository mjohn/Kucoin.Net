﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kucoin.Net.Objects
{
    /// <summary>
    /// Page with results
    /// </summary>
    /// <typeparam name="T">Type of the items in the book</typeparam>
    public class KucoinPaginated<T>
    {
        /// <summary>
        /// The total number of results
        /// </summary>
        [JsonProperty("totalNum")]
        public int TotalItems { get; set; }
        /// <summary>
        /// The total number of pages
        /// </summary>
        [JsonProperty("totalPage")]
        public int TotalPages { get; set; }
        /// <summary>
        /// The amount of items per page
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// The current page
        /// </summary>
        public int CurrentPage { get; set; }
        /// <summary>
        /// The items on this page
        /// </summary>
        public IEnumerable<T> Items { get; set; } = Array.Empty<T>();
    }
}
