using System;
using Mkh.Data.Abstractions.Annotations;
using Mkh.Data.Abstractions.Entities;

namespace Mkh.Mod.SiteManager.Core.Domain.Site;

/// <summary>
/// 站点
/// </summary>
public partial class SiteEntity : EntityBase<int>
{
    /// <summary>
    /// 站点名称
    /// </summary>
    [Length(255)]
    public string sitename { get; set; }

    /// <summary>
    /// 域名
    /// </summary>
    [Length(255)]
    public string domain { get; set; }

}