namespace Biblioteca{
    public class AgregarEmpleadoUseCases{
        RepositorioEmpleadoArchTexto re = new RepositorioEmpleadoArchTexto();
        public void Ejecutar(Empleado empleado){
            try{
                if(re.GetEmpleado(empleado.documento)!= null){
                    re.AgregarEmpleado(empleado);
                    Console.WriteLine("***********  Empleado Agregado Correctamente  ***********");
                }
                else{
                    throw new Exception("Empleado ya ingresado");
                }
            }      
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }

    }


}
