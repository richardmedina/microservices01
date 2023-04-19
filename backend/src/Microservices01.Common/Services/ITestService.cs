namespace Microservices01.Common.Services;
using Microservices01.Common.Contract.Dto;

public interface ITestService
{
  Task<ServiceResponseDto> GetByIdAsync(int id);
  Task<ServiceResponseDto> GetAllAsync();
}