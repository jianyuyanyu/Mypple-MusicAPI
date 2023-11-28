﻿using IdentityServiceDomain.Entity;

namespace IdentityService.WebAPI.Admin
{
    public record SimpleUser(Guid Id, string UserName, string PhoneNumber, DateTime CreationTime)
    {
        public static SimpleUser Create(User user)
        {
            return new SimpleUser(user.Id, user.UserName, user.PhoneNumber, user.CreationTime);
        }
    }
}