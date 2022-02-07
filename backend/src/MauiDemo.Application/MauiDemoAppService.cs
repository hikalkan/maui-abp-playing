using System;
using System.Collections.Generic;
using System.Text;
using MauiDemo.Localization;
using Volo.Abp.Application.Services;

namespace MauiDemo;

/* Inherit your application services from this class.
 */
public abstract class MauiDemoAppService : ApplicationService
{
    protected MauiDemoAppService()
    {
        LocalizationResource = typeof(MauiDemoResource);
    }
}
