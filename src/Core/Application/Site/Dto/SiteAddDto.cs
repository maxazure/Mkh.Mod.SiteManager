using System;
using System.ComponentModel.DataAnnotations;
using Mkh.Mod.SiteManager.Core.Domain.Site;
using Mkh.Utils.Annotations;

namespace Mkh.Mod.SiteManager.Core.Application.Site.Dto;

[ObjectMap(typeof(SiteEntity))]
public class SiteAddDto
{
    /// <summary>
    /// 站点名称
    /// </summary>
    public string sitename { get; set; }

    /// <summary>
    /// 域名
    /// </summary>
    public string domain { get; set; }

}