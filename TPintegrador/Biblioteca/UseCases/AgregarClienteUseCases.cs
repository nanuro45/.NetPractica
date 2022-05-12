namespace Biblioteca{
    public class AgregarClienteUseCase{
        RepositorioClienteArchTexto rc = new RepositorioClienteArchTexto();
        public void Ejecutar(Cliente cliente){
            try{
                if(rc.GetCliente(cliente.documento) == null){
                    rc.AgregarCliente(cliente);
                    Console.WriteLine("***********  Cliente Agregado Correctamente  ***********");
                }
                else{
                    throw new Exception("Cliente ya ingresado");
                }
            }     
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }


    }
}
