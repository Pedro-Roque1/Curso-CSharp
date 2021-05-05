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
        public IActionResult Index(string id)
        {
            var posts = PostsCSV.Carregar();
            

            if (!String.IsNullOrEmpty(id))
            {
                var busca = posts.Where(po => po.Titulo.Contains(id) || po.Texto.Contains(id));
                return Ok(busca);
            }
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
