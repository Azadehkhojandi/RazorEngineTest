using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RazorEngine.Templating;
using System.Reflection;
using System.IO;

namespace Infrastructure
{
    public static class DynamicTemplate
    {
        public static string GiveCshtml<T>(T model,string templateName="GeneralInformation")
        {

            using (var service = new TemplateService())
            {
                var layoutTemplate = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("Infrastructure.Templates._Layout.cshtml")).ReadToEnd();
                var page = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(string.Format("Infrastructure.Templates.{0}.cshtml", templateName))).ReadToEnd();

                service.Compile(layoutTemplate, typeof(T), "_Layout");

                return service.Parse(page, model);
                
            }
        }
    }
}
