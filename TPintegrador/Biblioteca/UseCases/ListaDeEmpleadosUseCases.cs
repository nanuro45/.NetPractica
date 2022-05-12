namespace Biblioteca{

    public class ListaDeEmpleadosUseCases{
        RepositorioEmpleadoArchTexto re = new RepositorioEmpleadoArchTexto();

        public List<Empleado> Ejecutar(){
            return re.GetEmpleados();
        }
    }
}
