using NZwalks.Models;
using System.ComponentModel.DataAnnotations;

namespace NZwalks.DTO
{
    public class WalksResponseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public double LengthInKm { get; set; }
        public string WalkImageUrl { get; set; } = "";

        public Region Region { get; set; }

        public Difficulty Difficulty { get; set; }

    }

    public class WalksRequestDTO
    {
        [Required]
        public string Name { get; set; } = "";
        
        [Required]
        public string Description { get; set; } = "";

        [Required]
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; } = null;

        [Required]
        public Guid RegionId { get; set; }

        [Required]
        public Guid DifficultyId { get; set; }

    }
}
