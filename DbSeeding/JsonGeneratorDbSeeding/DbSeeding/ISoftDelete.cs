namespace DbSeeding
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
        DateTime? LastDeleted { get; set; }
    }
}
