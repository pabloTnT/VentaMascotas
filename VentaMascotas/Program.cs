using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace VentaMascotas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool StCiclo = true;
            Tienda Tienda = new Tienda();
            Tienda.NombreTienda = Validaciones.SolicitaNombreTienda();
            Tienda.CantidadMascotas = Validaciones.SolicitaCantidadDisponible();

            while (StCiclo)
            {
                List<Mascota> Mascotas = new List<Mascota>();
                int CantidadVenta = Validaciones.SolicitaCantidadVenta(Tienda);
                int Contador = 0;
                while (Contador < CantidadVenta)
                {
                    int NumeroMascota = Contador + 1;
                    Mascota RegistroMascota = new Mascota();
                    Console.WriteLine("Ingrese datos de mascota N°" + NumeroMascota);
                    int IdMascota = Validaciones.SolicitaIdMascota();
                    RegistroMascota.Id = IdMascota;
                    String NombreMascota = Validaciones.SolicitaNombreMascota();
                    RegistroMascota.NombreMascota = NombreMascota;
                    String RazaMascota = Validaciones.SolicitaRaza();
                    RegistroMascota.Raza = RazaMascota;
                    int EdadMascota = Validaciones.SolicitaEdadMascota();
                    RegistroMascota.Edad = EdadMascota;
                    int SexoMascota = Validaciones.SolicitaSexoMascota();
                    RegistroMascota.Sexo = SexoMascota;
                    int PrecioVenta = Validaciones.SolicitaPrecioVenta();
                    RegistroMascota.PrecioVenta = PrecioVenta;
                    String NombreComprador = Validaciones.SolicitaNombreComprador();
                    RegistroMascota.NombreComprador = NombreComprador;
                    String RutComprador = Validaciones.SolicitaRutComprador();
                    RegistroMascota.RutComprador = RutComprador;
                    Mascotas.Add(RegistroMascota);
                    Contador++;
                    Tienda.CantidadMascotas--;
                }


                Calculos.CalculoValoresVenta(Mascotas);
                Console.WriteLine("Desea visualizar el detalle de la compra? (1:SI/2:NO)");
                String RespDetalle = Console.ReadLine();
                if (RespDetalle.Equals("1"))
                {
                    foreach (var item in Mascotas)
                    {
                        Console.WriteLine("---Detalle de Venta---");
                        Console.WriteLine("Id Mascota: " + item.Id);
                        Console.WriteLine("Nombre Mascota: " + item.NombreMascota);
                        Console.WriteLine("Raza: " + item.Raza);
                        Console.WriteLine("Edad: " + item.Edad);
                        Console.WriteLine("Sexo: " + item.Sexo);
                        Console.WriteLine("Precio Venta: " + item.PrecioVenta);
                        Console.WriteLine("Nombre Comprador: " + item.NombreComprador);
                        Console.WriteLine("Rut Comprador: " + item.RutComprador);
                        Console.WriteLine("----***----");
                    }
                }
                Console.WriteLine("Desea realizar otra venta? (1:SI/2:NO)");
                int RespCiclo = int.Parse(Console.ReadLine());
                if (RespCiclo == 1)
                {
                    StCiclo = true;
                }
                else if (RespCiclo == 2)
                {
                    StCiclo = false;
                    Console.WriteLine("Adios..");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Opcion no valida, se finaliza el sistema");
                    StCiclo = false;
                }
            }
        }

    }
}
