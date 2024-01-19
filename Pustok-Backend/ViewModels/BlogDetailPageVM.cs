using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.BlogComment;
using Pustok_Backend.Areas.Admin.ViewModels.Category;
using Pustok_Backend.Areas.Admin.ViewModels.Social;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;

namespace Pustok_Backend.ViewModels
{
    public class BlogDetailPageVM
    {
        public BlogDetailVM  Blog { get; set; }
        public List<SocialVM> Socials { get; set; }

        public List<BlogVM> LatestBlogs { get; set; }
        public List<BlogVM> RelatedBlogs { get; set; }

        public List<TagVM> Tags { get; set; }

        public List<(int Month, int Count)> Dates { get; set; }

        public BlogCommentCreateVM BlogComment { get; set; }
        public List<CategoryVM> Categories { get; set; }


    }
}
