//para exportar
using System.Collections.Generic;
using System.Text;

using System.IO;
using System;

class ProgramaVias
{
    // Tutorial online: http://www.nachocabanes.com/csharp/curso/csharp_indice.php
    // ruta del compilador:
    // PATH C:\Windows\Microsoft.NET\Framework\v4.0.30319;%PATH%
    // ruta de ubicacion del archivo a compilar:
    // cd C:\Users\usuario\Documents\vs code codigo fuente
   
   //Exportar en windows:
        static StringBuilder comodin= new StringBuilder();
		static void Exportar()
		{
			String cadena = "";
			cadena=comodin.ToString();
			FileStream fs = new FileStream("C:\\Users\\Usuario\\Documents\\salida.txt", FileMode.Append);
			fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
			fs.Close();
			Console.WriteLine("Exportacion correcta!");
		}
    //fin exportar. Tambien hay que invocar el metodo dentro del metodo Main


    public struct punto3D
    {
        public double x, y, z;
        public punto3D(double x1, double y1, double z1)
        {
            x=x1;
            y=y1;
            z=z1;
        }
    }
    
    public struct punto2D
    {
        public double x, y;
        public punto2D(double x1, double y1)
        {
            x=x1;
            y=y1;
        }
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
    
    static void Main()
    {
        Console.WriteLine("_________________________________2016_________________________________________\n");
        Console.WriteLine("__________________________TRANSITO Y TRANSPORTES______________________________\n");
        Console.WriteLine("______________________________________________________________________________\n");
        
       
        // 
        double numal;
        numal=NumeroAleatorio(0,11);
        Console.WriteLine("aleatorio:" + numal+"\n");
        //
        for (int i = 1; i <= 5; i++)
        {
            //mostar un punto2D
        punto2D punto = new punto2D(Math.Round(NumeroAleatorio(0,1)+NumeroAleatorio(1,10),3),NumeroAleatorio(0,1));
        Console.WriteLine("Punto2D ({0}) => x{1}: "+punto.x+" y{2}: "+punto.y,i,i,i);
        comodin.AppendLine("Punto2D ({"+i+"}) => x{"+i+"}: "+punto.x+" y{"+i+"}: "+punto.y);
        System.Threading.Thread.Sleep(100); //añadimos esta linea para pausar por "n" miliegundos y asi tener
        // mas aletoriedad en el resultado.
        }
        Console.WriteLine("\n");
            //mostar un punto2D
        punto2D p1 = new punto2D(NumeroAleatorio(1,10),Math.Round(NumeroAleatorio(0,1)+NumeroAleatorio(10,20),3));
        Console.WriteLine("mi punto2D => x: "+p1.x+" y: "+p1.y+"\n");
        Console.WriteLine("\n");
        //
        for (int i = 1; i <= 15; i++)
        {
            //mostar un punto3D
        punto3D punto = new punto3D(Math.Round(NumeroAleatorio(0,1)+NumeroAleatorio(0,15),3),Math.Round(NumeroAleatorio(0,1)+NumeroAleatorio(0,100),3),Math.Round(NumeroAleatorio(0,1)+NumeroAleatorio(0,900),3));
        Console.WriteLine("Punto3D ({0}) => x{1}: "+punto.x+" y{2}: "+punto.y+" z{3}: "+punto.z,i,i,i,i);
        System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine("\n");
        //agregar lineas al documento de exportacion:
        comodin.AppendLine("puntos 2D:");
        comodin.AppendLine("\n");
        comodin.AppendLine("mi punto2D => x: "+p1.x+" y: "+p1.y+"\n");
        Exportar();
        //informacion que da el sistema:
        Console.WriteLine("Nombre de usuario: {0}", Environment.UserName);
        Console.WriteLine("Directorio actual: {0}", Environment.CurrentDirectory);
        
        //empezamos:
        int teh=2, pcm=5;//damos valores iniciales
        int rel;
        rel=(teh*60/pcm);
        double[] periodos = new double[rel];//creamos un vector que alamcene los datos del aforo en cada
        //periodo de conteo durante el tiempo de estudio del aforo
        
        for (int i = 0; i < rel; i++)//agregamos una muestra aleatoria
        {
            periodos[i]=NumeroAleatorio(150,300);
            System.Threading.Thread.Sleep(100);
        }
        
        for (int i = 0; i < rel; i++)//mostramos los datos del aforo
        {
            Console.WriteLine("N° vehiculos periodo {0} = {1}",i+1,periodos[i]);
        }
        
        Console.ReadLine();
    }
    
    //metodo aforo, recibe dos parametros
    public static void Aforo(int TiempoEstudioHoras, int PeriodoConteoMinutos)
    {
        int teh, pcm;
        teh=TiempoEstudioHoras;
        pcm=PeriodoConteoMinutos;
        int rel;
        rel=teh*60/pcm;
        //int tem
        //tem=teh*60;//convertimos el tiempo de estudio a minutos
        double[] periodos = new double[rel];//creamos un vector que alamcene los datos del aforo en cada
        //periodo de conteo durante el tiempo de estudio del aforo
        
        for (int i = 0; i < rel; i++)//agregamos una muestra aleatoria
        {
            periodos[i]=(int)NumeroAleatorio(150,300);
            System.Threading.Thread.Sleep(100);
        }
        
        for (int i = 0; i < rel; i++)//mostramos los datos del aforo
        {
            Console.WriteLine("N° vehiculos periodo {0} = {1}",i+1,periodos[i]);
        }
        
    }
}
