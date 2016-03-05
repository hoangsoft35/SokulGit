using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hsp.GenericFramework.Commons.Security
{
    public class HspAuthorizeAttribute : AuthorizeAttribute
    {
        private string[] _rolesSplit = new string[0];
        private string[] _usersSplit = new string[0];
        private string _roles;
        private string _users;
        public string HspRoles
        {
            get
            {
                return _roles ?? string.Empty;
            }
            set
            {
                _roles = value;
                _rolesSplit = SplitString(value);
            }
        }

        public string HspUsers
        {
            get
            {
                return _users ?? string.Empty;
            }
            set
            {
                _users = value;
                _usersSplit = SplitString(value);
            }
        }

        internal static string[] SplitString(string original)
        {
            if (string.IsNullOrEmpty(original))
                return new string[0];
            return Enumerable.ToArray<string>(Enumerable.Select(Enumerable.Where(Enumerable.Select((IEnumerable<string>)original.Split(','), piece => new
            {
                piece = piece,
                trimmed = piece.Trim()
            }), param0 => !string.IsNullOrEmpty(param0.trimmed)), param0 => param0.trimmed));
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var isAuthorized = base.AuthorizeCore(httpContext);
            
            if (httpContext.Session["HspUser"] != null)
            {
                UserProfileLogin userProfileLogin = (UserProfileLogin)httpContext.Session["HspUser"];
                if (_rolesSplit.Any())
                {
                    isAuthorized = userProfileLogin.UserRoles.Any(x => _rolesSplit.Any(c => c.Contains(x.RoleName)));
                }
            }
            return isAuthorized; 
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new HttpUnauthorizedResult();
        }

        
    }
}
