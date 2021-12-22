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
    /// Username
    /// </summary>
    [Length(255)]
    public string name { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    [Length(255)]
    public string pwd { get; set; }

}