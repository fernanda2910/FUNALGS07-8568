internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        double monto = 0, salario, salariod, total;
        int emp1 = 0, emp2 = 0, n, faltas;
        string nom;

        Console.Write("Ingrese el número de empleados: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Empleado {i + 1}:");
            Console.Write("Nombre: ");
            nom = Console.ReadLine();
            Console.Write("Salario mensual: ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Número de faltas: ");
            faltas = int.Parse(Console.ReadLine());
            salariod = salario / 30;
            total = salario - (faltas * salariod);
            monto += total;
            if (total >= 2500 && total <= 3500)
                emp1++;
            if (total < 1000 || total > 4000)
                emp2++;

            Console.WriteLine($"Sueldo final de {nom}: {total}");
        }
        Console.WriteLine($"Monto total de sueldos: {monto}");
        Console.WriteLine($"Número de empleados que ganan entre 2500 y 3500: {emp1}");
        Console.WriteLine($"Número de empleados que ganan menos de 1000 o más de 4000: {emp2}");
    }
}