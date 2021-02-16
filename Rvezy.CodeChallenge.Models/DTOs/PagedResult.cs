using System;
using System.Collections.Generic;

namespace Rvezy.CodeChallenge.Models.DTOs
{
    public class PagedResult<T> : PagedResultBase where T : class
    {
        public IList<T> Results { get; set; }

        public PagedResult()
        {
            Results = new List<T>();
        }
    }

}
