using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeMountainTest.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Campaign> Campaigns { get; set; }
        public IEnumerable<Response> Responses { get; set; }
    }
}
