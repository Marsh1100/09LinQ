using Repuestos.Class;

List<Repuesto> listRepuestos = new List<Repuesto> (){
    new Repuesto() {IdRep=1, Nombre="Rep1",Precio=5000, Categoria=1},
    new Repuesto() {IdRep=2, Nombre="Rep2",Precio=5000, Categoria=2},
    new Repuesto() {IdRep=3, Nombre="Rep3",Precio=5000, Categoria=3},

    new Repuesto() {IdRep=4, Nombre="Rep4",Precio=5000, Categoria=3},
    new Repuesto() {IdRep=5, Nombre="Rep5",Precio=5000, Categoria=2},
    new Repuesto() {IdRep=6, Nombre="Rep6",Precio=5000, Categoria=1},

    new Repuesto() {IdRep=7, Nombre="Rep7",Precio=5000, Categoria=2},
    new Repuesto() {IdRep=8, Nombre="Rep8",Precio=5000, Categoria=1},
    new Repuesto() {IdRep=9, Nombre="Rep9",Precio=5000, Categoria=3}
};


var grupoCategorias = from repuesto in listRepuestos
                    group repuesto by repuesto.Categoria;

foreach(var categoriaGroup in grupoCategorias){
    Console.WriteLine("Grupo Categoría {0}",categoriaGroup.Key);

    foreach(var repuesto in categoriaGroup){
        string cat;
        if(repuesto.Categoria==1){
            cat = "Electrico";
        }else if(repuesto.Categoria==1){
            cat = "Supensión";

        }else{
            cat = "Frenos";



        }
        Console.WriteLine("Repuesto:{0}\tCategoría:{1}",repuesto.Nombre, cat);
    }
}
                    
