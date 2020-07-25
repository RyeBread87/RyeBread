using RyeBread.Core;
using RyeBread.Core.Objects;
using System.Collections.Generic;

namespace RyeBread.Models
{
  /// <summary>
  /// View model used to wrap data for sidebar widgets.
  /// </summary>
  public class WidgetViewModel
  {
    public WidgetViewModel(IBlogRepository blogRepository)
    {
      Categories = blogRepository.Categories();
      siteStatsModel = new SiteStatsModel();
      //Tags = blogRepository.Tags();
      LatestPosts = blogRepository.Posts(0, 10);
      siteStatsModel.TotalPosts = blogRepository.TotalPosts(true);
      siteStatsModel.TotalCategories = blogRepository.TotalCategories();
    }

    public IList<Category> Categories 
    { get; private set; }

    public IList<Tag> Tags 
    { get; private set; }

    public IList<Post> LatestPosts 
    { get; private set; }
    
    public SiteStatsModel siteStatsModel { get; set; }
    }
}