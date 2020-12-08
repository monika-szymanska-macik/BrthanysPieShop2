using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new Mock_CategoryRepository();
        public IEnumerable<Pie> AllPies => 
            new List<Pie>
            {
                new Pie{PieId = 1, Name="Strawberry Pie", Price = 15.95M, ShortDescription = "yumi", CategoryId = 2, Category = _categoryRepository.AllCategories.ToList()[0], LongDescription = "yumi", ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", InStock=true, IsPieOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"},
                new Pie{PieId = 2, Name="Cheese Cake", Price = 18.95M, CategoryId = 2, Category = _categoryRepository.AllCategories.ToList()[1], ShortDescription = "yumi", LongDescription = "yumi", ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", InStock=true, IsPieOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"},
                new Pie{PieId = 3, Name="Rhubarb Pie", Price = 15.95M, CategoryId = 1, Category = _categoryRepository.AllCategories.ToList()[0], ShortDescription = "yumi", LongDescription = "yumi", ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", InStock=true, IsPieOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"},
                new Pie{PieId = 4, Name="Pumpkin Pie", Price = 12.95M, CategoryId = 3, Category = _categoryRepository.AllCategories.ToList()[2], ShortDescription = "yumi", LongDescription = "yumi", ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", InStock=true, IsPieOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
