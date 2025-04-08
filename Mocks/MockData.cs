using Bogus;
using NZwalks.Models;

namespace NZwalks.Mocks
{
    public static class MockData
    {

        private static List<Region> _regions = [];
        private static List<Walks> _walks = [];
        private static List<Difficulty> _diffculties = [];


        public static List<Region> RegionsMockData { get => _regions; }
        public static List<Difficulty> DifficultyMockData { get => _diffculties; }
        public static List<Walks> WalksMockData { get => _walks; }

         static MockData()
        {
            Randomizer.Seed = new Random(1994);
            GetRegionsMock();
            GetDifficultiesMock();
            GetWalksMockData();
        }



        private static void GetRegionsMock()
        {
            var regionsFaker = new Faker<Region>()
                .RuleFor(r => r.Id, f => f.Random.Guid())
                .RuleFor(r => r.Name, f => f.Address.City())
                .RuleFor(r => r.Code, f => f.Address.CityPrefix())
                .RuleFor(r => r.RegionImageUrl, f => f.Image.LoremFlickrUrl());


            _regions =  regionsFaker.Generate(5);
        }

        private static void GetDifficultiesMock()
        {
            _diffculties = new List<Difficulty>{
                new Difficulty()
                {
                    Id = Guid.Parse("42D731F8-D04E-4633-9C4F-1A4A27500B55"),
                    Name = "Easy"
                },
                 new Difficulty()
                {
                    Id = Guid.Parse("0C306FAB-D484-41FE-9A44-D6088BB75DAF"),
                    Name = "Medium"
                },
                  new Difficulty()
                {
                    Id = Guid.Parse("5895A33B-FAFC-4798-9688-2C609D097FE6"),
                    Name = "Difficult"
                },
            };
        }


        private static void GetWalksMockData()
        {
            var walksFaker = new Faker<Walks>()
                .RuleFor(r => r.Id, f => f.Random.Guid())
                .RuleFor(r => r.Name, f => f.Address.StreetName())
                .RuleFor(r => r.LengthInKm, f => f.Random.Number(0, 40))
                .RuleFor(r => r.Description, f => f.Lorem.Sentence(10))
                .RuleFor(r => r.DifficultyId, f => f.PickRandom(DifficultyMockData).Id)
                .RuleFor(r => r.RegionId, f => f.PickRandom(RegionsMockData).Id);

            _walks = walksFaker.Generate(20);
            
        }
    }
}
