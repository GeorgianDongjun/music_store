﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_music_store.Startup))]
namespace mvc_music_store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
