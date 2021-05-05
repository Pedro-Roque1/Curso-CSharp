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
        public IActionResult Index([FromQuery] string buscar)
        {
            var posts = PostsCSV.Carregar();
            

            if (!String.IsNullOrEmpty(buscar))
            {
                var busca = posts.Where(po => po.Titulo.Contains(buscar) || po.Texto.Contains(buscar));
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
