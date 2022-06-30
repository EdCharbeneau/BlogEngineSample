using RazorLight;
using System.Reflection;


var engine = new RazorLightEngineBuilder()
    .UseFileSystemProject(
        Path.GetDirectoryName(
        Assembly.GetExecutingAssembly().Location)
        )
    .UseMemoryCachingProvider()
    .Build();

ViewModel model = new();
string result = await engine.CompileRenderAsync("index.cshtml", model);

Console.WriteLine(result);
Console.ReadKey();

public class ViewModel
{
    public string Title { get; set; } = "Hello World";

    public string Body { get; set; } = "Greatest Blogpost ever";
}

