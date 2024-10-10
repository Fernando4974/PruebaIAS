
using System;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;

class Program
{
    

int idProducto;
string nombreProducto;
string descripcionProducto;
double precioProducto;
int stockProducto;
int idCategoria;
object[] categorias={"ctgProductosHombre","ctgPreductosMujer"};

Object[] productos={idProducto,nombreProducto,descripcionProducto,precioProducto,stockProducto,idCategoria};



Console.WriteLine("Catalogo de PRODUCTOS");
Console.WriteLine("SELECIONE EN LA CATEGORIA QUE DESEA VISUALIZAR");
Console.WriteLine("Marque 1 para ");

for (int i = 0; i < categorias.Length; i++)
{
   
    Console.WriteLine($" marque {i} para {categorias[i]}");
}
int seleccionCategoria=int.Parse(Console.ReadLine());

switch (seleccionCategoria)
{
    case 0:
    Console.WriteLine(); 
    break;
    case 1:
    break;
    default:
    break;
}
}
class Conexion
{
   
    // public string server;
    // public string usuario;
    // public string bd;
    // public string host;
    // public string password;

    
    string connectionString = "Server=localhost;Database=catalogo;User Id=root;Password=123456789;";

}
