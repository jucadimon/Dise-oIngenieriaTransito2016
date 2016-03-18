using System;

using System.Collections.Generic; 
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
 
using HtmlAgilityPack; //ensamblado web
using ScrapySharp;//ensamblado web
using ScrapySharp.Core;//ensamblado web
using ScrapySharp.Extensions; //ensamblado web
using ScrapySharp.Network;//ensamblado web
using ScrapySharp.Html.Forms;//ensamblado web
using ScrapySharp.Html;//ensamblado web


public class Importar_Info_Web
{
    // Compilar con emsamvblado externo los cuales deben estar en la misma carpeta del archivo .cs:
    // csc /out:TestCode.exe /reference:MathLibrary.DLL TestCode.cs
    // csc /out:web.exe /reference:ScrapySharp.DLL /reference:ScrapySharp.Core.DLL /reference:HtmlAgilityPack.DLL web.cs
    static ScrapingBrowser sb = new ScrapingBrowser();
    
    
    public static void Main()
    {
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        sw.Start();
        var resul = GetTRM();
        sw.Stop();
        
        Console.WriteLine("fecha : {0} \nTRM : {1} \nElapsed : {2}ms",resul.Key,resul.Value,sw.Elapsed.Milliseconds/10);
        Console.ReadLine();
    }
    
    static KeyValuePair<string, double> GetTRM()
    {
        sb.Encoding = Encoding.UTF8;
        sb.Headers.Add("HttpRequestHeader.UserAgent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
        string _TRMXpath = @"/html/body/table/tr/td";
        WebPage rWp =
            sb.NavigateToPage(new Uri("http://obiee.banrep.gov.co/analytics/saw.dll?Go&NQUser=publico&NQPassword=publico&Path=/shared/Consulta%20Series%20Estadisticas%20desde%20Excel/1.%20Tasa%20de%20Cambio%20Peso%20Colombiano/1.1%20TRM%20-%20Disponible%20desde%20el%2027%20de%20noviembre%20de%201991/TRM%20para%20un%20dia&lang=es&"), HttpVerb.Get, "");
        
        var _TRM = rWp.Html.SelectNodes(_TRMXpath)[0].InnerText.Trim();
        
        if (!_TRM.Contains("$"))
        {
            //control reintentos
            _TRM = rWp.Html.SelectNodes(_TRMXpath)[0].InnerText;
        }
        //index varios
        int p = _TRM.IndexOf(":");
        int p2 = _TRM.IndexOf("a");
        
        var _FechaTRM = _TRM.Substring(p2+2, _TRM.Length-2*p2-p-5).Trim();
        var _ValorTRM = _TRM.Substring(p+1, _TRM.IndexOf("pesos")-p-3).Trim();
        //Casts
        double _valorTRM = Double.Parse(_ValorTRM.Split(null)[3]);
        // Cast fecha
        
        return new KeyValuePair<string, double>(_FechaTRM, _valorTRM);
    }
    
}