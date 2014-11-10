using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Reflection;


public abstract class WebServiceBase : WebService, IHttpHandlerFactory
{

    private static WebServiceHandlerFactory wshf = new WebServiceHandlerFactory();

    private static MethodInfo coreGetHandlerMethod = typeof(WebServiceHandlerFactory).GetMethod("CoreGetHandler", BindingFlags.Instance | BindingFlags.NonPublic);
    public System.Web.IHttpHandler GetHandler(System.Web.HttpContext context, string requestType, string url, string pathTranslated)
    {
        return (IHttpHandler)coreGetHandlerMethod.Invoke(wshf, new object[] {
            this.GetType(),
            context,
            context.Request,
            context.Response
        });
    }


    public void ReleaseHandler(System.Web.IHttpHandler handler)
    {
    }

}
