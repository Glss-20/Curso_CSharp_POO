using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEnumAndComposition15.Entities
{
    public class Post
    {
        public DateTime Momment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();// É criado uma lista para os comentários porque aqui ocorre uma relaçao de
        // muitos para um, ou seja, um "Post" tem vários "Comment". Então na classe "Post" é criado uma lista para adicionar os "Comment".

        public Post()
        {

        }

        public Post(DateTime momment, string title, string content, int likes)
        {
            Momment = momment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.AppendLine(" Likes - ");
            sb.AppendLine(Momment.ToString("dd/mm/yyyy hh:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text); 
            }
            return sb.ToString();
        }

    }
}
