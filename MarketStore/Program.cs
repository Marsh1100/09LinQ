
using MarketStore.Class;
using MarketStore.View;

List<Product> ProductList = new(){
    new Product() {CodeProduct = "1", Name="Name1", Stoke=5, MinStoke=2, MaxStoke=10,SellPrice=4500, PurchasePrice=4000}
};

List<Category> CategoryList = new(){
    new Category() {IdCategory = "1", Description="Description1"},
    new Category() {IdCategory = "2", Description="Description2"},
    new Category() {IdCategory = "3", Description="Description3"}
};
//Intanciar clases para usar sus métodos
Menu mMenu = new ();
Product mProduct = new ();
string opcion;
do{
    opcion = mMenu.ShowMenu();

    switch(opcion){
        case "1": //Registrar Producto
            mProduct.NewProduct(ProductList, CategoryList);
            break;
        case "2": //Registrar Categoria
            break;
        case "3": //Listar Categorias
            break;
        case "4": //Listar Productos
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
