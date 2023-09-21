using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace datas{ 
  class Program{ 
    static void Main(string[] args){ 
      Console.Clear();
      // ha um tipo de dado Datetime
      // é um struct 

      // Com "new" vou ter a struct, é um objeto com atributos e métodos;
      //var data = new DateTime(); NÃO TEM NULO POR PADRÃO
      //var data = DateTime.Now;

                          //  ano  mm dd hh mm ss
      //var data = new DateTime(2020,10,12,13,23,14);
     /*  Console.WriteLine(data.Year); 
      Console.WriteLine(data.Month);  */
      /* Console.WriteLine(data.Day); 
      Console.WriteLine(data.Hour); 
      Console.WriteLine(data.Minute); 
      Console.WriteLine(data.Second); 
      Console.WriteLine(data.DayOfWeek); 
      Console.WriteLine(data.DayOfYear);*/
      //Console.WriteLine(data); 


      // FORMATAR A DATA 
      var data = DateTime.Now;
      // tem várias aqui de y,yyy,yyyy,yy;
      // ano y; mes M; dia d; hora h, segundo s; como se fosse um %c %s;
      //var format = String.Format("{0:yyyy}",data); 
      /* var format = String.Format("{0:MM}",data); 
      var format = String.Format("{0:M}",data); */ /* 
      var format = String.Format("{0:yyyy-MM-dd}",data); */


    /*   var format = String.Format("{0:r}",data);  
      var format = String.Format("{0:s}",data);  
      var format = String.Format("{0:u}",data);  */
      //Console.WriteLine(format);

      //REMOÇÃO E ADIÇÃO     
      /* Console.WriteLine(data); 
      Console.WriteLine(data.AddDays(12)); 
      Console.WriteLine(data.AddMonths(1)); 
      Console.WriteLine( data.AddYears(1)); */
      
      //COMPARAÇÃO 

      // vai pegar até a fração de segundo
      // então tem que pegar .Date
      // da para fazer qualquer operador relacional
      /* if(data.Date == DateTime.Now.Date){ 
        Console.WriteLine("igual");
      }
      Console.WriteLine(data); */

      // LOCALIZAÇÃO E GLOBALIZAÇÃO 
     /*  Console.WriteLine(DateTime.Now);

      var pt =  new CultureInfo("pt-PT"); 
      var br =  new CultureInfo("pt-BR"); 
      var en =  new CultureInfo("pt-US"); 
      var de =  new CultureInfo("pt-DE");
      var atual = CultureInfo.CurrentCulture; 

      Console.WriteLine(DateTime.Now.ToString("D", en));
      //Console.WriteLine(string.Format("{0:D}", DateTime.Now)); */


      //TIMEZONE 

     /*  var utcDate = DateTime.UtcNow;// horário global, servidor global
      Console.WriteLine(utcDate); 
      Console.WriteLine(DateTime.Now);// data da máquina
      Console.WriteLine(utcDate.ToLocalTime());
      
      // se meu usuaria estiver na australia
      var timeAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
      Console.WriteLine(timeAustralia);
      //dai 
      var horaAustralia= TimeZoneInfo.ConvertTimeFromUtc(utcDate,timeAustralia);
      Console.WriteLine(horaAustralia);

      var timezones = TimeZoneInfo.GetSystemTimeZones();
      foreach( var timezone in timezones){ 
        Console.WriteLine(timezone.Id); 
        Console.WriteLine(timezone); 
        Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone ));
        Console.WriteLine("----------");
      } */



   /*    //TIMESPAN 
      // calculo de diferença de hora, essas coisas;
      Console.WriteLine(DateTime.Now);
      var timeSpan =  new TimeSpan(); 
      Console.WriteLine(timeSpan);

      var timeSpanHoraMinSeg = new TimeSpan(5, 12, 19);
      Console.WriteLine(timeSpanHoraMinSeg);
      // ai faz uma variavel menos a outra 
      var conta = new TimeSpan(12, 55, 4); 
      Console.WriteLine(conta-timeSpanHoraMinSeg); */






    }
  }
}