﻿namespace IFC.Application.Contracts.Persistence.Repositries;

public interface ISectorHeadQuarterRepo
{
    Task CreateSectorHeadQuarterDetailAsync(SectorHeadQuarter socialMediaProfile);
    Task DeleteSectorHeadQuarterDetailReposAsync(long? id);
    Task<List<SectorHeadQuarter>> GetSectorHeadQuarterDetailReposAsync();
    Task<SectorHeadQuarter?> GetSectorHeadQuarterDetailReposAsync(long? id);
}