namespace Biblioteca{
    public class ListaDeClientesUseCases{

        RepositorioClienteArchTexto rc= new RepositorioClienteArchTexto();

        public List<Cliente> Ejecutar(){
            return rc.GetClientes();
        }
    }
}
