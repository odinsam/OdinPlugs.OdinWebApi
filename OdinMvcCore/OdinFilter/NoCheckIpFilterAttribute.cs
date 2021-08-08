using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OdinPlugs.OdinWebApi.OdinMvcCore.OdinFilter
{
    public class NoCheckIpAttribute : Attribute
    {

    }
    public class NoCheckIpFilterAttribute : ActionFilterAttribute
    {
        public NoCheckIpFilterAttribute()
        {
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}