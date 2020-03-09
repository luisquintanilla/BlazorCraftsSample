using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class RatingRequest
    {
        public string ProductId { get; set; }
        public int Rating { get; set; }
    }
}
