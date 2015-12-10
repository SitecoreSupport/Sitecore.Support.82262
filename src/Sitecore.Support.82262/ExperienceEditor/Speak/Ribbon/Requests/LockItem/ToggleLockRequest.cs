using Sitecore.ExperienceEditor.Speak.Server.Responses;
using Sitecore.Web;

namespace Sitecore.Support.ExperienceEditor.Speak.Ribbon.Requests.LockItem
{
  public class ToggleLockRequest : Sitecore.ExperienceEditor.Speak.Ribbon.Requests.LockItem.ToggleLockRequest
  {
    public override PipelineProcessorResponseValue ProcessRequest()
    {
      var cookieKey = Context.Site.GetCookieKey("sc_date");
      WebUtil.SetCookieValue(cookieKey, string.Empty);

      return base.ProcessRequest();
    }
  }
}