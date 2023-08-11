namespace MarketStore.Class
{
    public static class Env
    {
        private static string fileName= "products.json";
        private static List<Product> products = new List<Product> ();

        public static string FileName {get => fileName; set => fileName = value;}

        public static List<Product> Products {get => products; set=> products=value;} 

        public static void LoadDataProducts()
            {
                using (StreamReader reader = new StreamReader(Env.FileName)){
                string json = reader.ReadToEnd();
                Env.Products = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(json,new System.Text.Json.JsonSerializer)
            }
    }
    }

   
}