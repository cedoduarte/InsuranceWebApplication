namespace DbSeeding
{
    public class Car : ILastModified, ISoftDelete
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public decimal Price { get; set; }
        public string? PlateNumber { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastDeleted { get; set; }
    }
}
