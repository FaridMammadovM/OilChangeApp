﻿namespace Domain.Entities
{
    public sealed class Commits
    {
        public int Id { get; set; }
        public string CommitMessage { get; set; }
        public int CustumerId { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
        public Customers Customers { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public TimeSpan UpdatedDate { get; set; }
    }
}
