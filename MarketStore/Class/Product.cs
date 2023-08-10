
namespace MarketStore.Class
{
    public class Product
    {
        public string CodeProduct { get; set; }
        public string Name { get; set; }
        public int Stoke { get; set; }
        public int MinStoke { get; set; }
        public int MaxStoke { get; set; }
        public double  SellPrice  {get; set;}
        public double PurchasePrice {get; set;}
        public string IdCategory {get; set;}

    
        public Product(){}

        public Product(string name, int stoke, int minStoke, int maxStoke, double sellPrice, double purchasePrice, string idCategory ){
            this.CodeProduct = Guid.NewGuid().ToString();
            this.Name = name;
            this.Stoke = stoke;
            this.MinStoke = minStoke;
            this.MaxStoke = maxStoke;
            this.IdCategory = idCategory;
        }

        public void NewProduct(List<Product> ProductList, List<Category> CategoryList){
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********* REGISTRO DE PRODCUTO ************");
            Console.ResetColor();

            Console.WriteLine("Ingrese nombre del producto:");
            string name = Convert.ToString(Console.ReadLine());

            bool invalido = true;
                do
                {
                    Console.WriteLine("Ingrese el stock del producto:");
                    if(!int.TryParse(Console.ReadLine(), out int stock))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite un número de stock válido.");
                        Console.ResetColor();
                    }else
                    {
                        invalido = false;
                    }
                }while(invalido);
                invalido = true;
                do
                {
                    Console.WriteLine("Ingrese el stock máximo del producto:");
                    if(!int.TryParse(Console.ReadLine(), out int stockMin))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite un número de stock máximo válido.");
                        Console.ResetColor();
                    }else
                    {
                        invalido = false;
                    }
                }while(invalido);
                invalido = true;

                do
                {
                    Console.WriteLine("Ingrese el stock mínimo del producto:");
                    if(!int.TryParse(Console.ReadLine(), out int stockMax))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite un número de stock máximo válido.");
                        Console.ResetColor();
                    }else
                    {
                        invalido = false;
                    }
                }while(invalido);

                Console.WriteLine("Ingrese categoría del producto:");
                string idCategory = Convert.ToString(Console.ReadLine());

                var filteredResult = from cat in CategoryList
                    where cat.IdCategory == idCategory
                    select cat;

                if(filteredResult.Count()>0){
                    Console.WriteLine("Hola,sì");
                }else{

                }




        }


    }
}