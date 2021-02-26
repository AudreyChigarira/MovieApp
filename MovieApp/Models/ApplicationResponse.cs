using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class ApplicationResponse
    {

        public string Category { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }

        internal void Add(ApplicationResponse application)
        {
            throw new NotImplementedException();
        }
    }
}

