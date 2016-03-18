using System;
using System.Linq; //Trabajar con listas, metodo Skip()
using System.IO;//para manejar archivos
using System.Collections.Generic;//para exportar
using System.Text;//para exportar
using System.Windows.Forms;//ventanas graficas
using System.Drawing;//ventanas graficas
namespace EspacioNombres
{
    public class clasePersonalizada
    {
        // Tutorial online: http://www.nachocabanes.com/csharp/curso/csharp_indice.php
        // ruta del compilador:
        // PATH C:\Windows\Microsoft.NET\Framework\v4.0.30319;%PATH%
        // ruta de ubicacion del archivo a compilar:
        // cd C:\Users\usuario\Documents\vs code codigo fuente
        // Compilar con emsamvblado externo:
        // csc /out:TestCode.exe /reference:MathLibrary.DLL TestCode.cs
        
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
        
        //      Declare objetos personalizadas -inicio
        
        //      objetos personalizadas -fin
        
        //      Declare variables globales aqui -inicio
        
        //      variables globales -fin
        
        public static void Main()
        {
            RegistrarAcceso();//Crea un archivo que regista la fecha y hora de acceso al programa
            PersonalizarConsola();//personaliza los temas de la consola
            Console.WriteLine("Directorio actual: {0}", Environment.CurrentDirectory);
            System.Threading.Thread.Sleep(100); //añadimos esta linea para pausar por "n" miliegundos y asi tener
            // mas aletoriedad en el resultado y mas tiempo de espera.
            //CrearFormularioOpaco();//Creamos un formulario opaco
            Console.ReadLine();
        }
        
        //      Declare metodos personalizados -inicio
        public static void CrearFormularioOpaco()
        {
        // Crear un nuevo formulario tipo ventana.
        Form form2 = new Form();
        // Establecer el titulo de formulario
        form2.Text = "Graficas Generadas";
        // Establecer la propiedad opacity to 60%.
        form2.Opacity = .75;
        // (pixels) in height and width.Establecer el tamaño del formulario
        form2.Size = new Size(500,400);
        form2.BackColor = Color.Black;//cambia color de fondo
        form2.ForeColor = Color.MediumOrchid;//cambia color de la fuente
        // Ubica el formulario en el centro de la pantalla.
        form2.StartPosition = FormStartPosition.CenterScreen;
        
        // Crea un boton, uno aceptar
        Button button1 = new Button ();
        // Establece el texto del boton en "ok"
        button1.Text = "OK";
        // Establece el boton creado como aceptar
        form2.AcceptButton = button1;
        // Ubica el boton en las coordenadas del formulario.
        button1.Location = new Point (10, 10);
        // Muestra el boton de ayuda
        form2.HelpButton = true;
        // Define el tipo o estilo de borde del formulario
        form2.FormBorderStyle = FormBorderStyle.FixedDialog;//FixedDialog, None
        // Set the MaximizeBox to false to remove the maximize box.Hace visible el boton maximizar
        form2.MaximizeBox = true;
        // Set the MinimizeBox to false to remove the minimize box.Hace visible el boton minimizar
        form2.MinimizeBox = true;
        
        // Añadir el boton creado anteriormente en el formulario
        form2.Controls.Add(button1);
        // Crear y añadir un Label al formulario y establecer su posicion en el formulario
	    Label label1 = new Label();//Crear el label
	    label1.Location = new Point(80,80);//localizacion del label en el formulario
	    label1.Name = "label1";//Nombre del label como tal
	    label1.Size = new Size(132,80);//Tamaño del label
	    label1.Text = "Ingenieria de transito y transportes";//lo que muestra el label al usuario
	    
        form2.Controls.Add(label1);//Añadimos el label al formulario
        
        // Muestra el formulario tipo ventana
         form2.ShowDialog();
        }
        //
        public static void PersonalizarConsola()
        {
            //Console.SetWindowSize(100,50);//poner tamaño ventana consola
            Console.Title = "Programa X";
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
        }
        public static double NumeroAleatorio(int minimo, int maximo)
        {
            //variables del rango
            int min, max;
            double aleatorio;//numero aleatorio que sale
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
        //      metodos personalizados -fin
        
        
    }
}
 