using System;
using System.Collections.Generic;
using System.Linq;
using femblogAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace femblogAPI.Data
{
    public class SQLfemblogapiRepo : IFemblogRepo
    {
        private readonly femblogapiContext _context;

        public SQLfemblogapiRepo(femblogapiContext context)
        {
            _context=context;
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u =>u.UserId==id);
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

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }

}