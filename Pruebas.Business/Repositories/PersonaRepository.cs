using Pruebas.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Business.Repositories
{
  public class PersonaRepository : IPersonaRepository
  {
    public ResponseDto<int> AddPersona(Persona persona)
    {
      throw new NotImplementedException();
    }

    public ResponseDto<List<Persona>> GetPersonas()
    {
      throw new NotImplementedException();
    }
  }
}
