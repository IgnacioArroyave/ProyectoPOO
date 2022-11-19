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
  private string Nombre;
  publilc string nombre 
  {
    get
    {
      return Nombre;
    }
    private set {Nombre = value;}
  }
  public float getEficiencia (string nombre)
  {
    foreach (producto prod in productos)
    {
      if (nombre == prod.nombre)
        return prod.eficiencia;
    }
    return 0;
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
  private string Nombre;
  public string nombre
  {
    get
    {
      return Nombre;
    }
    private set {Nombre = value;}
  }
}
