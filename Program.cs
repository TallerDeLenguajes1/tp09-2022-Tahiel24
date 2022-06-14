using System.Text.Json;
List<Producto> ListaProductos = new List<Producto>();
Random r = new Random();
int cant = r.Next(0, 6);

for (int i = 0; i < cant; i++)
{
    Producto productoNuevo = new Producto();
    ListaProductos.Add(productoNuevo);
}

File.WriteAllText("producto.json", JsonSerializer.Serialize(ListaProductos));

string fileName = "producto.json";
string jsonString2 = File.ReadAllText(fileName);

ListaProductos = JsonSerializer.Deserialize<List<Producto>>(jsonString2);
