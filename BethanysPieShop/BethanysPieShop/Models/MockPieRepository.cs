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
                new Pie{PieId = 1, Name="Strawberry Pie", Price = 15.95M, ShortDescription = "yumi"}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
