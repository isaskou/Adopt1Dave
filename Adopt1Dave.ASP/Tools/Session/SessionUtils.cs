using Adopt1Dave.ASP.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adopt1Dave.ASP.Tools.Session
{
    public class SessionUtils
    {
        static IServiceProvider services = null;

        /// <summary>
        /// Provides static access to the framework's services provider
        /// </summary>
        public static IServiceProvider Services
        {
            private get { return services; }
            set
            {
                if (services != null)
                {
                    throw new Exception("Can't set once a value has already been set.");
                }
                services = value;
            }
        }

        /// <summary>
        /// Provides static access to the current HttpContext
        /// </summary>
        private static HttpContext Current
        {
            get
            {
                IHttpContextAccessor httpContextAccessor = services.GetService(typeof(IHttpContextAccessor)) as IHttpContextAccessor;
                return httpContextAccessor?.HttpContext;
            }
        }


        public static UserModel ConnectedUser
        {
            get
            {
                if (Current.Session == null) return null;
                return Current.Session.Get<UserModel>("ConnectedUser");
            }
            set { Current.Session.Set<UserModel>("ConnectedUser", value); }
        }

        public static bool IsLogged
        {
            get
            {

                if (Current.Session == null) return false;
                return Current.Session.Get<bool>("IsLogged");
            }
            set { Current.Session.Set<bool>("IsLogged", true); }
        }
    }
}
