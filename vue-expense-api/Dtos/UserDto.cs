﻿using Newtonsoft.Json;

namespace vue_expense_api.Dtos
{
    public class UserDto
    {
        public UserDto()
        {
            
        }

        public UserDto(
            string username,
            string email,
            string token)
        {
            Username = username;
            Email = email;
            Token = token;
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        [JsonIgnore]
        public byte[] Hash { get; set; }
        [JsonIgnore]
        public byte[] Salt { get; set; }
    }
}