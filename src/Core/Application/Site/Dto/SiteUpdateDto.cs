using System;
using System.ComponentModel.DataAnnotations;
using Mkh.Mod.SiteManager.Core.Domain.Site;
using Mkh.Utils.Annotations;

namespace Mkh.Mod.SiteManager.Core.Application.Site.Dto;

[ObjectMap(typeof(SiteEntity), true)]
public class SiteUpdateDto : SiteAddDto
{
    [Required(ErrorMessage = "请选择要修改的数据")]
    [Range(1, int.MaxValue, ErrorMessage = "请选择要修改的数据")]
    public int Id { get; set; }
}