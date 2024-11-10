﻿using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public sealed class Role : IdentityRole<int>
    {
        public string RoleName { get; set; }
    }
}
