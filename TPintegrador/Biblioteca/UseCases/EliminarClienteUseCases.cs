namespace Biblioteca{

    class EliminarClienteUseCases:RepositorioClienteArchTexto{


        void Ejecutar(int dni){
            try{
                if(GetCliente(dni)!= null){
                    EliminarCliente(dni);
                }
            }   
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }


    }

}
