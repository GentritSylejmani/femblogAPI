using System.Collections.Generic;
using System;
using femblogAPI.Models;

namespace femblogAPI.Data
{
    public class MockFemblogRepo : IFemblogRepo
    {
        public IEnumerable<Post> GetAllPosts()
        {
            var posts = new List<Post>
            {
                new Post{ PostID=0,Title="Postimi me id 0",                Category=PostCategory.Post,Content="Nje permbajtje lorem ipsum0213984 324uif",Posttime=DateTime.Now ,PostedBy = new User{Name="Gentri",Surname="Sylejmani"}},
                new Post{ PostID=1,Title=$"Postimi me id 1 ",Category=PostCategory.Photography,Content="Nje permbajtje lorem ipsum0213984 324uif",Posttime=DateTime.Now ,PostedBy = new User{Name="Gentri",Surname="Sylejmani"}},
                new Post{ PostID=2,Title="Postimi me id 2",Category=PostCategory.Video,Content="Nje permbajtje lorem ipsum0213984 324uif",Posttime=DateTime.Now ,PostedBy = new User{Name="Gentri",Surname="Sylejmani"}}
            };

            return posts;

        }

        public Post GetPostById(int id)
        {
            return new Post{ PostID=0,Title="Postimi me id 0",Category=PostCategory.Post,Content="Nje permbajtje lorem ipsum0213984 324uif",Posttime=DateTime.Now ,PostedBy = new User{Name="Gentrit",Surname="Sylejmani"}};
        }
    }
}