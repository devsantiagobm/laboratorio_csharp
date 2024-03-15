using System;

class Program {
    static void Main(string[] args) {
        primerPunto();
        segundoPunto();
        tercerPunto();
        quintoEjercicio();
        sextoEjercicio();
    }

    static void primerPunto() {
        Console.WriteLine("Por favor, ingrese su año de nacimiento:");
        int yearNacimiento = int.Parse(Console.ReadLine()!);
        int edad = CalcularEdad(yearNacimiento);

        Console.WriteLine($"Su edad es: {edad} años.");
    }

    static int CalcularEdad(int yearNacimiento) {
        return 2024 - yearNacimiento;
    }

    static void segundoPunto() {
        bool salir = false;

        while (!salir) {
            Console.WriteLine("Menú:");
            Console.WriteLine("a) Dividir.");
            Console.WriteLine("b) Obtener cubo.");
            Console.WriteLine("c) Cálculo de IMC (Índice de Masa Corporal).");
            Console.WriteLine("d) Salir");
            Console.Write("Seleccione una opción: ");

            char opcion = Console.ReadLine()!.ToLower()[0];

            switch (opcion) {
                case 'a':
                    Dividir();
                    break;

                case 'b':
                    ObtenerCubo();
                    break;

                case 'c':
                    CalcularIMC();
                    break;

                case 'd':
                    Console.WriteLine("Saliendo del programa.");
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void Dividir() {
        Console.WriteLine("Opción a) Dividir seleccionada.");
        Console.Write("Ingrese el dividendo: ");
        double dividendo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el divisor: ");
        double divisor = Convert.ToDouble(Console.ReadLine());

        if (divisor == 0) {
            Console.WriteLine("No se puede dividir entre cero.");
            return;
        }

        double resultadoDivision = dividendo / divisor;
        Console.WriteLine($"El resultado de la división es: {resultadoDivision}");
    }

    static void ObtenerCubo() {
        Console.WriteLine("Opción b) Obtener cubo seleccionada.");
        Console.Write("Ingrese un número para obtener su cubo: ");
        double numero = Convert.ToDouble(Console.ReadLine());
        double resultadoCubo = Math.Pow(numero, 3);
        Console.WriteLine($"El cubo de {numero} es: {resultadoCubo}");
    }

    static void CalcularIMC() {
        Console.WriteLine("Opción c) Cálculo de IMC seleccionada.");
        Console.Write("Ingrese su peso en kg: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese su altura en metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        double imc = peso / (altura * altura);
        Console.WriteLine($"Su IMC es: {imc}");
    }

    static void tercerPunto() {
        Console.WriteLine("Ingrese el radio:");
        double radio = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingrese el ángulo en grados:");
        double grados = double.Parse(Console.ReadLine()!);

        double thetaRadians = GradosARadianes(grados);

        double x = radio * Math.Cos(thetaRadians);
        double y = radio * Math.Sin(thetaRadians);

        Console.WriteLine($"Las coordenadas rectangulares son: ({x}, {y})");
    }

    static double GradosARadianes(double grados) {
        return grados * Math.PI / 180.0;
    }

    static void cuartoEjercicio() {
        Console.WriteLine("Ingrese el valor de x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de n:");
        int n = Convert.ToInt32(Console.ReadLine());

        double resultado = CalcularProgresion(x, n);
        Console.WriteLine($"El resultado de la progresión es: {resultado}");
    }

    static double CalcularProgresion(double x, int n) {
        if (n == 0) {
            return 1;
        }
        else {
            return Math.Pow(x, n) + CalcularProgresion(x, n - 1);
        }
    }
    static void quintoEjercicio() {
        Console.WriteLine("Ingrese el límite de la serie Fibonacci:");
        int limite = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("La serie Fibonacci hasta el término " + limite + " es:");
        for (int i = 0; i <= limite; i++) {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n) {
        if (n <= 1) {
            return n;
        }
        else {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    static void sextoEjercicio() {
        Console.WriteLine("Ingrese el valor de n:");
        int n = Convert.ToInt32(Console.ReadLine());

        double resultado = CalcularSerie(n);
        Console.WriteLine($"El resultado de la serie hasta el término {n} es: {resultado}");
    }

    static double CalcularSerie(int n) {
        double suma = 0;

        for (int i = 1; i <= n; i++) {
            double resultado = i / Math.Pow(2, i);

            if (i % 2 == 0) {
                suma -= resultado;
            }
            else {
                suma += resultado;
            }

        }

        return suma;
    }
}