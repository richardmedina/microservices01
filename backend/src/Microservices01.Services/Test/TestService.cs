namespace Microservices01.Services.Test;
using Microservices01.Common.Services;
using Microservices01.Common.Contract.Dto;
using Microservices01.Common.Contract.Dto.Test;

public class TestService : ITestService 
{

  public async Task<ServiceResponseDto> GetByIdAsync(int id)
  {
    var result = new ServiceResponseWithDataDto<TestDto>() 
    {
      Result = new TestDto(1, "Richard", "Medina", "ricki9@gmail.com", "password")
    };
    
    await Task.CompletedTask;
    return result;
  }

  public async Task<ServiceResponseDto> GetAllAsync()
  {
    await Task.CompletedTask;
    throw new NotImplementedException();
  }
}