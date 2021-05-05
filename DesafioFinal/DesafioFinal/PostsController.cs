using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesafioFinal
{
    public class PostsController: Controller
    {
        public IActionResult Index()
        {
            var posts = PostsCSV.Carregar();

            return Ok(posts);
        }
        public IActionResult Show(int id)
        {
            var posts = PostsCSV.Carregar();

            var post = posts.Where(po => po.Id == id)
                .FirstOrDefault();

            return Ok(post);
        }
    }
}
