﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MyNote.API.Startup))]

namespace MyNote.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // https://stackoverflow.com/questions/12521499/cors-support-for-put-and-delete-with-asp-net-web-api
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            ConfigureAuth(app);
        }
    }
}
