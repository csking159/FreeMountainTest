using FreeMountainTest.Data;
using FreeMountainTest.Models;
using FreeMountainTest.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeMountainTest.Controllers
{
    public class CampaignController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CampaignController(ApplicationDbContext db)

        {
            _db = db;
        }

        //DISPLAYS CAMPAIGN DATA
        public IActionResult Index(string searchString)
        {
            IEnumerable<Campaign> objList = _db.Campaign;
            return View(objList);
        }

        //GET-Add
        public IActionResult Add(string id)
        {
            //creating a new Campaign View Model to hold Campaign values, and SelectList values
            CampaignVM campaignVM = new CampaignVM()
            {
                Campaign = new Campaign(),
                ClientSelectList = _db.Campaign.Select(id => new SelectListItem
                {
                    Text = id.Client,
                    Value = id.Client.ToString()
                }),

                ChannelSelectList = _db.Campaign.Select(id => new SelectListItem
                {
                    Text = id.Channel,
                    Value = id.Channel.ToString()
                })
            };

            if (id == null)
            {
                //for create
                return View(campaignVM);
            }
            else
            {
                campaignVM.Campaign = _db.Campaign.Find(id);
                if (campaignVM.Campaign == null)
                {
                    //if the ID searched is not found
                    return NotFound();
                }
                return View(campaignVM);
            }
        }

        //POST-Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(CampaignVM campaignVM)
        {
            if (ModelState.IsValid)
            {
                //if the Mfid is non-existant, a campaign will be created
                if (_db.Campaign.Find(campaignVM.Campaign.Mfid) == null)
                {
                    _db.Campaign.Add(campaignVM.Campaign);
                }
                //saves the updated changes to the database
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            //Select Lists
            campaignVM.ClientSelectList = _db.Campaign.Select(id => new SelectListItem
            {
                Text = id.Client,
                Value = id.Client.ToString()
            });
            campaignVM.ChannelSelectList = _db.Campaign.Select(id => new SelectListItem
            {
                Text = id.Channel,
                Value = id.Channel.ToString()
            });

            return View(campaignVM);
        }

        //GET-Update
        public IActionResult Update(string id)
        {
            //creating a new Campaign View Model to hold Campaign values, and SelectList values
            CampaignVM campaignVM = new CampaignVM()
            {
                Campaign = new Campaign(),
                ClientSelectList = _db.Campaign.Select(id => new SelectListItem
                {
                    Text = id.Client,
                    Value = id.Client.ToString()
                }),
                ChannelSelectList = _db.Campaign.Select(id => new SelectListItem
                {
                    Text = id.Channel,
                    Value = id.Channel.ToString()
                })
            };

            if (id == null)
            {
                //for create
                return View(campaignVM);
            }
            else
            {
                campaignVM.Campaign = _db.Campaign.Find(id);
                if (campaignVM.Campaign == null)
                {
                    //if the ID searched is not found
                    return NotFound();
                }
                return View(campaignVM);
            }
        }

        //POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(CampaignVM campaignVM)
        {
            if (ModelState.IsValid)
            {
                //var objFromDb is created as an instance of Campaign. The following line selects the Campaign being updated, found by the ID.
                var objFromDb = _db.Campaign.Select(u => u.Mfid == campaignVM.Campaign.Mfid); 
                if (objFromDb != null)
                {
                    //updates in the database
                    _db.Campaign.Update(campaignVM.Campaign);
                }
                //saves the updated changes to the database
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            //Select Lists
            campaignVM.ClientSelectList = _db.Campaign.Select(id => new SelectListItem
            {
                Text = id.Client,
                Value = id.Client.ToString()
            });
            campaignVM.ChannelSelectList = _db.Campaign.Select(id => new SelectListItem
            {
                Text = id.Channel,
                Value = id.Channel.ToString()
            });

            return View(campaignVM);
        }
        
        //GET-Delete
        public IActionResult Delete(string id)
        {
            //creating a new Campaign View Model to hold Campaign values, and SelectList values
            CampaignVM campaignVM = new CampaignVM()
            {
                Campaign = new Campaign(),
                ClientSelectList = _db.Campaign.Select(id => new SelectListItem
                {
                    Text = id.Client,
                    Value = id.Client.ToString()
                }),
                ChannelSelectList = _db.Campaign.Select(id => new SelectListItem
                {
                    Text = id.Channel,
                    Value = id.Channel.ToString()
                })
            };

            if (id == null)
            {
                return View(campaignVM);
            }
            else
            {
                campaignVM.Campaign = _db.Campaign.Find(id);
                if (campaignVM.Campaign == null)
                {
                    //if the ID searched is not found
                    return NotFound();
                }
                return View(campaignVM);
            }
        }

        //POST-Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(string id)
        {
            var obj = _db.Campaign.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Campaign.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
