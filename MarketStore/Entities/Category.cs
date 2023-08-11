using Newtonsoft.Json;

namespace marketStore.Entities
{
    public class Category
    {
        private string idCategory {get; set;}
        private string description {get; set;}

        public string IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Category(){}

        public Category( string IdCategory, string Description )
        {
            this.idCategory = IdCategory;
            this.description = Description;
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
            
            Env.MarketStore.Categories.Add(newCategorie);
            string json = JsonConvert.SerializeObject(Env.MarketStore, Formatting.Indented);
            File.WriteAllText(Env.FileName, json);
            Console.WriteLine("\nCategoría {0} fue creada con éxito con el ID {1}", description, idCategory.Substring(0,5));

            Console.ReadKey();


        }


        public void ShowCategories(){


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Lista de categorías:");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0,-10} {1,15}", "ID", "CATEGORÍA");
            Console.ResetColor();

            foreach(var category in Env.MarketStore.Categories){
                string subId = category.IdCategory.Substring(0,5);
                Console.WriteLine("{0,-10} {1,15}", subId, category.Description);
            }
            Console.ReadKey();
        }

    }
}