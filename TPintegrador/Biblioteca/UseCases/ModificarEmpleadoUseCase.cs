
using System;
using ClasesInterfaces;

namespace Biblioteca{
    public class ModificarEmpleadoUseCase: RepositorioEmpleadoArchTexto{
        public void Ejecutar(Empleado empleado){
        try {
            if(GetEmpleado(empleado.documento) != null){
                ModificarEmpleado(empleado);
            }
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
      }
    }
}
