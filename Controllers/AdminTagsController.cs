using Bloggie.Web.Models.ViewModel;
using BloggieMVC.Data;
using BloggieMVC.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BloggieMVC.Controllers
{
    public class AdminTagsController : Controller
    {
        private  readonly BloggieDbContext bloggieDbContext;

        public AdminTagsController(BloggieDbContext bloggieDbContext)
    {
            this.bloggieDbContext = bloggieDbContext;
        }


    
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            //Mapping Add Tag Reqst
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName,
            };


            bloggieDbContext.Tags.Add(tag);
            bloggieDbContext.SaveChanges();
            return View("Add");
        }
    }
}
