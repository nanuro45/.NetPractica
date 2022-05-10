using System;
using ClasesInterfaces;

namespace Biblioteca{
    public class ModificarClienteUseCase: RepositorioClienteArchTexto{
        public void Ejecutar(Cliente cliente){
        try {
            if(GetCliente(cliente.documento) != null){
                ModificarCliente(cliente);
            }
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
      }
    }
}
