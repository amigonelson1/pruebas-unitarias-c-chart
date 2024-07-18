using System.ComponentModel;

namespace CIC.Core
{
  public class ResponseDto<T>
  {
    public T Data { get; set; }
    public bool IsSuccessful { get; set; } = false;
    public List<string> Errors { get; set; } = [];
  }
}
