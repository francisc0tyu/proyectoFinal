using System;

class Proyecto
{
    static void Main()
    {

        Console.Write("Bienvenido, ingrese su nombre por favor: ");
        string usuario = Console.ReadLine();


        Console.Write("Bienvenido, ingrese su edad por favor: ");
        string Edad = Console.ReadLine();

        Console.WriteLine($"Bienvenido {usuario} al programa de la tienda de Miguel :* ");

        List<string> listaProductos = new List<string>();
        List<double> listaPrecios = new List<double>();

        int opcPrincipal;
        do
        {

            Console.WriteLine("--------------MENU------------");
            Console.WriteLine("Seleccione la categoría que le gustaría comprar :( ");
            Console.WriteLine("1. Electronica");
            Console.WriteLine("2. Alimentoos");
            Console.WriteLine("3. Fresco");
            Console.WriteLine("3. Salir");
            Console.Write("Ingrese su opción: ");
            opcPrincipal = int.Parse(Console.ReadLine());

            switch (opcPrincipal)
            {
                case 1:

                    int opcionElectronica;
                    do
                    {
                        Console.WriteLine("Bienvenido a la Categoría de Electrónica");
                        Console.WriteLine("1. Laptop hp lps 1000");
                        Console.WriteLine("2. Smartphone lps  700");
                        Console.WriteLine("3. Audífonos lps 150");
                        Console.WriteLine("4. Regresar al menú principal");
                        Console.Write("Seleccione un producto: ");
                        opcionElectronica = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (opcionElectronica)
                        {
                            case 1:
                                precio = 1000;
                                impuesto = 0.18;
                                break;
                            case 2:
                                precio = 700;
                                impuesto = 0.15;
                                break;
                            case 3:
                                precio = 150;
                                impuesto = 0.10;
                                break;
                            case 4:

                                Console.WriteLine("Regresando al menu principal...");
                                break;
                            default:
                                Console.WriteLine("Opcion no valida por favor intente de nuevo");
                                continue;
                        }

                        if (opcionElectronica >= 1 && opcionElectronica <= 3)
                        {
                            Console.Write("Ingrese la cantidad que desea comprar (máximo 100): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 100)
                            {
                                Console.WriteLine("La cantidad no puede superar 100. Intente de nuevo.");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;


                            listaProductos.Add($"{(opcionElectronica == 1 ? "Laptop" : opcionElectronica == 2 ? "Smartphone" : "Audífonos")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: lps {precioConImpuesto}");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: lps {precioFinal}");


                            Console.Write("¿Desea seguir comprando? Si o no: ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "si")
                            {
                                Console.WriteLine("Generando factura final...");
                                FacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (opcionElectronica != 4);
                    break;

                case 2:

                    int opcionAlimentos;
                    do
                    {
                        Console.WriteLine("Categoría: Alimentos");
                        Console.WriteLine("1. Pan -  lps 2");
                        Console.WriteLine("2. Leche - lps 15");
                        Console.WriteLine("3. 1 cartonde huevos -lps 3");
                        Console.WriteLine("4. Regresar al menú principal");
                        Console.Write("Seleccione un producto: ");
                        opcionAlimentos = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (opcionAlimentos)
                        {
                            case 1:
                                precio = 2;
                                impuesto = 0.00;
                                break;
                            case 2:
                                precio = 1.5;
                                impuesto = 0.0;
                                break;
                            case 3:
                                precio = 3;
                                impuesto = 0.00;
                                break;
                            case 4:

                                Console.WriteLine("Regresando al menú principal...");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                                continue;
                        }

                        if (opcionAlimentos >= 1 && opcionAlimentos <= 3)
                        {
                            Console.Write("Ingrese la cantidad que desea comprar (máximo 100): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 100)
                            {
                                Console.WriteLine("La cantidad no puede superar 100. Intente de nuevo.");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;

                            listaProductos.Add($"{(opcionAlimentos == 1 ? "Pan" : opcionAlimentos == 2 ? "Leche" : "Huevos")} x{cantidad}");
                            listaPrecios.Add(precioFinal);
                            Console.WriteLine($" El impuesto es del  {impuesto} por ciento");
                            Console.WriteLine($"Precio por unidad con impuesto: lps {precioConImpuesto}");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: lps{precioFinal}");

                            Console.Write("¿Desea seguir comprando? Si o no: ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "si")
                            {
                                Console.WriteLine("Generando factura final...");
                                FacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (opcionAlimentos != 4);
                    break;

                case 3:

                    int opcionFrescos;
                    do
                    {
                        Console.WriteLine("Bienvenido a la Categoría de Frescos");
                        Console.WriteLine("1. Coca Cola Portatil 22 lps");
                        Console.WriteLine("2. Fresca 25 lps ");
                        Console.WriteLine("3. Link Banana 20 lps ");
                        Console.WriteLine("4. Regresar al menú principal");
                        Console.Write("Seleccione un producto: ");
                        opcionFrescos = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (opcionFrescos)
                        {
                            case 1:
                                precio = 22;
                                impuesto = 0.18;
                                break;
                            case 2:
                                precio = 25;
                                impuesto = 0.05;
                                break;
                            case 3:
                                precio = 20;
                                impuesto = 0.6;
                                break;
                            case 4:

                                Console.WriteLine("Regresando al menú principal...");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                                continue;
                        }

                        if (opcionFrescos >= 1 && opcionFrescos <= 3)
                        {
                            Console.Write("Ingrese la cantidad que desea comprar (máximo 100): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 100)
                            {
                                Console.WriteLine("La cantidad no puede superar 100. Intente de nuevo.");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;


                            listaProductos.Add($"{(opcionFrescos == 1 ? "Laptop" : opcionFrescos == 2 ? "Smartphone" : opcionFrescos == 3 ? "Audífonos " : "maricas")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: lps {precioConImpuesto}");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: lps {precioFinal}");


                            Console.Write("Desea seguir comprando Si o no: ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "si")
                            {
                                Console.WriteLine("Generando factura final...");
                                FacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (opcionFrescos != 4);
                    break;

                case 4:

                    Console.WriteLine("Generando factura final...");
                    FacturaFinal(listaProductos, listaPrecios);
                    break;

                default:

                    Console.WriteLine("Opción inválida, por favor intente de nuevo.");
                    break;
            }

        } while (opcPrincipal != 3);


        double CalcularDescuento(int cantidad)
        {
            if (cantidad >= 50)
            {
                return 0.15;
            }
            else if (cantidad >= 20)
            {
                return 0.10;
            }
            else if (cantidad >= 10)
            {
                return 0.05;
            }
            else
            {
                return 0;
            }
        }


        void FacturaFinal(List<string> listaProductos, List<double> listaPrecios)
        {

            double total = 0;

            for (int i = 0; i < listaProductos.Count; i++)
            {
                Console.WriteLine($"{listaProductos[i]} - ${listaPrecios[i]}");
                total += listaPrecios[i];
            }

            Console.WriteLine($"----------------------------------");
            Console.WriteLine($"Cantidad final : ${total} gracias por su compra");

        }

    }
}