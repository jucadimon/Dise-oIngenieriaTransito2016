using System;
using System.IO;//para manejar archivos
using System.Collections.Generic;//para exportar
using System.Text;//para exportar
namespace TransitoYtransporte
{
    public class velocidades
    {
        // Tutorial online: http://www.nachocabanes.com/csharp/curso/csharp_indice.php
        // ruta del compilador:
        // PATH C:\Windows\Microsoft.NET\Framework\v4.0.30319;%PATH%
        // ruta de ubicacion del archivo a compilar:
        // cd C:\Users\usuario\Documents\vs code codigo fuente
        
        // CONTROL DE ACCESO -inicio
        static StringBuilder registro= new StringBuilder();//Definimos un comodin estatico
        static string fecha="";
        public static void RegistrarAcceso()
        {
            fecha=DateTime.Now.ToString();//pedimos la hora al sistema y almacenamos en fecha
			registro.AppendLine("INGRESO: "+fecha+"\n");//añadimos la fecha al comodin
			String reg = "";//creamos un objeto tipo String del espacio de nombres Text
			reg=registro.ToString();//convertimos el comodin a texto
            //Creamos el escritor de archivos y damos la ruta, nombre del archivo y modo de creado
			FileStream registroA = new FileStream("C:\\Users\\"+Environment.UserName+
            "\\Documents\\registro.txt", FileMode.Append);
			// linux: FileStream registroA = new FileStream("/home/juan/Desktop/Registro.txt", FileMode.Append);
            registroA.Write(ASCIIEncoding.ASCII.GetBytes(reg), 0, reg.Length);//escribimos dentro del archivo
			registroA.Close();//Cerra el archivo creado
        }               
        // CONTROL DE ACCESO -fin
        
        //          Declare variables globales aqui -inicio
        
        //          variables globales -fin
        
        public static void Main()
        {
            RegistrarAcceso();//Crea un archivo que regista la fecha y hora de acceso al programa
            PersonalizarConsola();//personaliza los temas de la consola
            Console.WriteLine("Directorio actual: {0}", Environment.CurrentDirectory);
            System.Threading.Thread.Sleep(100); //añadimos esta linea para pausar por "n" miliegundos y asi tener
            // mas aletoriedad en el resultado y mas tiempo de espera.
            
        }
        
        //          Declare metodos personalizados -inicio
        public static void PersonalizarConsola()
        {
            //Console.SetWindowSize(100,50);//poner tamaño ventana consola
            Console.Title = "Programa Transito y Transporte";
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
        }
        public static double NumeroAleatorio(int minimo, int maximo)
        {
            //variables del rango
            int min, max;
            double aleatorio;
            min=minimo;
            max=maximo;
            //Clase para Numeros aleatorios:
            Random r = new Random(DateTime.Now.Millisecond);
            //ponemos el rango:
            aleatorio = r.Next(min,max);
            if (min==0&max==1)
                {
                    //metodo para numeros entre 0 y 1
                    aleatorio = r.NextDouble();
                }        
            return aleatorio;
        }
        //          metodos personalizados -fin
        
        //          Declare structs personalizadas -inicio
        
        //          structs personalizadas -fin
    }
}
 