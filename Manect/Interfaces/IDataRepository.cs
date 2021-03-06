﻿using Manect.Data.Entities;
using ManectTelegramBot.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manect.Interfaces
{
    public interface IDataRepository
    {
        Task<int> FindUserIdByNameOrDefaultAsync(string name);
        Task<int> FindUserIdByEmailOrDefaultAsync(string email);
        Task AddStageAsync(int userId, int projectId);
        Task AddProjectDefaultAsync(int CurrentUserId);
        Task DeleteStageAsync(int userId, int projectId, int stageId);
        Task DeleteProjectAsync(int userId, int projectId);
        Task SetFlagValueAsync(int userId, int projectId, int stageId, Status status);
        Task<Project> GetAllProjectDataAsync(int projectId, int stageId = default);
        Task<List<Project>> GetProjectOrDefaultToListAsync(int userId);
        Task<List<Executor>> GetExecutorsToListExceptAsync(int executorId);
        Task EditExecutorAsync(DataToChange dataToChange);
        Task EditStageAsync(Stage stage);
        Task EditProjectAsync(Project project, int userId);
        Task AddFileAsync(DataToChange dataToChange);
        Task DeleteFileAsync(DataToChange dataToChange);
        Task<AppFile> GetFileAsync(DataToChange dataToChange);
        Task<List<AppFile>> FileListAsync(DataToChange dataToChange);
        Task<List<Executor>> GetProgectListExecutorsAsync();
        Task<bool> IsAdminAsync(DataToChange dataToChange);
        Task<List<Project>> GetStagesListDelegatedAsync(DataToChange dataToChange);
        Task<long> GetTelegramIdAsync(DataToChange dataToChange);
        Task AddTelegramIdAsync(DataToChange dataToChange);
        Task<MessageObject> GetInformationForMessageAsync(DataToChange dataToChange);
        Task<Executor> GetFullNameAsync(DataToChange dataToChange);
    }
}
