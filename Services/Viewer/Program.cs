using Microsoft.Extensions.Hosting;

namespace ABCS.Test.Web.Viewer
{

    internal sealed class Program
    {
        public static void Main(string[] args)
        {
            WindowsWebServiceSupport.Initialize<Startup>(args: args, sourceName: "ABCS.Test.Web.Viewer");
        }
    }
}
