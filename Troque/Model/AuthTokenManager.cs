using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troque.Model
{
    public class AuthTokenManager
    {
        private static readonly Lazy<AuthTokenManager> lazy = new Lazy<AuthTokenManager>(() => new AuthTokenManager());
        private string _accessToken;

        private AuthTokenManager() { }

        public static AuthTokenManager Instance => lazy.Value;

        public string AccessToken
        {
            get => _accessToken;
            set => _accessToken = value;
        }
    }
}
