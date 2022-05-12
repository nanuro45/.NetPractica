namespace Biblioteca{
    public class ListaDePersonasUseCase{
        public List<Persona> Ejecutar(){
            List<Persona>aux= new List<Persona>();
            var listaclientes = new ListaDeClientesUseCases().Ejecutar();
            foreach(var cliente in listaclientes){
                aux.Add(cliente);
            }
            var listaempleados = new ListaDeEmpleadosUseCases().Ejecutar();
            foreach(var empleado in listaempleados){
                aux.Add(empleado);
            }
            return aux;
        }
    } 

}
