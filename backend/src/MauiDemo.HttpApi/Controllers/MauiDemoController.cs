using MauiDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MauiDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MauiDemoController : AbpControllerBase
{
    protected MauiDemoController()
    {
        LocalizationResource = typeof(MauiDemoResource);
    }
}
