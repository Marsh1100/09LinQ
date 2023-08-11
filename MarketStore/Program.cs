
using MarketStore.Class;
using MarketStore.View;

List<Product> ProductList = new(){
    new Product() {CodeProduct = "00001", Name="Name1", Stoke=5, MinStoke=2, MaxStoke=10,SellPrice=4500, PurchasePrice=4000, IdCategory="11111"}
};

List<Category> CategoryList = new(){
    new Category() {IdCategory = "11111", Description="Description1"},
    new Category() {IdCategory = "22222", Description="Description2"},
    new Category() {IdCategory = "33333", Description="Description3"}
};
//Intanciar clases para usar sus métodos
Menu mMenu = new ();
Product mProduct = new ();
Category mCategory = new();
string opcion;
do{
    opcion = mMenu.ShowMenu();

    switch(opcion){
        case "1": //Registrar Producto
            mProduct.NewProduct(ProductList, CategoryList);
            break;
        case "2": //Registrar Categoria
            mCategory.NewCategory(CategoryList);
            break;
        case "3": //Listar Categorias
            mCategory.ShowCategories(CategoryList);
            break;
        case "4": //Listar Productos
            mProduct.ShowProducts(ProductList);
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
