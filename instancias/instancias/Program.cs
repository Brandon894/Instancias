using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instancias
{
    class Program
    {
        static void Main(string[] args)
        {

            cajas nueva_caja = new cajas();
            nueva_caja.altura = " 40 cm ";
            nueva_caja.ancho = " 40 cm "; 
            nueva_caja.profundidad = " 20 cm ";
            nueva_caja.caja();


            cajas segunda_caja = new cajas();
            segunda_caja.altura = " 60 cm ";
            segunda_caja.ancho = " 55 cm ";
            segunda_caja.profundidad = " 30 cm ";
            segunda_caja.color = " Blanco ";
            segunda_caja.caja2();

            cajas tercera_caja = new cajas();
            Console.WriteLine();
            Console.Write("                        Tercera Caja           ");
            tercera_caja.altura = " 50 cm ";
            tercera_caja.ancho = " 45 cm ";
            tercera_caja.profundidad = " 20 cm ";
            tercera_caja.color = " Café ";
            tercera_caja.Tipo_de_material = " Cartón ";
            tercera_caja.estructura = " De solapas ";
            tercera_caja.empresa = " Sabritas ";
            tercera_caja.abertura = " Arriba ";
            Console.WriteLine();
            tercera_caja.caja3();
            
            cajas cuarta_caja = new cajas();
            Console.WriteLine();
            Console.Write("                        Cuarta Caja           ");
            cuarta_caja.altura = " 80 cm ";
            cuarta_caja.ancho = " 80 cm ";
            cuarta_caja.profundidad = " 50 cm ";
            cuarta_caja.color = " Azul ";
            cuarta_caja.Tipo_de_material = " Cartón ";
            cuarta_caja.estructura = " Con Tapadera ";
            cuarta_caja.empresa = " Paccsa ";
            cuarta_caja.abertura = " Arriba ";
            cuarta_caja.caja3();

        }
        public class cajas
        {
            public string color { get; set; }  
            public string  altura { get; set; } 
            public string ancho { get; set; }
            public string profundidad { get; set; }
            public string Tipo_de_material { get; set; }
            public string estructura { get; set; }
            public string empresa { get; set; }
            public string abertura { get; set; }

            public void caja()
            {
                Console.WriteLine();
                Console.WriteLine("                       Primera Caja             ");
                Console.WriteLine(" Altura: "+altura+ " Ancho: "+ancho+ " Profunidad: "+profundidad);
                Console.ReadKey();
            }
            public void caja2()
            {
                Console.WriteLine();
                Console.WriteLine("                       Segunda Caja            ");
                Console.WriteLine(" Altura: " + altura + " Ancho: " + ancho + " Profunidad: " + profundidad+ " Color: " +color);
                Console.ReadKey();
            }
            public void caja3()
            {
                Console.WriteLine();                
                Console.WriteLine(" Altura: " + altura + " Ancho: " + ancho + " Profunidad: " + profundidad + " Color: " + color+ " Tipo de Material: " + Tipo_de_material+ " Estructura: "+estructura+" Empresa: "+ empresa+" Se abre: "+abertura);
                Console.ReadKey();
            }
           
        }
    }
}
