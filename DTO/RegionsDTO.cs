using System.ComponentModel.DataAnnotations;

namespace NZwalks.DTO
{
    public class RegionsResponseDTO
    {

        public string Name { get; set; }
        public string Code { get; set; }
        public string RegionsImageUrl { get; set; }

        public Guid Id { get; set; }
    }

    public class RegionsRequestDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public string? RegionsImageUrl { get; set; }
    }

    public class RegionsUpdateRequestDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }

        public string? RegionsImageUrl { get; set; }
    }
}
