using Pruebas.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Business.Repositories
{
  public interface IPersonaRepository
  {
    public ResponseDto<List<Persona>> GetPersonas();
    public ResponseDto<int> AddPersona(Persona persona);
  }
}
