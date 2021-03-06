using System;
using System.Threading.Tasks;
using Mkh.Mod.SiteManager.Core.Application.Dbrecord.Dto;
using Mkh.Mod.SiteManager.Core.Domain.Dbrecord;
using Mkh.Utils.Map;

namespace Mkh.Mod.SiteManager.Core.Application.Dbrecord;

public class DbrecordService : IDbrecordService
{
    private readonly IMapper _mapper;
    private readonly IDbrecordRepository _repository;

    public DbrecordService(IMapper mapper, IDbrecordRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public Task<IResultModel> Query(DbrecordQueryDto dto)
    {
        var query = _repository.Find();

        return query.ToPaginationResult(dto.Paging);
    }

    public Task<IResultModel> Add(DbrecordAddDto dto)
    {
        var entity = _mapper.Map<DbrecordEntity>(dto);

        var result = _repository.Add(entity);

        return ResultModel.Result(result);
    }

    public async Task<IResultModel> Edit(int id)
    {
        var entity = await _repository.Get(id);
        if (entity == null)
            return ResultModel.NotExists;

        var model = _mapper.Map<DbrecordUpdateDto>(entity);
        return ResultModel.Success(model);
    }

    public async Task<IResultModel> Update(DbrecordUpdateDto dto)
    {
        var entity = await _repository.Get(dto.Id);
        if (entity == null)
            return ResultModel.NotExists;

        _mapper.Map(dto, entity);

        var result = await _repository.Update(entity);
        return ResultModel.Result(result);
    }

    public async Task<IResultModel> Delete(int id)
    {
        if (!await _repository.Exists(id))
            return ResultModel.NotExists;

        var result = await _repository.Delete(id);
        return ResultModel.Result(result);
    }
}