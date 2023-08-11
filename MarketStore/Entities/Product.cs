using Newtonsoft.Json;

namespace marketStore.Entities
{
    public class Product
    {
        public string CodeProduct { get; set; }
        public string Name { get; set; }
        public int Stoke { get; set; }
        public int MinStoke { get; set; }
        public int MaxStoke { get; set; }
        public double SellPrice  {get; set;}
        public double PurchasePrice {get; set;}
        public string IdCategory {get; set;}

    
        public Product(){
            
        }

        public Product(string name, int stoke, int minStoke, int maxStoke, double sellPrice, double purchasePrice, string idCategory ){
            this.CodeProduct = Guid.NewGuid().ToString();
            this.Name = name;
            this.Stoke = stoke;
            this.MinStoke = minStoke;
            this.MaxStoke = maxStoke;
            this.SellPrice = sellPrice;
            this.PurchasePrice = purchasePrice;
            this.IdCategory = idCategory;
            
        }

        public void NewProduct(List<Product> ProductList, List<Category> CategoryList){
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********* REGISTRO DE PRODCUTO ************");
            Console.ResetColor();

            Console.WriteLine("Ingrese nombre del producto:");
            string name = Convert.ToString(Console.ReadLine());

            int stock = validateNumberInt("Digite número de stock del producto:");
            int stockMin = validateNumberInt("Digite número de stock mínimo de stock del producto:");
            int stockMax = validateNumberInt("Ingrese el stock mínimo del producto:");
            double sellPrice = validateNumberDouble("Ingrese valor de venta del producto:");
            double purchasePrice = validateNumberDouble("Ingrese valor de compra del producto:");

            Console.WriteLine("Ingrese el ID categoría del producto:");
            string idCategory = Convert.ToString(Console.ReadLine());

            var filteredResult = from cat in CategoryList
                where cat.IdCategory.StartsWith(idCategory)
                select cat;

            if(filteredResult.Count()>0){
                Product newProduct = new (name,stock, stockMin, stockMax,sellPrice,purchasePrice, idCategory);
                
                ProductList.Add(newProduct);

                
                Console.WriteLine("Producto agregado de forma exitosa!");
                Env.MarketStore.Products.Add(newProduct);
                string json = JsonConvert.SerializeObject(Env.MarketStore, Formatting.Indented);
                File.WriteAllText(Env.FileName, json);
                ShowProducts(ProductList);

            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El ID de categoría no se encuenta resgistrado :c");
                Console.ResetColor();

            }

        }

        public int validateNumberInt(string text){
            Console.WriteLine(text);
            if(!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite un valor válido.");
                Console.ResetColor();

                validateNumberInt(text);
            }
            return number; 
        }

        public double validateNumberDouble(string text){
             Console.WriteLine(text);
            if(!double.TryParse(Console.ReadLine(), out double number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite un valor válido.");
                Console.ResetColor();

                validateNumberDouble(text);
            }
            return number;
        }

        public void ShowProducts(List<Product> ProductList){

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("{0,-10} {1,10} {2,10} {3,15} {4,10} {5,10} {6,15} {7,15}","Code","Category","Nombre","Stock","Min Stock","Max Stock","Sell Price","Purchase Price");
            Console.ResetColor();

            foreach(Product item in ProductList){
                Console.WriteLine("{0,-10} {1,10} {2,10} {3,15} {4,10} {5,10} {6,15} {7,15}", item.CodeProduct.Substring(0,5), item.IdCategory.Substring(0,5), item.Name, item.Stoke, item.MinStoke, item.MaxStoke, item.SellPrice, item.PurchasePrice);
            }
            
        }


    }
}