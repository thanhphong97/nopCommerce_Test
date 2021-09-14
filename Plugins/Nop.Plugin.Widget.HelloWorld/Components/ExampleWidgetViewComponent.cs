using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.HelloWorld.Components
{
    [ViewComponent(Name = "HelloWorldWidget")]
    public class ExampleWidgetViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke(string widgetZone)
        {
            return Content("Hello World");
        }
    }
}
