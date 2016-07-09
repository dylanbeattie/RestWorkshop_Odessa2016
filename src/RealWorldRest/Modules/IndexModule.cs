using System.Collections.Generic;
using System.Web.ModelBinding;
using Nancy;

namespace RealWorldRest.Modules {
    public class IndexModule : NancyModule {
        public IndexModule() {
            Get["/"] = _ => {
                var greeting = new { greeting = "Привет Одесса!" };
                return View["index", greeting];
            };
        }
    }
}