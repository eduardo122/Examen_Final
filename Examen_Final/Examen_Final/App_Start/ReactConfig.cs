using React;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Examen_Final.ReactConfig), "Configure")]

namespace Examen_Final
{
	public static class ReactConfig
	{
		public static void Configure()
		{
            ReactSiteConfiguration.Configuration
                .AddScript("~/Scripts/App.js");
            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();
        }
	}
}