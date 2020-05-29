using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"28-05-2020 06:09:59 - {GetTurn(new DateTime(2020, 05, 28, 06, 09, 59))}");
                Console.WriteLine($"28-05-2020 06:10:00 - {GetTurn(new DateTime(2020, 05, 28, 06, 10, 00))}");
                Console.WriteLine($"28-05-2020 16:49:59 - {GetTurn(new DateTime(2020, 05, 28, 16, 49, 59))}");
                Console.WriteLine($"28-05-2020 16:50:00 - {GetTurn(new DateTime(2020, 05, 28, 16, 50, 00))}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        enum Turno { Diurno, Noturno }

        static Turno GetTurn(DateTime dataHoraInformada)
        {
            TimeSpan horaInformada = new TimeSpan(dataHoraInformada.Hour, dataHoraInformada.Minute, dataHoraInformada.Second);

            if (horaInformada < new TimeSpan(06, 10, 00) || horaInformada > new TimeSpan(16, 49, 59))
                return Turno.Noturno;

            return Turno.Diurno;
        }
    }
}
