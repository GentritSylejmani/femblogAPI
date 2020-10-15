using System;
using System.Collections.Generic;
using System.Linq;
using femblogAPI.Models;

namespace femblogAPI.Data
{
    public class SQLfemblogapiRepo : IFemblogRepo
    {
        private readonly femblogapiContext _context;

        public SQLfemblogapiRepo(femblogapiContext context)
        {
            _context=context;
        }
        public IEnumerable<Post> GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        public Post GetPostById(int id)
        {
            return _context.Posts.FirstOrDefault(p => p.PostID==id);
        }

        public void CreatePost(Post post)
        {
            if (post==null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            _context.Posts.Add(post);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges()>=0);
        }
    }

}