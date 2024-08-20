﻿namespace InsuranceWebApplication.CQRS.Users.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateTime? Birthdate { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastDeleted { get; set; }
        public DateTime? LastCreated { get; set; }
    }
}
