﻿using Domain.Attributes;

namespace Domain.User
{
    [Auditable]
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string  Password { get; set; }
        public string Role { get; set; }
    }
}
