namespace Biblioteca{
    class AgregarClienteUseCase:RepositorioClienteArchTexto{

        void Ejecutar(Cliente cliente){
            try{
                if(GetCliente(cliente.documento)!= null){
                    AgregarCliente(cliente);
                }
            }      
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }




    }
}
