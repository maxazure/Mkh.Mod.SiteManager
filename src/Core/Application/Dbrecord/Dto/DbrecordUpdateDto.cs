using System;
using System.ComponentModel.DataAnnotations;
using Mkh.Mod.SiteManager.Core.Domain.Dbrecord;
using Mkh.Utils.Annotations;

namespace Mkh.Mod.SiteManager.Core.Application.Dbrecord.Dto;

[ObjectMap(typeof(DbrecordEntity), true)]
public class DbrecordUpdateDto : DbrecordAddDto
{
    [Required(ErrorMessage = "请选择要修改的数据")]
    [Range(1, int.MaxValue, ErrorMessage = "请选择要修改的数据")]
    public int Id { get; set; }
}