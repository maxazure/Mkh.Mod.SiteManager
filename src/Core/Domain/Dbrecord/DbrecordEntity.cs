using System;
using Mkh.Data.Abstractions.Annotations;
using Mkh.Data.Abstractions.Entities;

namespace Mkh.Mod.SiteManager.Core.Domain.Dbrecord;

/// <summary>
/// Databases
/// </summary>
public partial class DbrecordEntity : EntityBase<int>
{

    /// <summary>
    /// DbName
    /// </summary>
    [Length(255)]
    public string DbName { get; set; }

    /// <summary>
    /// Username
    /// </summary>
    [Length(255)]
    public string Username { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    [Length(255)]
    public string Pwd { get; set; }

}