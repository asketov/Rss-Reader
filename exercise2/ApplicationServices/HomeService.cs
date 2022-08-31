using System.Collections.Generic;
using exercise2.Core;
using exercise2.DomainServices;
using exercise2.GeneralServices;

namespace exercise2.ApplicationServices
{
    public class HomeService
    {
        private readonly SettingsService _settingsService;
        private readonly PostService _postService;
        public HomeService(SettingsService settingsService, PostService postService)
        {
            _settingsService = settingsService;
            _postService = postService;
        }

        public IEnumerable<Post> GetAllPostsFromRss()
        {
            return _postService.GetAllPosts(_settingsService.Urls);
        }
    }
}
