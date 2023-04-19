namespace Microservices01.Common.Contract.Dto;

public class ServiceResponseWithDataDto<TResult> : ServiceResponseDto 
{
  public TResult Result { get; set; } = default!;
}
