using Mkh.Host.Web;

namespace Mkh.Mod.SiteManager.WebHost;

public class Program
{
    public static void Main(string[] args)
    {
        new HostBootstrap(args).Run();
    }
}