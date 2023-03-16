namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int hasil = 0;

            while (true)
            {
                Console.Write(
                    "\n\nInput operasi : "
                );

                string inputConsole = Console.ReadLine().Replace(" ", "");

                char[] simbol = { '+', '-', '*', ':' };

                string input = "";

                if (inputConsole.Contains("="))
                {
                    input = inputConsole.Remove(inputConsole.Length-1);
                }

                int posisi = input.IndexOfAny(simbol);

                int pertama = 0, kedua = 0;

                if (posisi == 0)
                {
                    pertama = hasil;
                    // int x = input.Length - (posisi + 1) - 1;
                    kedua = Convert.ToInt32(input.Substring(posisi + 1));
                }
                else
                {
                    pertama = Convert.ToInt32(input.Substring(0, posisi));

                    // int x = input.Length - (posisi + 1) - 1;
                    kedua = Convert.ToInt32(input.Substring(posisi + 1));
                }

                char operasi = input[posisi];

                switch (operasi)
                {
                    case '+':
                        hasil = Tambah(pertama, kedua);
                        if (posisi== 0) Console.WriteLine($"{pertama} + {kedua}");
                        Console.WriteLine("\nHasil = " + hasil);
                        break;
                    case '-':
                        hasil = Kurang(pertama, kedua);
                        if (posisi == 0) Console.WriteLine($"{pertama} + {kedua}");
                        Console.WriteLine("\nHasil = " + hasil);
                        break;
                    case '*':
                        hasil = Kali(pertama, kedua);
                        if (posisi == 0) Console.WriteLine($"{pertama} + {kedua} =");
                        Console.WriteLine("\nHasil = " + hasil);
                        break;
                    case ':':
                        hasil = Bagi(pertama, kedua);
                        if (posisi == 0) Console.WriteLine($"{pertama} + {kedua}");
                        Console.WriteLine("\nHasil = " + hasil);
                        break;
                    default:
                        Console.WriteLine("\nPilihan anda tidak tersedia");
                        break;
                }

            }
        }

        static int Tambah(int angka1, int angka2)
        {
            int hasil = angka1 + angka2;
            return hasil;
        }

        // function pengurangan
        static int Kurang(int angka1, int angka2)
        {
            int hasil = angka1 - angka2;
            return hasil;
        }

        // function perkalian
        static int Kali(int angka1, int angka2)
        {
            int hasil = angka1 * angka2;
            return hasil;
        }

        // function pembagian
        static int Bagi(int angka1, int angka2)
        {
            int hasil = angka1 / angka2;
            return hasil;
        }
    }
}