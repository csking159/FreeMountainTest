using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeMountainTest.Models.ViewModels
{
    public class ResponseVM
    {
        public Response Response { get; set; }
        public IEnumerable<SelectListItem> ChannelSelectList { get; set; }
    }
}
