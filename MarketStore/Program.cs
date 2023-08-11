
using Newtonsoft.Json;
using marketStore;
using marketStore.Entities;
using marketStore.View;

List<Product> ProductList = new(){
    new Product() {CodeProduct = "00001", Name="Name1", Stoke=5, MinStoke=2, MaxStoke=10,SellPrice=4500, PurchasePrice=4000, IdCategory="11111"}
};

List<Category> CategoryList = new(){
    new Category() {IdCategory = "11111", Description="Description1"},
    new Category() {IdCategory = "22222", Description="Description2"},
    new Category() {IdCategory = "33333", Description="Description3"}
};

if(Env.ValidateFile(Env.FileName)==false)
{
    File.WriteAllText(Env.FileName,"");
}else{
    Env.LoadDataProducts(Env.FileName);
}


//Intanciar clases para usar sus métodos
Menu mMenu = new ();
Product mProduct = new ();
Category mCategory = new();
string opcion;

//Env.ShowData("Products", Env.MarketStore.Categories);
do{
    opcion = mMenu.ShowMenu();

    switch(opcion){
        case "1": //Registrar Producto
            mProduct.NewProduct(ProductList, CategoryList);
            string json = JsonConvert.SerializeObject(Env.MarketStore, Formatting.Indented);
            File.WriteAllText(Env.FileName, json);
            break;
        case "2": //Registrar Categoria
            mCategory.NewCategory(CategoryList);
            
            break;
        case "3": //Listar Categorias
            mCategory.ShowCategories();
            break;
        case "4": //Listar Productos
            mProduct.ShowProducts();
            break;
        case "5": //Costo total del inventario
            break;
        case "0": //Salir
            break;
        default:
            Console.ForegroundColor=ConsoleColor.Red; Console.WriteLine("No es un valor válido"); Console.ResetColor();
            Console.ReadKey();
            break;
    }
}while(opcion!="0");
