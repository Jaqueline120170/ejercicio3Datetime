using System;

class Program
{
    static void Main()
    {
        DateTime fechaHoy = DateTime.Now;
        DateTime fecha1Dia = fechaHoy.AddDays(1);
        Console.WriteLine(fecha1Dia.ToString());
        DateTime fecha2 = fecha1Dia.AddMonths(-24).AddYears(new Random().Next(0, 5));
        Console.WriteLine(fecha2.ToString());

        if (fecha2 > fecha1Dia)
        {
            Console.WriteLine("El hoy es más grande");
        }
        else
        {
            Console.WriteLine("Hoy no es más grande");
        }

    }
}
