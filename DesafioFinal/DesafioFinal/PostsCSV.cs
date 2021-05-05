using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioFinal
{
    public static class PostsCSV
    {
        private static readonly string nomeArquivoCSV = "ArquivoPosts\\Posts.csv";

        public static List<Post> Carregar()
        {
            var listaPosts = new List<Post>();

            using (var file = File.OpenText(PostsCSV.nomeArquivoCSV))
            {
                while (!file.EndOfStream)
                {
                    var postText = file.ReadLine();
                    if (string.IsNullOrEmpty(postText))
                    {
                        continue;
                    }
                    var infoPost = postText.Split(';');
                    var post = new Post
                    {
                        Id = Convert.ToInt32(infoPost[0]),
                        Titulo = infoPost[1],
                        Texto = infoPost[2]
                    };


                    listaPosts.Add(post);
                }               
            }

            return listaPosts;
        }
    }
}

