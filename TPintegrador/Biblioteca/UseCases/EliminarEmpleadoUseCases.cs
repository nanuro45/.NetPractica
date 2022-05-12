namespace Biblioteca{

    public class EliminarEmpleadoUseCases{

        RepositorioEmpleadoArchTexto re = new RepositorioEmpleadoArchTexto();
        public void Ejecutar(int dni){
            try{
                if(re.GetEmpleado(dni)!= null){
                    re.EliminarEmpleado(dni);
                }
            }   
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }
    }
}
