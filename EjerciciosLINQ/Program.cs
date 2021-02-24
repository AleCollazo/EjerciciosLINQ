using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();

            Console.WriteLine();

            ejercicio2();

            Console.WriteLine();

            ejercicio3();

            Console.WriteLine();

            ejercicio4();

            Console.WriteLine();

            ejercicio5();

            Console.WriteLine();

            //ejercicio6();

            Console.WriteLine();

            ejercicio7();

            Console.WriteLine();

            ejercicio8();

            Console.WriteLine();

            ejercicio9();

            Console.WriteLine();

            ejercicio10();

            Console.WriteLine();

            ejercicio11();

            Console.WriteLine();

            Console.ReadKey();
        }

        public static void ejercicio1()
        {
            Console.WriteLine("1. Escribe una consulta (en LINQ) que dados un array de números, 0,1,2,3,4,5,6,7,8,9,10, obtenga " +
                "un listado de los números pares(divir entre 2 con resto = 0):");

            int[] nums = Enumerable.Range(0,10).ToArray();

            var consulta = nums.Where(num => num % 2 == 0);
            
            foreach (int num in consulta)
            {
                Console.WriteLine(num);
            }
        }

        public static void ejercicio2()
        {
            Console.WriteLine("2. Escribe una consulta en LINQ que dado el array de números 1, 3, -2, -4, -7, -3, -8, 12, " +
                "19, 6, 9, 10, 14  obtenga los números entre 1 y 12:");

            int[] nums = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14};

            var consulta = nums.Where(num => num >= 1 && num <= 12);

            foreach (int num in consulta)
            {
                Console.WriteLine(num);
            }
        }


        public static void ejercicio3()
        {
            Console.WriteLine("3. Escribe una consulta en LINQ que, dada una matriz de números, muestre el número " +
                "y su cuadrado: 3, 9, 2, 8, 6, 5:");

            int[] nums = { 3, 9, 2, 8, 6, 5 };

            var consulta = nums.Select(num => string.Format("{0} - {1}", num, Math.Pow(num,2)));

            foreach (string res in consulta)
            {
                Console.WriteLine(res);
            }
        }

        public static void ejercicio4()
        {
            Console.WriteLine("4. Escribe una consulta de LINQ que, dada una matriz de números, muestre la frecuencia " +
                "con la que aparece: \n\n Ejemplo: 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2:");

            int[] matriz = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var consulta = from nums in matriz
                           group nums by nums into grupo
                           select string.Format("{0} aparece {1} veces",grupo.Key, grupo.Count());

            Console.WriteLine();

            foreach (string num in consulta)
            {
                Console.WriteLine(num);
            }
        }


        public static void ejercicio5()
        {
            Console.WriteLine("5. Escribe una consulta de LINQ donde dada una serie de nombres de ciudades, " +
                "encuentre la ciudad que empieza por A y finaliza por M:");

            string[] ciudades = { "ROMA", "LONDRES", "ZARAGOZA", "A CORUÑA", "ZURICH", "BERLIN", "AMSTERDAM", "AMBERES", "PARIS" };

            var consulta = ciudades.Where(ciudad => ciudad.ToCharArray()[0] == 'A' && ciudad.ToCharArray()[ciudad.Length - 1] == 'M');

            foreach (string res in consulta)
            {
                Console.WriteLine(res);
            }

        }

        public static void ejercicio6()
        {
            Console.WriteLine("6. Escribir una consulta de LINQ donde se obtengan los X numeros más altos: Lista: 5, 7, 13, 9, 55, 4, 16");

            int[] lista = { 5, 7, 13, 9, 55, 4, 16 };

            Console.WriteLine("Introducir la cantidad de números más altos:");

            int num = int.Parse(Console.ReadLine());

            var consulta = lista.OrderByDescending( n => n).Take(num);

            foreach (int res in consulta)
            {
                Console.WriteLine(res);
            }

        }


        public static void ejercicio7()
        {
            Console.WriteLine("Escribe un programa de consola que elimine items de una lista usando la función remove pasando el objeto: ");

            List<char> chars = "MOPA".ToList();

            foreach (char res in chars)
            {
                Console.WriteLine(res);
            }

            Console.WriteLine("Eliminar A:");

            chars.Remove('A');

            foreach (char res in chars)
            {
                Console.WriteLine(res);
            }

        }

        public static void ejercicio8()
        {
            Console.WriteLine("8. Escribe un programa que dados 2 conjuntos, cree su producto cartesiano:");

            string[] conjunto1 = { "a", "b", "c" };
            string[] conjunto2 = { "1", "2", "3" };

            var consulta = from c1 in conjunto1
                           from c2 in conjunto2
                           select string.Format("({0},{1})", c1, c2);

            foreach (string res in consulta)
            {
                Console.Write("{0}, ",res);
            }

        }

        public static void ejercicio9()
        {
            Console.WriteLine("9. Escribe una consulta LINQ que realice una transposición de una matriz:");

            List<List<int>> matriz = new List<List<int>>();

            int cont = 1;

            for (int i = 0; i < 4; i++)
            {
                List<int> a = new List<int>();
                for (int j = 0; j < 4; j++)
                {
                    a.Add(cont);
                    cont++;
                }
                matriz.Add(a);
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t",matriz[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nResultado:\n");


            

        }


        public static void ejercicio10()
        {
            Console.WriteLine("10. Escribe una query de LINQ que devuelva los días de la semana (usando DayOfWeek).");

            var daysNames = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

            foreach (var dia in daysNames)
            {
                Console.WriteLine(dia);
            }
        }


        public static void ejercicio11()
        {
            Console.WriteLine("11. Dada la siguiente lista Escribe una consulta que muestre el número de millonarios por banco (millonario>1.000.000):");

            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };


            var millonarios = from c in customers
                            where c.Balance > 1000000
                            select c;

            foreach (var c in millonarios)
            {
                Console.WriteLine("Nombre: {0} Balance: {1} Bank: {2}",c.Name, c.Balance, c.Bank);
            }

        }

    }

    class Customer
    {
        public string Name { get; internal set; }
        public double Balance { get; internal set; }
        public string Bank { get; internal set; }
    }
}
