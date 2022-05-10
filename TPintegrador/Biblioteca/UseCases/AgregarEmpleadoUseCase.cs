namespace Biblioteca{

    class AgregarEmpleadoUseCases:RepositorioEmpleadoArchTexto{

        void Ejecutar(Empleado empleado){
            try{
                if(GetEmpleado(empleado.documento)!= null){
                    AgregarEmpleado(empleado);
                }
            }      
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }

    }


}
