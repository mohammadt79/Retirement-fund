using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Retirementfund_MVC.Services;
using System;
using System.Net;

namespace Retirementfund_MVC.Middlewares
{
	[AttributeUsage(AttributeTargets.Class)]
	public class RFAuthorize : Attribute, IAuthorizationFilter
	{


		public void OnAuthorization(AuthorizationFilterContext filterContext)
		{

			if (filterContext != null)
			{
				var _authTokensService = filterContext.HttpContext.RequestServices.GetService(typeof(AuthTokenCache)) as AuthTokenCache;
				var _token = filterContext.HttpContext.Request.Cookies["access_token"];

				if (_token != null)
				{
					try
					{
						var user = _authTokensService.Get(_token);
						if (user!=null)
						{
							if (user.Admin)
							{
								return;
							}
							else
							{
								filterContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
								filterContext.HttpContext.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "لطفا ابتدا وارد شوید";
								filterContext.Result = new ViewResult
								{
									ViewName = "~/Views/Shared/401.cshtml",
								};
							}
						}
						else
						{
							filterContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
							filterContext.HttpContext.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "لطفا ابتدا وارد شوید";
							filterContext.Result = new ViewResult
							{
								ViewName = "~/Views/Shared/401.cshtml",
							};
						}
					}
					catch
					{

						filterContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
						filterContext.HttpContext.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "لطفا ابتدا وارد شوید";
						filterContext.Result = new ViewResult
						{
							ViewName = "~/Views/Shared/401.cshtml",
						};
					}
				}
				else
				{
					filterContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
					filterContext.HttpContext.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "لطفا ابتدا وارد شوید";
					filterContext.Result = new ViewResult
					{
						ViewName = "~/Views/Shared/401.cshtml",
					};
				}
			}
			else
			{
				filterContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
				filterContext.HttpContext.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "لطفا ابتدا وارد شوید";
				filterContext.Result = new ViewResult
				{
					ViewName = "~/Views/Shared/401.cshtml",
				};
			}
		}
	}
}
