public class fabricante
{
  public fabricante (float Factor_, string Nombre_, List<producto> Productos)
  {
    factor = Factor_;
    nombre = Nombre_;
    productos = Productos_;
  }
  public List<producto> productos;
  private float Factor;
  public float factor
  {
    get
    {
      return Factor;
    }
    private set {Factor = value;}
  }
}
public class producto
{
  public producto (string Nombre, float Eficiencia)
  {
    eficineca = Eficiencia:
    nombre = Nombre;
  }
  private float Eficiencia;
  public float eficiencia
  {
    get
    {
      return Eficiencia;
    }
    private set {Eficiencia = value;}
  }
}
