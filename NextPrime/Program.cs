using System;

namespace NextPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = CaptarNumeros(1);
            if (IsPrime(entrada))
            {
                Console.WriteLine("El Numero ingresado (" + entrada + ") es primo.");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("El Siguiente numero primo posterior al Numero ingresado (" + entrada + ") es: " + CalculationPrime(entrada).ToString());
                Console.ReadLine();
            }

        }

        public static int CaptarNumeros(int isFirst)
        {
            String textoInicial;
            int result = 0;
            try
            {
                Console.Clear();
                Console.WriteLine("Esta es la aplicacion de Next Prime.");
                Console.WriteLine("Debe ingresar un valor numerico mayor a 0");
                Console.WriteLine("Introduzca el valor a Validar: ");
                if (isFirst > 1)
                {
                    Console.WriteLine("Y Recuerde, este es su intento numero " + isFirst);
                }
                textoInicial = Console.ReadLine();
                result = int.Parse(textoInicial);
                if (result <= 0) {
                    throw new Exception("El Valor debe ser Mayor a 0");
                }
            }
            catch (Exception)
            {
                result = CaptarNumeros(isFirst + 1);
            }

            return result;
        }


        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static int CalculationPrime(int number)
        {
            while (true)
            {
                bool isPrime = true;
                //increment the number by 1 each time
                number = number + 1;

                int squaredNumber = (int)Math.Sqrt(number);

                //start at 2 and increment by 1 until it gets to the squared number
                for (int i = 2; i <= squaredNumber; i++)
                {
                    //how do I check all i's?
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    return number;
            }
        }

    }
}
