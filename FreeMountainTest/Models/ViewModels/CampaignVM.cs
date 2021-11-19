using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeMountainTest.Models.ViewModels
{
    public class CampaignVM
    {
        public Campaign Campaign { get; set; }

        //selectList for specific input options
        public IEnumerable<SelectListItem> ClientSelectList { get; set; }
        public IEnumerable<SelectListItem> ChannelSelectList { get; set; }
    }
}
