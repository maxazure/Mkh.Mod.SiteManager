using System;
using System.ComponentModel.DataAnnotations;
using Mkh.Mod.SiteManager.Core.Domain.Dbrecord;
using Mkh.Utils.Annotations;

namespace Mkh.Mod.SiteManager.Core.Application.Dbrecord.Dto;

[ObjectMap(typeof(DbrecordEntity))]
public class DbrecordAddDto
{
    /// <summary>
    /// DbName
    /// </summary>
    public string DbName { get; set; }

    /// <summary>
    /// Username
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    public string Pwd { get; set; }

}