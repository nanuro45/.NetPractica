namespace Biblioteca{

    public class EliminarClienteUseCases{

        RepositorioClienteArchTexto rc = new RepositorioClienteArchTexto();
        public void Ejecutar(int dni){
            try{
                if(rc.GetCliente(dni)!= null){
                    rc.EliminarCliente(dni);
                }
            }   
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }

    }

}
