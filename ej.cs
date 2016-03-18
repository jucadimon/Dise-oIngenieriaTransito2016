using System;
 
public class Ejemplo_12_02a
{
    public static void Main()
    {
        // ruta del compilador:
        // PATH C:\Windows\Microsoft.NET\Framework\v4.0.30319;%PATH%
        // ruta de ubicacion del archivo a compilar:
        // cd C:\Users\usuario\Documents\vs code codigo fuente
        int posX, posY;
        Console.SetWindowSize(100,50);//poner tamaño ventana consola Ancho X Alto, maximos valores=(128,58)
        Console.Title = "Ejemplo de consola";
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();
 
        posY = 10;  // En la fila 10
        Random r = new Random(DateTime.Now.Millisecond);
        posX = r.Next(20, 40); // Columna al azar entre 20 y 40
        Console.SetCursorPosition(posX, posY);
        Console.WriteLine("Bienvenido");
 
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(10, 15);
        Console.Write("Pulsa 1 o 2: ");
        ConsoleKeyInfo tecla;
        do 
        {
            tecla = Console.ReadKey(false);
        } 
        while ((tecla.KeyChar != '1') && (tecla.KeyChar != '2'));
        
        
        int maxY = Console.WindowHeight;
        int maxX = Console.WindowWidth;
        Console.SetCursorPosition(maxX-50, maxY-1);
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("Pulsa una tecla para terminar... ");    
        Console.ReadKey(true);
    }  
    
    ////////////////////////////////
    public void reproducirmp3()
    {
        // Abrir una ventana para escoger el archivo
        OpenFileDialog openDialog = new OpenFileDialog();
        openDialog.Filter = "MP3 Files|*.mp3|All Files|*.*";
        
        if (DialogResult.OK == openDialog.ShowDialog()) {
            SoundPlayer player = new SoundPlayer(openDialog.FileName);

            try {
                player.Play();
            } catch (Exception) {
                MessageBox.Show("An error occurred while playing media.");
            } finally {
                player.Dispose();
            }
        }
    }
    ////////////////////////////////
    public void abrirtxt()
    {
        Stream myStream = null;
    OpenFileDialog openFileDialog1 = new OpenFileDialog();

    openFileDialog1.InitialDirectory = @"c:\" ;
    openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" ;
    openFileDialog1.FilterIndex = 2 ;
    openFileDialog1.RestoreDirectory = true ;
    
    if(openFileDialog1.ShowDialog() == DialogResult.OK)
    {
        try
        {
            if ((myStream = openFileDialog1.OpenFile()) != null)
            {
                using (myStream)
                {
                    // Insert code to read the stream here.
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }
    }
    }
}