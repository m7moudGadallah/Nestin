﻿using System.ComponentModel.DataAnnotations;

namespace Nestin.Core.Dtos.UserProfilesDto
{
    public class UserProfileQueryParamsDto : GetAllQueryDto
    {
        public string? UserId { get; set; }
        public string? Role { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
        public string? UserName { get; set; }
    }
}
