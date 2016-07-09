using System;
using System.Diagnostics;
using System.Linq;
using Nancy;
using Nancy.ModelBinding;
using RealWorldRest.Data;
using RealWorldRest.Data.Entities;

namespace RealWorldRest.Modules {
    public class ProfilesModule : NancyModule {
        private readonly IDatabase db = new DemoDatabase();

        public ProfilesModule() {
            Get["/profiles"] = _ => db.ListProfiles();
        }
    }
}