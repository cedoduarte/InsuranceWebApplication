namespace DbSeeding
{
    public class User : ILastModified, ISoftDelete
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastDeleted { get; set; }
    }
}
