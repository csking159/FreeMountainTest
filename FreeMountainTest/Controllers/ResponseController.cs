using FreeMountainTest.Data;
using FreeMountainTest.Models;
using FreeMountainTest.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeMountainTest.Controllers
{
    public class ResponseController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ResponseController(ApplicationDbContext db)
        {
            _db = db;
        }

        //DISPLAYS RESPONSE DATA
        public IActionResult Index()
        {
            IEnumerable<Response> objList = _db.Response;
            return View(objList);
        }

        //GET-Add
        public IActionResult Add(string id)
        {
            //creating a new Response View Model to hold Response values, and SelectList values
            ResponseVM responseVM = new ResponseVM()
            {
                Response = new Response(),
                ChannelSelectList = _db.Response.Select(id => new SelectListItem
                {
                    Text = id.Channel,
                    Value = id.Channel.ToString()
                })
            };

            if (id == null)
            {
                //for create
                return View(responseVM);
            }
            else
            {
                responseVM.Response = _db.Response.Find(id);
                if (responseVM.Response == null)
                {
                    //if the ID searched is not found
                    return NotFound();
                }
            }

            return View(responseVM);
        }

        //POST-Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(ResponseVM responseVM)
        {
            if (ModelState.IsValid)
            {
                if (_db.Response.Find(responseVM.Response.ResponseCode) == null)
                {
                    _db.Response.Add(responseVM.Response);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            //Select List
            responseVM.ChannelSelectList = _db.Response.Select(id => new SelectListItem
            {
                Text = id.Channel,
                Value = id.Channel.ToString()
            });
            return View(responseVM);
        }

        //GET-Update
        public IActionResult Update(string id)
        {
            //creating a new Response View Model to hold Response values, and SelectList values
            ResponseVM responseVM = new ResponseVM()
            {
                Response = new Response(),
                ChannelSelectList = _db.Response.Select(id => new SelectListItem
                {
                    Text = id.Channel,
                    Value = id.Channel.ToString()
                })
            };

            if(id == null)
            {
                //for create
                return View(responseVM);
            }
            else
            {
                responseVM.Response = _db.Response.Find(id);
                if(responseVM.Response == null)
                {
                    //if the ID searched is not found
                    return NotFound();
                }
                return View(responseVM);
            }
        }

        //POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ResponseVM responseVM)
        {
            if(ModelState.IsValid)
            {
                var objFromDb = _db.Response.Select(u => u.ResponseCode == responseVM.Response.ResponseCode);

                if(objFromDb != null)
                {
                    _db.Response.Update(responseVM.Response);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            //Select List
            responseVM.ChannelSelectList = _db.Response.Select(id => new SelectListItem
            {
                Text = id.Channel,
                Value = id.Channel.ToString()
            });
            return View(responseVM);
        }

        //GET-Delete
        public IActionResult Delete(string id)
        {
            //creating a new Response View Model to hold Response values, and SelectList values
            ResponseVM responseVM = new ResponseVM()
            {
                Response = new Response(),
                ChannelSelectList = _db.Campaign.Select(id => new SelectListItem
                {
                    Text = id.Channel,
                    Value = id.Channel.ToString()
                })
            };

            if (id == null)
            {
                return View(responseVM);
            }
            else
            {
                responseVM.Response = _db.Response.Find(id);
                if (responseVM.Response == null)
                {
                    //if the ID searched is not found
                    return NotFound();
                }
                return View(responseVM);
            }
        }

        //POST-Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(string id)
        {
            var obj = _db.Response.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Response.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
