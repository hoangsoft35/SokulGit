using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Hsp.GenericFramework.Commons.CustomValidationAttribute
{
    public class IgnoreValidateFieldOnModelAttribute : ActionFilterAttribute
    {
        private string keysString;

        public IgnoreValidateFieldOnModelAttribute(string keys)
        : base()
    {
            this.keysString = keys;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ModelStateDictionary modelState = filterContext.Controller.ViewData.ModelState;
            string[] keyPatterns = keysString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < keyPatterns.Length; i++)
            {
                string keyPattern = keyPatterns[i]
                    .Trim()
                    .Replace(@".", @"\.")
                    .Replace(@"[", @"\[")
                    .Replace(@"]", @"\]")
                    .Replace(@"\[\]", @"\[[0-9]+\]")
                    .Replace(@"*", @"[A-Za-z0-9]+");
                IEnumerable<string> matchingKeys = modelState.Keys.Where(x => Regex.IsMatch(x, keyPattern));
                foreach (string matchingKey in matchingKeys)
                    modelState[matchingKey].Errors.Clear();
            }
        }
    }
}
