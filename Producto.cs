public class Producto{
    private string nombre;
    private DateTime fechavencimiento;
    private float precio;
    string tamanio;

    public string Nombre { get => nombre; set => nombre = value; }
    public DateTime Fechavencimiento { get => fechavencimiento; set => fechavencimiento = value; }
    public float Precio { get => precio; set => precio = value; }
    public string Tamanio { get => tamanio; set => tamanio = value; }

    public Producto(){
        string[]nombres={"La Serenisima", "Milkout", "Zucoa", "Zucaritas","Danica"};
        string[]tamanios={"Pequeño", "Estandar", "Grande"};
        string[]fechas={"23/08/2022", "12/09/2023", "30/01/2024"};
        Random r=new Random();

        Nombre=nombres[r.Next(0,5)];
        Fechavencimiento=Convert.ToDateTime(fechas[r.Next(0,3)]);
        Tamanio=tamanios[r.Next(0,3)];
        Precio=r.Next(1000,5001);
    }
}
