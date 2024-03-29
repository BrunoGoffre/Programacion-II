using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  public class Figura : Producto
  {
    double altura;

    public Figura(string descripcion, int stock, double precio, double altura) : base(descripcion,stock,precio)
    {
      this.altura = altura;
    }
    public Figura (int stock, double precio, double altura) : this ($"Figura {altura} cm",stock,precio,altura)
    {

    }    
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat($"Altura: {this.altura}\n{base.ToString()}");
      return sb.ToString();
    }
  }
}
