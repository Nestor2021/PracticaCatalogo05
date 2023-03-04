using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCatalogo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integrantes:
            // 1-  Marcos Alexi Vides Lopez
            // 2- Nestor Alexis Zamora Orellana

            //Declaracion de variables
            string codigo;
            string marca;
            string color;
            string talla;
            decimal precio;
           
            Console.WriteLine("-------Bienvenido-------");
            Console.WriteLine("-----Tienda de Ropa------");
            int x = 0;
            
            while(x == 0)
            {
               
                Tipo tipo = new Tipo();
                tipo.Mensaje();
                int opc =Convert.ToInt32( Console.ReadLine());
                Console.Clear();


                switch (opc)
                {
                    case 1:
                        
                        Console.WriteLine("Ingrese el codigo de la camisa: ");
                        codigo = Console.ReadLine();
                        tipo.talla();
                        talla = Console.ReadLine().Trim();
                        
                        if (talla == "1")
                        {
                            talla = "S";
                        }
                        else if (talla == "2")
                        {
                            talla = "M";
                        }
                        else if (talla == "3")
                        {
                            talla = "L";
                        }
                        else
                        {
                            Console.WriteLine("No existe");
                        }

                        tipo.Marca();
                         marca = Console.ReadLine().Trim();
                        if (marca == "1")
                        {

                            marca = "Nike";
                        }
                        else if (marca == "2")
                        {
                            marca = "Polo";
                        }
                        else if (marca == "3")
                        {
                            marca = "Adidas";
                        }
                        else
                        {
                            Console.WriteLine("No existe");
                        }
                        Console.WriteLine("Ingrese el color: ");
                        color = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio: ");
                        precio =Convert.ToDecimal( Console.ReadLine());

                        Camisa camisa = new Camisa(codigo, talla, marca, color, precio);
                        Console.WriteLine("|-----------------------------------Factura Detalle------------------------------------------------|");
                        Console.WriteLine("El codigo: " + codigo + " Talla: " + talla + " Marca: " + marca + " Color: " + color + " Precio: $ " + precio);
                        camisa.Mensaje();
                        
                        break;


                    case 2:
                      
                        Console.WriteLine("Ingrese el codigo del pantalon: ");
                        codigo = Console.ReadLine();
                        tipo.tallaPantalon();
                        talla = Console.ReadLine().Trim();

                        if (talla == "1")
                        {
                            talla = "28";
                        }
                        else if (talla == "2")
                        {
                            talla = "30";
                        }
                        else if (talla == "3")
                        {
                            talla = "32";
                        }
                        else
                        {
                            Console.WriteLine("No existe");
                        }

                        tipo.Marca();
                        marca = Console.ReadLine().Trim();
                        if (marca == "1")
                        {

                            marca = "Nike";
                        }
                        else if (marca == "2")
                        {
                            marca = "Polo";
                        }
                        else if (marca == "3")
                        {
                            marca = "Adidas";
                        }
                        else
                        {
                            Console.WriteLine("No existe");
                        }
                        Console.WriteLine("Ingrese el color: ");
                        color = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio: ");
                        precio = Convert.ToDecimal(Console.ReadLine());

                        Pantalon pantalon = new Pantalon(codigo, talla, marca, color, precio);
                        Console.WriteLine("|----------------------------------------------Factura Detalle-------------------------------------------------|");
                        Console.WriteLine("El codigo: " + codigo + " Talla: " + talla + " Marca: " + marca + " Color: " + color + " Precio: $ " + precio);
                        pantalon.Mensaje();
                        break;

                    case 3:
                      
                        Console.WriteLine("Ingrese el codigo de Ropa Interior: ");
                        codigo = Console.ReadLine();
                        tipo.talla();
                        talla = Console.ReadLine().Trim();
                       
                        if (talla == "1")
                        {
                            talla = "S";
                        }
                        else if (talla == "2")
                        {
                            talla = "M";
                        }
                        else if (talla == "3")
                        {
                            talla = "L";
                        }
                        else
                        {
                            Console.WriteLine("No existe");
                        }

                        tipo.Marca();
                        marca = Console.ReadLine().Trim();
                        if (marca == "1")
                        {

                            marca = "Nike";
                        }
                        else if (marca == "2")
                        {
                            marca = "Polo";
                        }
                        else if (marca == "3")
                        {
                            marca = "Adidas";
                        }
                        else
                        {
                            Console.WriteLine("No existe");
                        }
                        Console.WriteLine("Ingrese el color: ");
                        color = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio: ");
                        precio = Convert.ToDecimal(Console.ReadLine());

                        RopaInterior ropaInterior = new RopaInterior(codigo, talla, marca, color, precio);
                        Console.WriteLine("|----------------------------------------------Factura Detalle------------------------------------------------------|");
                        Console.WriteLine("El codigo: " + codigo + " Talla: " + talla + " Marca: " + marca + " Color: " + color + " Precio: $ " + precio);
                        ropaInterior.Mensaje();
                       
                        break;

                    case 4:

                        Environment.Exit(0);
                        break;

                }
            }
           

        }
    }
}
//Clase de abstraccion
abstract class Prenda
{
    private string codigo;
    private string talla;
    private string marca;
    private string color;
    private decimal precio;


    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Talla
    {
        get { return talla; }
        set { talla = value; }
    }
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    public decimal Precio
    {
        get { return precio; }
        set { precio = value; }
    }

}

class Camisa : Prenda
{
    //Constructor
    public Camisa(string codigo, string talla, string marca, string color, decimal precio)
    {
        Codigo = codigo;
        Talla = talla;
        Marca = marca;
        Color = color;
        Precio = precio;
    }

    public void Mensaje()
    {
        Console.WriteLine("Prenda: Camisa");
    }
}

class Pantalon : Prenda
{
    //Constructor
    public Pantalon(string codigo, string talla, string marca, string color, decimal precio)
    {
        Codigo = codigo;
        Talla = talla;
        Marca = marca;
        Color = color;
        Precio = precio;
    }

    public void Mensaje()
    {
        Console.WriteLine("Prenda: Pantalon");
    }

}

class RopaInterior : Prenda
{
    //Constructor
    public RopaInterior(string codigo, string talla, string marca, string color, decimal precio)
    {
        Codigo = codigo;
        Talla = talla;
        Marca = marca;
        Color = color;
        Precio = precio;
    }

    public void Mensaje()
    {
        Console.WriteLine("Prenda: Roa Interior");
    }
}

class Tipo
{
    public void Mensaje()
    {
        Console.WriteLine("---Tipo de Prenda--- \n" +
                          "1- Camisa \n" +
                          "2- Pantalon \n" +
                          "3- Ropa Interior \n" +
                          "4- Salir");
    }

    public void talla()
    {
        Console.WriteLine("---Talla--- \n" +
                          "1- S \n" +
                          "2- M \n" +
                          "3- L \n");
    }
    public void tallaPantalon()
    {
        Console.WriteLine("---Talla--- \n" +
                          "1- 28 \n" +
                          "2- 30 \n" +
                          "3- 32 \n");
    }

    public void Marca()
    {
        Console.WriteLine("---Marca--- \n" +
                         "1- Nike \n" +
                         "2- Polo \n" +
                         "3- Adidas \n");                       
    }
}


