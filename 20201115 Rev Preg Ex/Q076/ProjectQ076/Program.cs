using System;

namespace ProjectQ076
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio ProjectQ076");
            Console.WriteLine("Caso 1 Se produce AdventureWorksValidationException:");
            LanzarDoWork(1);
            Console.WriteLine("Caso 2 Se produce AdventureWorksDbException:");
            LanzarDoWork(2);
            Console.WriteLine("Caso 3 Se produce AdventureWorksException:");
            LanzarDoWork(3);
            Console.WriteLine("Caso 4 Se produce Exception:");
            LanzarDoWork(4);
            Console.WriteLine("Fin ProjectQ076");
        }

        static void LanzarDoWork(int caso)
        {
            // Solucion en el PDF:
            try
            {
                DoWork(caso);
            }
            catch (AdventureWorksValidationException ex)
            {
                Log(ex);
            }
            catch (AdventureWorksDbException ex)
            {
                Log(ex);
            }
            catch (AdventureWorksException ex)
            {
                Log(ex);
            }
            
            //Solucion alternativa que hace más de lo pedido:
            /*
            try
            {
                DoWork(caso);
            }
            catch (AdventureWorksValidationException ex)
            {
                Log(ex);
            }
            catch (AdventureWorksException ex)
            {
                Log(ex);
            }
            catch (Exception ex)
            {
                Log(ex);
            }
            */
        }

        static void DoWork(int caso)
        {
            switch(caso) {
                case 1:
                    throw new AdventureWorksValidationException();
                    //break;
                case 2:
                    throw new AdventureWorksDbException();
                    //break;
                case 3:
                    throw new AdventureWorksException();
                    //break;
                case 4:
                    throw new Exception();
                    //break;
            }
        }

        static void Log(Exception ex)
        {
            Console.WriteLine("Se ha producido Exception");
        }

        static void Log(AdventureWorksException ex)
        {
            Console.WriteLine("Se ha producido AdventureWorksException");
        }
        static void Log(AdventureWorksValidationException ex)
        {
            Console.WriteLine("Se ha producido AdventureWorksValidationException");
        }
    }
    
    public class AdventureWorksException : System.Exception { }

    public class AdventureWorksDbException : AdventureWorksException { }

    public class AdventureWorksValidationException : AdventureWorksException {  }
}
