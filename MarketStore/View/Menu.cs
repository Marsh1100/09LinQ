
namespace marketStore.View
{
    public class Menu
    {
        //Constructor
        public Menu(){
            
        }

        public string ShowMenu(){
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n********* SUPER TIENDA ABS ************");
            Console.ResetColor();

            Console.WriteLine("1.Registrar producto");
            Console.WriteLine("2.Registrar categoria");
            Console.WriteLine("3.Listar categorias");
            Console.WriteLine("4.Listar productos");
            Console.WriteLine("5.Costo total del inventario");
            Console.WriteLine("0.Salir\n");
            
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Elegir opción:"); Console.ResetColor();            
            string opcion = Convert.ToString(Console.ReadLine());
            
            return opcion;
        }
    }
}