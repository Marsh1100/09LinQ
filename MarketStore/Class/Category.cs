namespace MarketStore.Class
{
    public class Category
    {
        public string IdCategory {get; set;}
        public string Description {get; set;}

        public Category(){}

        public Category( string idCategory, string description )
        {
            this.IdCategory = idCategory;
            this.Description = description;
        }

        public void NewCategory(List<Category> CategoryList){
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********* REGISTRO DE CATEGORÍA ************");
            Console.ResetColor();

            Console.WriteLine("Ingrese el nombre de la nueva categoría:");
            string description = Convert.ToString(Console.ReadLine());

            string idCategory = Guid.NewGuid().ToString();

            Category newCategorie = new(idCategory,description);
            CategoryList.Add(newCategorie);
            Console.WriteLine("\nCategoría {0} fue creada con éxito con el ID {1}", description, idCategory.Substring(0,5));

            Console.ReadKey();


        }


        public void ShowCategories(List<Category> CategoryList){
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Lista de categorías:");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0,-10} {1,15}", "ID", "CATEGORÍA");
            Console.ResetColor();

            foreach(var category in CategoryList){
                string subId = category.IdCategory.Substring(0,5);
                Console.WriteLine("{0,-10} {1,15}", subId, category.Description);
            }
            Console.ReadKey();
        }

    }
}