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


        public void ShowCategories(List<Category> CategoryList){
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Lista de categorías:");
            Console.ResetColor();

            foreach(var category in CategoryList){
                Console.WriteLine("{0,-20}","{}");
            }
        }

    }
}