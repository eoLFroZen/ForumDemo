using Forum.Models;
using Forum.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Forum.Controllers
{
    public class PostController : Controller
    {
        private PostService postService;

        public PostController(PostService postService)
        {
            this.postService = postService;
        }

        public IActionResult Index()
        {
            List<Post> posts = postService.GetAll();

            return View(posts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string content)
        {
            postService.Create(content);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Post post = postService.GetById(id);

            return View(post);
        }

        [HttpPost]
        public IActionResult Edit(int id, string content)
        {
            postService.Edit(id, content);

            return RedirectToAction(nameof(Index));
        }
    }
}
