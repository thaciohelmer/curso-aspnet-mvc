﻿using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class FriendListMiddlewares
    {
        private readonly RequestDelegate _next;
        private readonly string _friendList;

        public FriendListMiddlewares(RequestDelegate next, string friendList)
        {
            _next = next;
            _friendList = friendList;
        }


        public async Task Invoke(HttpContext httpContext)
        {
            var remoteIp = httpContext.Connection.RemoteIpAddress;

            string[] ip = _friendList.Split(';');
            if (!_friendList.Contains("*"))
            {
                if (!ip.Any(option => option == remoteIp.ToString()))
                {
                    httpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                    return;
                }
            }
            await _next(httpContext);
        }
    }

}
