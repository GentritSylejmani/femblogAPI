using System.Collections.Generic;
using femblogAPI.Models;

namespace femblogAPI.Data
{
    public interface IFemblogRepo
    {
        public IEnumerable<Post> GetAllPosts();
        public Post GetPostById(int id);
    }
}