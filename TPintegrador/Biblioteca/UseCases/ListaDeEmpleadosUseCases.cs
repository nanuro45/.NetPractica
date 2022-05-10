namespace Biblioteca{

    class ListaDeEmpleadosUseCases:RepositorioEmpleadoArchTexto{


        List<Empleado> Ejecutar(){
            return GetEmpleados();
        }
    }
}
