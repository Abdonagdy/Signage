namespace MizeSignage.ViewModels
{
    public class SignageViewModel
    {
        public int Id { get; set; } // int
        public string SignageUrl { get; set; } // nvarchar(max)
        public int? Duration { get; set; } // int
        public bool? IsActive { get; set; } // bit
        public int? DisplayOrder { get; set; } // int
    }
}
