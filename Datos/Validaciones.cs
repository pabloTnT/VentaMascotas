using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace VentaMascotas
{
    public class Validaciones
    {

        public static String SolicitaNombreTienda()
        {
            String NombreTienda = "";
            bool ValidaNombre = false;
            while (!ValidaNombre)
            {
                Console.WriteLine("Ingrese Nombre de Tienda:");
                NombreTienda = Console.ReadLine();
                if (NombreTienda != null && NombreTienda != "")
                {
                    ValidaNombre = true;
                }
                else
                {
                    Console.WriteLine("Debe Ingresar el nombre de la tienda");
                }
            }
            return NombreTienda;
        }

        public static int SolicitaCantidadDisponible()
        {
            int CantDisponible = 0;
            bool ValidaCantDisponible = false;
            
            while (!ValidaCantDisponible)
            {
                Console.WriteLine("Cantidad de Mascotas disponibles:");
                while (!int.TryParse(Console.ReadLine(), out CantDisponible))
                {
                    Console.WriteLine("El valor ingresado no es valido");
                    Console.WriteLine("Cantidad de Mascotas disponibles:");
                }
                if (CantDisponible > 0)
                {
                    ValidaCantDisponible = true;
                }
                else
                {
                    ValidaCantDisponible = false;
                    Console.WriteLine("El valor debe ser mayor a 0");
                }
            }
            return CantDisponible;
        }

        public static int SolicitaCantidadVenta(Tienda Tienda)
        {
            int CantVenta = 0;
            bool ValidaCantVenta = false;
            
            while (!ValidaCantVenta)
            {
                Console.WriteLine("Cantidad de Mascotas a vender:");
                while (!int.TryParse(Console.ReadLine(), out CantVenta))
                {
                    Console.WriteLine("El valor ingresado no es valido");
                    Console.WriteLine("Cantidad de Mascotas a vender:");
                }
                if (CantVenta > 0 && CantVenta <= Tienda.CantidadMascotas)
                {
                    ValidaCantVenta = true;
                }else if (Tienda.CantidadMascotas == 0)
                {
                    Console.WriteLine("Ya no quedan Mascotas disponibles, se finaliza el sistema...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    ValidaCantVenta = false;
                    Console.WriteLine("El valor debe ser mayor a 0 e inferior a " + Tienda.CantidadMascotas);
                }
            }
            return CantVenta;
        }
        public static int SolicitaIdMascota()
        {
            int IdMascota;
            bool ValidaIdMascota = false;
            Console.WriteLine("Id de Mascota:");
            while(! int.TryParse(Console.ReadLine(), out IdMascota))
            {
                Console.WriteLine("El valor ingresado no es valido");
                Console.WriteLine("Id de Mascota:");
            }
            while (!ValidaIdMascota)
            {
                if (IdMascota != 0)
                {
                    ValidaIdMascota = true;
                }
                else
                {
                    ValidaIdMascota = false;
                    Console.WriteLine("El valor no puede ser 0");
                }
            }
            return IdMascota;
        }
        public static String SolicitaNombreMascota()
        {
            String NombreMascota = "";
            bool ValidaNombre = false;
            while (!ValidaNombre)
            {
                Console.WriteLine("Nombre de Mascota:");
                NombreMascota = Console.ReadLine();
                if (NombreMascota != null && NombreMascota != "")
                {
                    ValidaNombre = true;
                }
                else
                {
                    Console.WriteLine("El nombre no puede ser nulo");
                }
            }
            return NombreMascota;
            
        }

        public static String SolicitaRaza()
        {
            String Raza = "";
            bool ValidaRaza = false;
            while (!ValidaRaza)
            {
                Console.WriteLine("Raza:");
                Raza = Console.ReadLine();
                if (Raza != null && Raza != "")
                {
                    ValidaRaza = true;
                }
                else
                {
                    Console.WriteLine("La raza no puede ser nula");
                }
            }
            return Raza;
        }

        public static int SolicitaEdadMascota()
        {
            int Edad = 0;
            bool ValidaEdad = false;
            
            while (!ValidaEdad)
            {
                Console.WriteLine("Edad:");
                while (!int.TryParse(Console.ReadLine(), out Edad))
                {
                    Console.WriteLine("El valor ingresado no es valido");
                    Console.WriteLine("Edad:");
                }
                if (Edad > 0 && Edad < 30)
                {
                    ValidaEdad = true;
                }
                else
                {
                    ValidaEdad = false;
                    Console.WriteLine("El valor no puede ser 0");
                }
            }
            return Edad;

        }

        public static int SolicitaSexoMascota()
        {
            int Sexo = 0;
            bool ValidaSexo = false;
            Console.WriteLine("Sexo de Mascota (1:Macho/2:Hembra):");
           
            while (!ValidaSexo)
            {
                while (!int.TryParse(Console.ReadLine(), out Sexo))
                {
                    Console.WriteLine("El valor ingresado no es valido");
                    Console.WriteLine("Sexo de Mascota (1:Macho/2:Hembra):");
                }
                if (Sexo == 1 || Sexo == 2)
                {
                    ValidaSexo = true;
                }
                else
                {
                    ValidaSexo = false;
                    Console.WriteLine("El valor ingresado no es valido");
                }
            }
            return Sexo;
        }

        public static int SolicitaPrecioVenta()
        {
            int PrecioVenta = 0;
            bool ValidaPrecio = false;
            Console.WriteLine("Precio Venta:");
            
            while (!ValidaPrecio)
            {
                while (!int.TryParse(Console.ReadLine(), out PrecioVenta))
                {
                    Console.WriteLine("El valor ingresado no es valido");
                    Console.WriteLine("Precio Venta:");
                }
                if (PrecioVenta > 0)
                {
                    ValidaPrecio = true;
                }
                else
                {
                    ValidaPrecio = false;
                    Console.WriteLine("El valor ingresado debe ser mayor a 0");
                }
            }
            return PrecioVenta;

        }

        public static String SolicitaNombreComprador()
        {
            String NombreComprador = "";
            bool ValidaNombre = false;
            while (!ValidaNombre)
            {
                Console.WriteLine("Nombre Comprador:");
                NombreComprador = Console.ReadLine();
                if (NombreComprador != null && NombreComprador != "")
                {
                    ValidaNombre = true;
                }
                else
                {
                    Console.WriteLine("El nombre de comprador no puede ser nulo");
                }
            }
            return NombreComprador;

        }

        public static String SolicitaRutComprador()
        {
            String RutComprador = "";
            bool ValidaRut = false;
            while (!ValidaRut)
            {
                Console.WriteLine("Rut Comprador:");
                RutComprador = Console.ReadLine();
                if (RutComprador != null && RutComprador != "")
                {
                    ValidaRut = true;
                }
                else
                {
                    Console.WriteLine("El rut no puede ser nulo");
                }
            }
            return RutComprador;
        }
    }
}
