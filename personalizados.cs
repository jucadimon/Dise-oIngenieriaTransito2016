//Espacios de Nombres
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

//Clase personalizada

//Clase personalizada

//Clase Programa
public class FormularioOpaco : Form
    {
        //
        // Variables a nivel de todo el programa
        private Button bsalir;
        private Button info;
        private Button ingresarDatos;
        public Label Titulo_Programa;
        // Variables a nivel de todo el programa
        //
        public FormularioOpaco()
            {
                InitializeComponent();
                CenterToScreen();
            }
        //
        private void InitializeComponent()
            {
                //Inicializar los objetos
                this.bsalir = new Button();
                this.info = new Button();
                this.ingresarDatos = new Button();
                this.Titulo_Programa = new Label();
                //
                this.SuspendLayout();
                // 
                // bsalir
                // 
                this.bsalir.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                this.bsalir.Location = new Point(945, 10);
                this.bsalir.Name = "bsalir";
                this.bsalir.Size = new System.Drawing.Size(45, 25);
                this.bsalir.Text = "SALIR";
                this.bsalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
                this.bsalir.FlatStyle = FlatStyle.Flat;
                this.bsalir.Click += new EventHandler(this.bsalir_Click);
                // 
                // boton info
                // 
                this.info.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                this.info.Location = new Point(890, 10);
                this.info.Name = "info";
                this.info.Size = new System.Drawing.Size(45, 25);
                this.info.Text = "INFO";
                this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
                this.info.FlatStyle = FlatStyle.Flat;
                this.info.Click += new EventHandler(this.info_Click);
                // 
                // boton ingresarDatos
                // 
                this.ingresarDatos.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                this.ingresarDatos.Location = new Point(10, 45);
                this.ingresarDatos.Name = "ingresarDatos";
                this.ingresarDatos.Size = new System.Drawing.Size(80, 25);
                this.ingresarDatos.Text = "PROYECTO";
                this.ingresarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
                this.ingresarDatos.FlatStyle = FlatStyle.Flat;
                this.ingresarDatos.Click += new EventHandler(this.ingresarDatos_Click);
                // 
                // Titulo_Programa
                // 
                this.Titulo_Programa.Name = "Titulo_Programa";
                this.Titulo_Programa.Text = "PROGRAMA";
                this.Titulo_Programa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
                this.Titulo_Programa.Size = new Size(600,25);//Tamaño del label
	            this.Titulo_Programa.Location = new Point(550 - (Titulo_Programa.Width / 2),10);//localizacion del label en el formulario
	            this.Titulo_Programa.Font = new Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
                // 
                // FormularioOpaco
                // 
                this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
                this.ClientSize = new System.Drawing.Size(1000, 600);
                this.Opacity = .85;
                this.BackColor = Color.MintCream;//cambia color de fondo, Black, MintCream, MediumOrchid, 
                this.ForeColor = Color.MediumOrchid;//cambia color de la fuente SlateBlue
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//FixedDialog, None, Fixed3D
                this.Name = "FormularioOpaco";
                this.Text = "PROGRAMA 1.1.0";
                //
                // 
                // Añadir los botones, label, picturebox al FormularioOpaco ////////////////////
                // 
                this.Controls.Add(this.bsalir);
                this.Controls.Add(this.info);
                this.Controls.Add(this.Titulo_Programa);
                this.Controls.Add(this.ingresarDatos);
                //
                this.ResumeLayout(false);
            }
        ////////////////////////////////
        // Metodos de los botones
        protected void bsalir_Click (object sender, EventArgs e)
            {      
                Application.Exit();
            }
        ///
        protected void ingresarDatos_Click (object sender, EventArgs e)
            {      
                Button bsalirSub = new Button();
                Label Titulo_SubFormulario = new Label();
                Label Informacion = new Label();
                Form Subformulario = new Form();
                //  datos del boton salir
                bsalirSub.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                bsalirSub.Location = new Point(945, 10);
                bsalirSub.Name = "bsalirSub";
                bsalirSub.Size = new System.Drawing.Size(45, 25);
                bsalirSub.Text = "X";
                bsalirSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
                bsalirSub.FlatStyle = FlatStyle.Flat;
                //  datos del label titulo
                Titulo_SubFormulario.Name = "Titulo_SubFormulario";
                Titulo_SubFormulario.Text = "SUB VENTANA";
                Titulo_SubFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
                Titulo_SubFormulario.Size = new Size(600,25);//Tamaño del label
	            Titulo_SubFormulario.Location = new Point(550 - (Titulo_SubFormulario.Width / 2),10);//localizacion del label en el formulario
	            Titulo_SubFormulario.Font = new Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
                //  datos del label Informacion
                Informacion.Name = "Informacion";
                Informacion.Text = "TEXTO GENERADO";
                Informacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
                Informacion.Size = new Size(600,480);//Tamaño del label
	            Informacion.Location = new Point(65,65);//localizacion del label en el formulario
	            Informacion.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                //  datos de la ventana
                Subformulario.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
                Subformulario.ClientSize = new System.Drawing.Size(1000, 600);
                Subformulario.Opacity = .85;
                Subformulario.BackColor = Color.MintCream;//cambia color de fondo, Black, MintCream, MediumOrchid, 
                Subformulario.ForeColor = Color.MediumOrchid;//cambia color de la fuente SlateBlue
                Subformulario.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//FixedDialog, None, Fixed3D
                Subformulario.Name = "Subformulario";
                Subformulario.Text = "SUB VENTANA X 1.0";
                Subformulario.CancelButton = bsalirSub;
                Subformulario.StartPosition = FormStartPosition.CenterScreen;
                //
                Subformulario.Controls.Add(bsalirSub);
                Subformulario.Controls.Add(Titulo_SubFormulario);
                Subformulario.Controls.Add(Informacion);
                //
                Subformulario.ShowDialog();
            }
        ///
        protected void info_Click (object sender, EventArgs e)
            {      
                Button bsalirSub = new Button();
                Label Titulo_SubFormulario = new Label();
                Label Informacion = new Label();
                Form Subformulario = new Form();
                //  datos del boton salir
                bsalirSub.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                bsalirSub.Location = new Point(585, 10);
                bsalirSub.Name = "bsalirSub";
                bsalirSub.Size = new System.Drawing.Size(45, 25);
                bsalirSub.Text = "X";
                bsalirSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
                bsalirSub.FlatStyle = FlatStyle.Flat;
                //  datos del label titulo
                Titulo_SubFormulario.Name = "Titulo_SubFormulario";
                Titulo_SubFormulario.Text = "SUB VENTANA";
                Titulo_SubFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
                Titulo_SubFormulario.Size = new Size(400,25);//Tamaño del label
	            Titulo_SubFormulario.Location = new Point(320 - (Titulo_SubFormulario.Width / 2),10);//localizacion del label en el formulario
	            Titulo_SubFormulario.Font = new Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
                //  datos del label Informacion
                Informacion.Name = "Informacion";
                Informacion.Text = "SOFTWARE DE tal cosa"
                +"\nSOFTWARE CREADO POR:\nJUANCARLOS DIAZ MONTIEL\nESTUDIANTE INGENIERIA CIVIL"+
                "\nUNIVERSIDAD DE SUCRE\n2016\nCEL: 3016922644\nCORREO: jucadimon@hotmail.com\nWEB: "+
                "http://ingenieria-civil-y-pi.blogspot.com.co/ ";
                Informacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
                Informacion.Size = new Size(580,380);//Tamaño del label
	            Informacion.Location = new Point(40,35);//localizacion del label en el formulario
	            Informacion.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                //  datos de la ventana
                Subformulario.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
                Subformulario.ClientSize = new System.Drawing.Size(640, 480);
                Subformulario.Opacity = .85;
                Subformulario.BackColor = Color.MintCream;//cambia color de fondo, Black, MintCream, MediumOrchid, 
                Subformulario.ForeColor = Color.MediumOrchid;//cambia color de la fuente SlateBlue
                Subformulario.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//FixedDialog, None, Fixed3D
                Subformulario.Name = "Subformulario";
                Subformulario.Text = "SUB VENTANA X 1.0";
                Subformulario.CancelButton = bsalirSub;
                Subformulario.StartPosition = FormStartPosition.CenterScreen;
                //
                Subformulario.Controls.Add(bsalirSub);
                Subformulario.Controls.Add(Titulo_SubFormulario);
                Subformulario.Controls.Add(Informacion);
                //
                Subformulario.ShowDialog();
            }
        // Metodos de los botones
        
        // Metodo Main Principal
        public static void Main(string[] args) 
            {
                Application.Run(new FormularioOpaco());
            }
        // Metodo Main Principal
    }
//Clase Programa
