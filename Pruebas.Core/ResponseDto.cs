using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Core
{
  public class ResponseDto<T>
  {
    public T Data { get; set; }
    public bool Success { get; set; }
    public string Errors { get; set; } = string.Empty;
  }
}
