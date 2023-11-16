using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Menampilkan pesan nama program
            Console.WriteLine("Kalkulator Sederhana");

            // Memulai loop input user
            while (true)
            {
                // User input
                Console.Write("\nMasukkan ekspresi (contoh, 5 + 3, 10 * 2, 8 / 4): ");
                string input = Console.ReadLine();

                // check user ingin keluar dari program
                if (input.ToLower() == "exit")
                {
                    break; // Keluar dari loop jika pengguna mengetik "exit"
                }

                try
                {
                    // Menilai input user dan menampilkan hasil
                    double result = EvaluateExpression(input);
                    Console.WriteLine();
                    Console.WriteLine($"Hasil: {result}");
                    Console.WriteLine("-------------------------------------------------------");
                }
                catch (Exception ex)
                {
                    // catch error
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public static double EvaluateExpression(string expression)
        {
            // Membagi input dengan batasan spasi
            string[] elements = expression.Split(' ');

            // Memeriksa apakah ekspresi memiliki format yang benar (operand1 operator operand2)
            if (elements.Length != 3)
            {
                throw new ArgumentException("Format ekspresi tidak valid. Gunakan format: operand1 operator operand2");
            }

            // Mem-parsing operand dan operator dari ekspresi
            double operand1 = double.Parse(elements[0]);
            double operand2 = double.Parse(elements[2]);
            string operation = elements[1];

            // Melakukan operasi aritmatika yang sesuai berdasarkan operator
            switch (operation)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    // Memeriksa pembagian dengan nol
                    if (operand2 == 0)
                    {
                        throw new DivideByZeroException("Tidak dapat dibagi dengan nol.");
                    }
                    return operand1 / operand2;
                default:
                    // Melempar pengecualian untuk operator yang tidak valid
                    throw new ArgumentException($"Operator tidak valid: {operation}");
            }
        }
    }
}
