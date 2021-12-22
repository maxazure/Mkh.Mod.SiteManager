using System;
using System.ComponentModel.DataAnnotations;
using Mkh.Mod.SiteManager.Core.Domain.Dbrecord;
using Mkh.Utils.Annotations;

namespace Mkh.Mod.SiteManager.Core.Application.Dbrecord.Dto;

[ObjectMap(typeof(DbrecordEntity))]
public class DbrecordAddDto
{
    /// <summary>
    /// 站点名称
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// 域名
    /// </summary>
    public string pwd { get; set; }

}