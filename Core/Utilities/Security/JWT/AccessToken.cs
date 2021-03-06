using System;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public int UserId { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}