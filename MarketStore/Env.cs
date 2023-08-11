
using marketStore.Entities;
namespace marketStore;

public static class Env
{
    private static string fileName = "MarketStore.json";
    private static MarketStore marketstore = new MarketStore();

    public static string FileName { get => fileName; set => fileName = value; }
    public static MarketStore MarketStore { get => marketstore; set => marketstore = value; }

    public static void LoadDataProducts(string nameFile)
    {
        using (StreamReader reader = new StreamReader(nameFile))
        {
            string json = reader.ReadToEnd();
            try{
                Env.MarketStore = System.Text.Json.JsonSerializer.Deserialize<MarketStore>(json, new System.Text.Json.JsonSerializerOptions(){PropertyNameCaseInsensitive = true})?? new MarketStore();
            }catch{

            }
        }
    }

    public static bool ValidateFile(string fileName)
    {
    if(!File.Exists(fileName)){
        return false;
    }
    return true;
    }

    public static void MarketData<T>(IEnumerable<T> list){
        foreach(var element in list){ //Recorre el JSON 
                Type typeClass = element.GetType();
                var propieties = typeClass.GetProperties();

                foreach(var property in propieties){
                    Console.Write($"{property.Name}: {property.GetValue(element)}");
                }

        }
        Console.ReadKey();
    }

}
    