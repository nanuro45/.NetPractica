namespace Biblioteca{

    class EliminarEmpleadoUseCases:RepositorioEmpleadoArchTexto{
        void Ejecutar(int dni){
            try{
                if(GetEmpleado(dni)!= null){
                    EliminarEmpleado(dni);
                }
            }   
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }
    }
}
