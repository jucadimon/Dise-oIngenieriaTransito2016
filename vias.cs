using System.Linq; //Trabajar con listas, metodo Skip()
using System.Collections.Generic;//para exportar txt
using System.Text;//para exportar txt 
using System.Windows.Forms;//ventanas graficas
using System.Drawing;//ventanas graficas
using System.IO;//para exportar archivos y trabajar carpetas
using System;

class ProgramaVias
{
    // Tutorial online: http://www.nachocabanes.com/csharp/curso/csharp_indice.php
    // http://aprende-csharp.blogspot.com.co/2010/03/colecciones-list-arraylist.html
    // ruta del compilador:
    // PATH C:\Windows\Microsoft.NET\Framework\v4.0.30319;%PATH%
    // ruta de ubicacion del archivo a compilar:
    // cd C:\Users\usuario\Documents\vs code codigo fuente
    // Compilar con emsamvblado externo:
    // csc /out:TestCode.exe /reference:MathLibrary.DLL TestCode.cs
   
   //Exportar en windows:
        static StringBuilder comodin= new StringBuilder();
		static void ExportarRegistro()
		{
			string fecha = "";
            fecha=DateTime.Now.ToString();
			comodin.AppendLine("INGRESO: "+fecha+"\n");String cadena = "";
			cadena=comodin.ToString();
			FileStream fs = new FileStream("C:\\Users\\Usuario\\Documents\\salidavias.txt", FileMode.Append);
			fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
			fs.Close();
			Console.WriteLine("Registro correcto!");
		}
    //fin exportar. Tambien hay que invocar el metodo dentro del metodo Main
    
       
    static void Main()
    {
        ExportarRegistro();
        Console.Clear();
        Console.WriteLine("_________________________________2016_________________________________________\n");
        Console.WriteLine("__________________________TRANSITO Y TRANSPORTES______________________________\n");
        Console.WriteLine("______________________________________________________________________________\n");
        //empezamos:
        //Aforo(2,5);
        AforoL(4,15);
        //CrearFormularioOpaco();//mostramos las graficas en un formulario
        Console.ReadLine();
    }
    //mETODO QUE PIDE una opcion:
    public static void IngresarOpcion()
        {
            int opcion;
            List<string> _opciones = new List<string>();
            _opciones.Add("Si");
            _opciones.Add("No");
            _opciones.Add("Salir");
            Console.WriteLine("\nElija una opcion:");
            Console.Write("[1] SI ; [2] NO ; [3] SALIR");
            int.TryParse(Console.ReadLine(), out opcion);
			switch (opcion)
				{
					case 1:
						//instrucciones
						break;
					case 2:
						//instrucciones
						break;
					default:
						//instrucciones
						break;	
				}
        }
    //Metodo Aforo con Listas
    public static void AforoL(int TiempoEstudioHoras, int PeriodoConteoMinutos)
        {
            int _teh, _pcm, _rel, _rel1h, nro_sublistas, _Qmax=0, _totalVehMixtos=0;
            _teh = TiempoEstudioHoras;
            _pcm = PeriodoConteoMinutos;
            _rel = _teh*60/_pcm;//Numero de periodos del conteo o aforo
            _rel1h = 60/_pcm;//tamaño del subintervalo
            nro_sublistas = _rel - _rel1h + 1;//numrero de sublistas de peridos para hayar la suma
            
            List<int> Veh_mixtos = new List<int>();//Creamos una lista para los conteos x periodo y la inicializamos
            for (int i=0; i < _rel; i++)//Creamos unos datos aleatorios
                {
                    Veh_mixtos.Add((int)NumeroAleatorio(150,300));
                    System.Threading.Thread.Sleep(100);
                    if (_Qmax<Veh_mixtos[i])//buscamos el valor maximo
                        {
                            _Qmax=Veh_mixtos[i];
                        }
                    _totalVehMixtos+=Veh_mixtos[i];
                }

            Console.WriteLine("\t\tDATOS DEL AFORO:\n");
            Console.WriteLine("Tiempo de Realizacion del Aforo: "+_teh+"Horas.");
            Console.WriteLine("Periodo de conteo del Aforo cada: "+_pcm+"Minutos.\n");
            Console.WriteLine("N° Vehiculos por periodo de: "+_pcm+"Minutos.\n");
            foreach (var Vehiculos in Veh_mixtos)
                {
                    Console.Write(Vehiculos+" ");
                }
            Console.WriteLine("\n");
            Console.WriteLine("\t\tCALCULOS DEL AFORO:\n");
            Console.WriteLine("Total vehiculos mixtos del conteo: "+_totalVehMixtos+" Vehiculos mixtos.\n");
            Console.WriteLine("Vehiculos maximos durante el conteo: "+_Qmax+" Vehiculos mixtos\n");
            
            List<List<int>> Veh_mixtos_sublistas = new List<List<int>>();//creamos las sublistas
            for (int j=0; j < nro_sublistas; j++)//añadimos los datos a las sublistas
                {
                    Veh_mixtos_sublistas.Add( Veh_mixtos.Skip(j).Take(_rel1h).ToList() );
                }
            Console.WriteLine("\nN° Vehiculos por Subperiodos: ");
            int sum_sublist=0, max_sublist=0;
            foreach (var sub_list in Veh_mixtos_sublistas)
                {
                    sub_list.ForEach(imp);
                    sum_sublist = sub_list.Sum();//buscamos la suma de cada sublista
                    Console.WriteLine("= "+sum_sublist);//ponemos al final la suma total del sublist
                    if (max_sublist<sum_sublist)//buscamos el valor maximo
                        {
                            max_sublist=sum_sublist;
                        }
                }
            int VHMD = max_sublist;
            double FHMD;
            FHMD = (double)VHMD / ( _rel1h * _Qmax );
            
            Console.WriteLine("\nVHMD: "+VHMD+" Veh/h.");
            Console.WriteLine("\nFHMD = VHMD / ( intervalo horario * Qmax )");
            Console.WriteLine("FHMD = "+VHMD+" / ( "+_rel1h+" * "+_Qmax+" )");
            Console.WriteLine("\nFHMD = "+FHMD);
            
            //bucle for: Console.WriteLine (lista [i]);
        }
        //Metodo para mostrar en consola las sublistas:
        static void imp(int pos)
            {
                Console.Write(pos+" + ");
            }
    
    //metodo aforo, recibe dos parametros
    public static void Aforo(int TiempoEstudioHoras, int PeriodoConteoMinutos)
    {
        int teh, pcm;
        teh=TiempoEstudioHoras;
        pcm=PeriodoConteoMinutos;
        int rel; //definida
        rel=teh*60/pcm;
        //int tem
        //tem=teh*60;//convertimos el tiempo de estudio a minutos
        double[] periodos = new double[rel];//creamos un vector que alamcene los datos del aforo en cada
        //periodo de conteo durante el tiempo de estudio del aforo
        double Qmax=0, sump=0, totalVehMixtos=0;
        int rel1h;
        rel1h = 60/pcm;//numero de periodos a sumar para calcular el VHMD
        //double[] s = new double[rel1h];
        //double[] s1 = new double[rel1h];
        //double[] s2 = new double[rel1h];
        
        for (int i = 0; i < rel; i++)//agregamos una muestra aleatoria
            {
                periodos[i]=(int)NumeroAleatorio(150,300);//convertimos a entero porque los vehiculos son discretos
                if (Qmax<periodos[i])//buscamos el valor maximo
                {
                    Qmax=periodos[i];
                }
                System.Threading.Thread.Sleep(100);
                totalVehMixtos+=periodos[i];
                //s[i]=periodos[i+i];//sacar sublista de valores para sumarlas luego
                //s1[i]=periodos[i+i];
            }
        for (int i = 0; i < rel1h+1; i++)
            {
                double[] s = new double[rel1h];           
            }
        Console.WriteLine("");
        Console.WriteLine("\t\tDATOS DEL AFORO:\n");
        Console.WriteLine("Tiempo de Realizacion del Aforo: "+teh+"Horas.");
        Console.WriteLine("Periodo de conteo del Aforo cada: "+pcm+"Minutos.\n");
        
        for (int i = 0; i < rel; i++)//mostramos los datos del aforo
            {
                Console.WriteLine("N° vehiculos periodo {0} = {1} ",i+1,periodos[i]);
            }
        Console.WriteLine("\n");
        Console.WriteLine("\t\tCALCULOS DEL AFORO:\n");
        Console.WriteLine("Total vehiculos mixtos del conteo: "+totalVehMixtos+" Vehiculos mixtos.\n");
        Console.WriteLine("Vehiculos maximos durante el conteo: "+Qmax+" Vehiculos mixtos\n");
        int iter=0;
        double sum=0;
        
        do
        {
            sum+=periodos[iter];
            iter++;
        } while (iter<rel1h);
        Console.WriteLine("Suma 1er Qh: "+sum+" vehiculos mixtos");
        
        
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
    
    public static void CrearFormularioOpaco()
        {
        // Create a new form.
        Form form2 = new Form();
        // Set the text displayed in the caption.
        form2.Text = "Graficas Generadas";
        // Set the opacity to 60%.
        form2.Opacity = .90;
        // Size the form to be 300 pixels in height and width.
        form2.Size = new Size(500,400);
        form2.BackColor = Color.MintCream;//cambia color de fondo
        form2.ForeColor = Color.SlateBlue;//Cambia color de fuente
        // Display the form in the center of the screen.
        form2.StartPosition = FormStartPosition.CenterScreen;
        form2.WindowState = FormWindowState.Maximized;//Maximixamos la ventana
        // Create two buttons to use as the accept and cancel buttons.
        Button button1 = new Button ();
        // Set the text of button1 to "OK".
        button1.Text = "OK";
        // Set the position of the button on the form.
        button1.Location = new Point (10, 10);
        // Display a help button on the form.
        form2.HelpButton = true;
        // Define the border style of the form to a dialog box.
        form2.FormBorderStyle = FormBorderStyle.FixedDialog;//FixedDialog, None
        // Set the MaximizeBox to false to remove the maximize box.
        form2.MaximizeBox = true;
        // Set the MinimizeBox to false to remove the minimize box.
        form2.MinimizeBox = true;
        // Set the accept button of the form to button1.
        form2.AcceptButton = button1;
        // Add button1 to the form.
        form2.Controls.Add(button1);
        // Adds a label to the form.
	    Label label1 = new Label();
	    label1.Location = new Point(80,80);
	    label1.Name = "label1";
	    label1.Size = new Size(132,80);
	    label1.Text = "Ingenieria de transito y transportes";
	    
        form2.Controls.Add(label1);
        
        // Display the form as a modal dialog box.
         form2.ShowDialog();
        }
        //metodo para calcular el maximo entre dos numeros:
		static double maximo2(double a, double b)
		{
			double max;
			if(a>b)
			{
				max=a;
			}
			else
			{
				max=b;
			}
			return max;
		}
        //metodo para calcular el minimo entre dos numeros:
		static double minimo2(double a, double b)
		{
			double min;
			if(a>b)
			{
				min=b;
			}
			else
			{
				min=a;
			}
			return min;
		}
        //Metodo para buscar un maximo en una lista de valores tipo vector
        static double BuscarMaximo(double[] lista)
        {
            int tam=lista.Length;//creamos una variable con el tamaño de la matriz lista
            double[] periodosBase = new double[tam];//creamos un matriz de "rel" elementos
            double valorMaxLista=0;
            for (int i = 0; i < tam; i++)
            {
                periodosBase[i]=lista[i];
                if (valorMaxLista<periodosBase[i])//buscamos el valor maximo
                {
                    valorMaxLista=periodosBase[i];
                }
            }
            
            return valorMaxLista;
        }
}
