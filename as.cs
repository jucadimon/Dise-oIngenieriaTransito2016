using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public class Form1 : Form 
{

    protected override void OnPaint(PaintEventArgs e) {
    Graphics g = e.Graphics;
    g.FillRectangle(Brushes.White, this.ClientRectangle);
    Font f = new Font("Times New Roman", 24);
    g.DrawString("Translation", f, Brushes.Black, 0, 0);

    g.TranslateTransform(150, 75);
    g.DrawString("Translation", f, Brushes.Black, 0, 0);
    }
    public static void Main() 
    {
        Application.Run(new Form1());
    }
}
