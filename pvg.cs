using System;
using System.Linq; //Trabajar con listas, metodo Skip()
using System.IO;//para manejar archivos
using System.Collections.Generic;//para exportar
using System.Text;//para exportar
using System.Windows.Forms;//ventanas graficas
using System.Drawing;//ventanas graficas
//using System.Windows.Forms.DataVisualization.Charting;// trabajar charts

namespace EspacioNombres
{
    public class Clase_Personalizada
        {
            public static void Main()
                {
                    CrearFormularioOpaco();
                }
            //
            public static void CrearFormularioOpaco()
                {
                    // Crear un nuevo formulario tipo ventana.
                    Form form2 = new Form();
                    // Establecer el titulo de formulario
                    form2.Text = "PROGRAMA VENTANA GRAFICA 1.0";
                    // Establecer la propiedad opacity to 90%.
                    form2.Opacity = .85;
                    // (pixels) in height and width.Establecer el tamaño del formulario
                    form2.Size = new Size(500,400);
                    form2.BackColor = Color.MintCream;//cambia color de fondo, Black, MintCream, MediumOrchid, 
                    form2.ForeColor = Color.MediumOrchid;//cambia color de la fuente SlateBlue
                    // Ubica el formulario en el centro de la pantalla.
                    form2.StartPosition = FormStartPosition.CenterScreen;
                    
                    ////////////////////////////////////////////////////////////////////
                    // Crea un boton, uno aceptar
                    Button button1 = new Button ();
                    // Establece el texto del boton en "ok"
                    button1.Text = "ACEPTAR";
                    // Establece el boton creado como aceptar
                    form2.AcceptButton = button1;
                    // Ubica el boton en las coordenadas del formulario.
                    button1.Location = new Point (10, 30);
                    // Give the button a flat appearance.
                    button1.FlatStyle = FlatStyle.Flat;
                    // Assign an image to the button.
                    // button1.Image = Image.FromFile(@"C:\Users\usuario\Pictures\img.bmp");
                    // Align the image and text on the button.
                    button1.ImageAlign = ContentAlignment.MiddleCenter;    // MiddleCenter, MiddleLeft, MiddleRight
                    button1.TextAlign = ContentAlignment.MiddleCenter;
                    // Establece las fuentes. Fuentes: Segoe UI, Microsoft Sans Serif, 
                    button1.Font = new Font("Segoe UI", 8F); //Cambia el tipo de letra y tamaño
                    // Muestra el boton de ayuda
                    form2.HelpButton = true;
                    // Define el tipo o estilo de borde del formulario
                    form2.FormBorderStyle = FormBorderStyle.None;//FixedDialog, None
                    // Set the MaximizeBox to false to remove the maximize box.Hace visible el boton maximizar
                    form2.MaximizeBox = true;
                    // Set the MinimizeBox to false to remove the minimize box.Hace visible el boton minimizar
                    form2.MinimizeBox = true;
                    // Añadir el boton creado anteriormente en el formulario
                    form2.Controls.Add(button1);
                    // Boton salir
                    Button bsalir = new Button ();
                    bsalir.Text = "SALIR";
                    bsalir.Font = new Font("Segoe UI", 8F);
                    bsalir.TextAlign = ContentAlignment.MiddleCenter;
                    bsalir.ImageAlign = ContentAlignment.MiddleLeft;
                    bsalir.FlatStyle = FlatStyle.Flat;
                    form2.CancelButton = bsalir;
                    bsalir.Location
                        = new Point (button1.Left, button1.Height + button1.Top + 10);
                    form2.Controls.Add(bsalir);
                    // bOTON hacer
                    Button bhacer = new Button ();
                    bhacer.Text = "HACER";
                    bhacer.Font = new Font("Segoe UI", 8F);
                    bhacer.Location
                        = new Point (bsalir.Left, bsalir.Height + bsalir.Top + 10);
                    bhacer.FlatStyle = FlatStyle.Flat;
                    EventHandler myHandler = new EventHandler(bhacer_Click);//Escuchador de eventos???
                    bhacer.Click += myHandler;
                    form2.Controls.Add(bhacer);
                    
                    ///////////////////////////////////////////////////////////////////////////////
                    //Boton circular
                    
                    
                    ///////////////////////////////////////////////////////////////////////////////
                    // Crear y añadir un Label al formulario y establecer su posicion en el formulario
	                Label label1 = new Label();//Crear el label
	                label1.Location = new Point(150,10);//localizacion del label en el formulario
	                label1.Name = "label1";//Nombre del label como tal
	                label1.Font = new Font("Segoe UI", 8F);
                    label1.Size = new Size(300,200);//Tamaño del label
	                label1.Text = "Ingenieria de transito y transportes";//lo que muestra el label al usuario
	                
                    form2.Controls.Add(label1);//Añadimos el label al formulario
                    
                    
                    ///////////////////////////////////////////////////////////////////////////////
                    // Muestra el formulario tipo ventana
                    form2.ShowDialog();
                    
                }
            //
            //evento clic boton hacer: bhacer
            private static void bhacer_Click(object sender, EventArgs e)
            {
                //MessageBox.Show("Has Dado Click!");
                SubFormulario();
            }
            
            //Crear Form opaco personalizado
            public static void SubFormulario()
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
        }
}