using System;
using System.Media;//pareproducir archivos de audio
  using System.Linq; //Trabajar con listas, metodo Skip()
  using System.Collections.Generic;//para exportar txt
  using System.Text;//para exportar txt
  using System.Drawing;//ventanas graficas
  using System.IO;//para exportar archivos y trabajar carpetas
  using System.Collections;
  using System.ComponentModel;
  using System.Windows.Forms;
  using System.Data;
  
  public class BotonCircular : UserControl
{
    //Dibujar el boton
    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics graphics = e.Graphics;
        Pen miLapiz = new Pen(Color.MediumOrchid, 2);
        // Dibujar el boton en el formulario con forma circular
        graphics.DrawEllipse(miLapiz, 0, 0, 30, 30);
        miLapiz.Dispose();
    }
}

  public class FormularioOpaco : Form
  {
    private Button button1;////////////////////Crear el boton
    private Button bsalir;
    private BotonCircular botonc;//Crear el boton
    public Label label1, labeltitulo; //Crear el label
    public TextBox TextBox1;//Creamos el textbox
    
    public string comodinstring="";
    public StringBuilder comodin = new StringBuilder();
    // private System.Windows.Forms.Button btnFlat;

    // Variables a nivel de todo el programa
    // int variable = 0;
    
    public FormularioOpaco()
    {
      InitializeComponent();
      CenterToScreen();
      //FormularioOpaco.CancelButton = bsalir;
    }
    private void InitializeComponent()
    {
      
      // this.btnFlat = new System.Windows.Forms.Button();
      this.button1 = new Button();//////////////////// Inicializar el boton
      this.bsalir = new Button();
      this.label1 = new Label(); //inicializar el label
      this.labeltitulo = new Label(); 
      this.TextBox1 = new TextBox();//iniciamos el textbox
      this.botonc = new BotonCircular();// Inicializar el boton
      
      //// NPI
      this.SuspendLayout();
      
      // 
      // botonc
      // 
      this.botonc.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);/////////////////
      this.botonc.Location = new Point(800, 200);////////////////////
      this.botonc.Click += new EventHandler(this.botonc_Click);
      // 
      // button1
      // 
      this.button1.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);/////////////////
      this.button1.Location = new Point(10, 10);////////////////////
      this.button1.Name = "button1";////////////////////
      this.button1.Size = new System.Drawing.Size(120, 25);////////////////////
      this.button1.Text = "CALCULAR AFORO";////////////////////
      this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;////////////////////
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Click += new EventHandler(this.button1_Click);
      // 
      // bsalir
      // 
      this.bsalir.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);/////////////////
      this.bsalir.Location = new Point(945, 10);////////////////////
      this.bsalir.Name = "button1";////////////////////
      this.bsalir.Size = new System.Drawing.Size(45, 25);////////////////////
      this.bsalir.Text = "SALIR";////////////////////
      this.bsalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;/////////MiddleCenter/TopCenter//////////
      this.bsalir.FlatStyle = FlatStyle.Flat;
      this.bsalir.Click += new EventHandler(this.bsalir_Click);
      // 
      // Label1
      //
	  this.label1.Location = new Point(button1.Left, button1.Height + button1.Top + 10);//localizacion del label en el formulario
	  this.label1.Name = "label1";//Nombre del label como tal
	  this.label1.Font = new Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
      this.label1.Size = new Size(600,700);//Tamaño del label 600/700
	  this.label1.Text = "y";//lo que muestra el label al usuario
      // 
      // Labeltitulo
      //
      this.labeltitulo.Size = new Size(600,25);//Tamaño del label
	  this.labeltitulo.Location = new Point(550 - (labeltitulo.Width / 2),10);//localizacion del label en el formulario
	  this.labeltitulo.Name = "labeltitulo";//Nombre del label como tal
	  this.labeltitulo.Font = new Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
      this.labeltitulo.Text = "INGENIERA DE TRANSITO Y TRANSPORTES 2016";//lo que muestra el label al usuario
      // 
      // TextBox
      //
      this.TextBox1.Location = new Point(button1.Left + 610, button1.Height + button1.Top + 10);
      this.TextBox1.Size = new Size(50,30);
      this.TextBox1.Text = "";
      // 
      // FormularioOpaco ////////////////////
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(1000, 600);
      this.Opacity = .85;
      this.BackColor = Color.MintCream;//cambia color de fondo, Black, MintCream, MediumOrchid, 
      this.ForeColor = Color.MediumOrchid;//cambia color de la fuente SlateBlue
      // Define el tipo o estilo de borde del formulario
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//FixedDialog, None, Fixed3D
      this.Name = "FormularioOpaco";
      this.Text = "PROGRAMA VENTANA GRAFICA 1.1.0";
      this.CancelButton = bsalir;
      // 
      // Añadir los botones, label, picturebox al FormularioOpaco ////////////////////
      // 
      this.Controls.Add(this.button1);////////////////////
      this.Controls.Add(this.bsalir);
      this.Controls.Add(this.label1);////////////////////
      this.Controls.Add(this.labeltitulo);
      this.Controls.Add(this.TextBox1);
      this.Controls.Add(this.botonc);
      
      /// NPI
      this.ResumeLayout(false);

    }
    ////////////////////////////////
    //Metodo Aforo con Listas
    public void AforoL(int TiempoEstudioHoras, int PeriodoConteoMinutos)
        {
            int _teh, _pcm, _rel, _rel1h, nro_sublistas, _Qmax=0, _totalVehMixtos=0;
            _teh = TiempoEstudioHoras;
            _pcm = PeriodoConteoMinutos;
            _rel = _teh*60/_pcm;//Numero de periodos del conteo o aforo
            _rel1h = 60/_pcm;//tamaño del subintervalo, 
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

            comodin.AppendLine("\t\tDATOS DEL AFORO:\n");
            comodin.AppendLine("Tiempo de Realizacion del Aforo: "+_teh+"Horas.");
            comodin.AppendLine("Periodo de conteo del Aforo cada: "+_pcm+"Minutos.\n");
            comodin.AppendLine("N° Vehiculos por periodo de: "+_pcm+"Minutos.\n");
            foreach (var Vehiculos in Veh_mixtos)
                {
                    comodin.Append(Vehiculos+" ");
                }
            comodin.AppendLine("\n");
            comodin.AppendLine("\t\tCALCULOS DEL AFORO:\n");
            comodin.AppendLine("Total vehiculos mixtos del conteo: "+_totalVehMixtos+" Vehiculos mixtos.\n");
            comodin.AppendLine("Vehiculos maximos durante el conteo: "+_Qmax+" Vehiculos mixtos\n");
            
            List<List<int>> Veh_mixtos_sublistas = new List<List<int>>();//creamos las sublistas
            for (int j=0; j < nro_sublistas; j++)//añadimos los datos a las sublistas
                {
                    Veh_mixtos_sublistas.Add( Veh_mixtos.Skip(j).Take(_rel1h).ToList() );
                }
            comodin.AppendLine("\nN° Vehiculos por Subperiodos: ");
            int sum_sublist=0, max_sublist=0;
            foreach (var sub_list in Veh_mixtos_sublistas)
                {
                    sub_list.ForEach(imp);
                    sum_sublist = sub_list.Sum();//buscamos la suma de cada sublista
                    comodin.AppendLine("= "+sum_sublist);//ponemos al final la suma total del sublist
                    if (max_sublist<sum_sublist)//buscamos el valor maximo
                        {
                            max_sublist=sum_sublist;
                        }
                }
            int VHMD = max_sublist;
            double FHMD;
            FHMD = (double)VHMD / ( _rel1h * _Qmax );
            
            comodin.AppendLine("\nVHMD: "+VHMD+" Veh/h.");
            comodin.AppendLine("\nFHMD = VHMD / ( intervalo horario * Qmax )");
            comodin.AppendLine("FHMD = "+VHMD+" / ( "+_rel1h+" * "+_Qmax+" )");
            comodin.AppendLine("\nFHMD = "+FHMD);
            
            //bucle for: Console.WriteLine (lista [i]);
        }
        //Metodo para mostrar en consola las sublistas:
        public void imp(int pos)
            {
                comodin.Append(pos+" + ");
            }
    ////////////////////////////////
    public double NumeroAleatorio(int minimo, int maximo)
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
    ////////////////////////////////
    public void EscrbirRTF()
    {
        //comodinstring = comodin.ToString();
        
        // richTextBox1.Dock = DockStyle.Fill; // NO SE QUE HACE ESTA WEBADA :(
        //richTextBox1.AppendText(comodinstring);//Añadimos texto
        //richTextBox1.set_Rtf = comodinstring;//Añadimos texto
        //richTextBox1.SaveFile(@"D:\Mi_Documento_Texto_Enriquecido.rtf", RichTextBoxStreamType.RichText);//Guardamos el archivo en
        
    }
    ////////////////////////////////
    //Crear Form opaco personalizado
            public void SubFormulario()
            {
                Form formhijo = new Form();
                formhijo.Text = "PROGRAMA VENTANA GRAFICA 1.1.0";
                formhijo.Opacity = .85;
                formhijo.Size = new Size(400,300);
                formhijo.BackColor = Color.MintCream;//cambia color de fondo, Black, MintCream, MediumOrchid, 
                formhijo.ForeColor = Color.MediumOrchid;//cambia color de la fuente SlateBlue
                formhijo.StartPosition = FormStartPosition.CenterScreen;
                formhijo.FormBorderStyle = FormBorderStyle.None;
                
                Button bsalir1 = new Button ();
                bsalir1.Text = "SALIR";
                bsalir1.Font = new Font("Segoe UI", 8F);
                bsalir1.TextAlign = ContentAlignment.MiddleCenter;
                bsalir1.ImageAlign = ContentAlignment.MiddleLeft;
                bsalir1.FlatStyle = FlatStyle.Flat;
                formhijo.CancelButton = bsalir1;//Asignar le boton salir del formulario
                bsalir1.Location = new Point (10, 10);
                formhijo.Controls.Add(bsalir1);
                
                Label label11 = new Label();//Crear el label
	            label11.Location = new Point(100,10);//localizacion del label en el formulario
	            label11.Name = "label11";//Nombre del label como tal
	            label11.Font = new Font("Segoe UI", 8F);
                label11.Size = new Size(300,200);//Tamaño del label
	            label11.Text = "Ingenieria de transito y transportes";//lo que muestra el label al usuario
                formhijo.Controls.Add(label11);
                
                formhijo.ShowDialog();
            }
    ///////////////////////////////////////////////
        struct ProyectoTransito
        {
            public string Nombre;
            public string Ciudad;
            public string Formulador;
            public string Entidad;
            public int IDProyecto;
            public int Numero_Accesos;
            public List<Acceso_Vial> Lista_Accesos_Viales;
        }
        struct Acceso_Vial
        {
            public string Nombre_AccesoVial;
            public int ID_AccesoVial;
            public int Numero_Carriles;
            public List<Carril_Vial> Lista_Carriles_Viales;
        }
        struct Carril_Vial
        {
            public string NombreCarrilVial;
            public int Numero_Movimientos;
            public List<Movimiento_Vial> Lista_Movimientos_Viales;
        }
        struct Movimiento_Vial
        {
            public string Nombre_Movimiento_Vial;
            public int Numero_Aforos;
            public List<Aforo_Vial> Lista_Aforos_x_Movimiento;
        }
        struct Aforo_Vial
        {
            public string Nombre_Aforo;
            public string Aforador;
            public int Duracion_Horas;
            public int Periodo_Conteo_Minutos;
            public List<int> Veh_mixtos;
            public int VHMD;
            public double FHMD;
            
        }
        /////////////////////////////////////////////////////
    ////////////////////////////////
    protected void button1_Click (object sender, EventArgs e)
    {      
        AforoL(3,5);
        comodinstring = comodin.ToString();
        label1.Text = comodinstring;
        // EscrbirRTF(); //FALLIDO
        // SubFormulario();
        
    }
    //////////////////////////////////
    ////////////////////////////////
    protected void bsalir_Click (object sender, EventArgs e)
    {      
        Application.Exit();
    }
    //////////////////////////////////
    protected void botonc_Click (object sender, EventArgs e)
    {      
        // SubFormulario();
    }
    //////////////////////////////////
    

    public static void Main(string[] args) 
    {
      Application.Run(new FormularioOpaco());
    }
    
  }