using System;
using System.Collections;

namespace MiniRestaurant_29_RifdahInasN
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack food = new Stack();

                Queue beverage = new Queue();


                string status;

            pilihan:
                Console.WriteLine("============== Mini Restaurant ==============");
                Console.WriteLine("1. Tampilkan daftar menu makanan dan minuman");
                Console.WriteLine("2. Tampilkan daftar menu makanan");
                Console.WriteLine("3. Tampilkan daftar menu minuman");
                Console.WriteLine("4. Menambahkan menu makanan baru");
                Console.WriteLine("5. Menambahkan menu minuman baru");
                Console.WriteLine("6. Menghapus menu makanan");
                Console.WriteLine("7. Menghapus menu minuman");
                Console.WriteLine("8. Mencari makanan yang diinginkan");
                Console.WriteLine("9. Mengecek menu minuman pada urutan pertama");
                int x;
                Console.Write("Masukkan Pilihanmu : ");
                x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.WriteLine("Menu Makanan : ");
                        foreach (var StackItem in food)
                        {
                            Console.WriteLine(StackItem);
                        }
                        Console.WriteLine("Menu Minuman : ");
                        foreach (var element in beverage)
                        {
                            Console.WriteLine(element);
                        }
                        Console.Write("Kembali ke Menu? (y/n) : ");
                        status = Console.ReadLine();
                        if (status == "y")
                            goto pilihan;
                        else
                            exit();

                        break;
                    case 2:
                        Console.WriteLine("Menu Makanan : ");
                        foreach (var StackItem in food)
                        {
                            Console.WriteLine(StackItem);
                        }
                        Console.Write("Kembali ke Menu? (y/n) : ");
                        status = Console.ReadLine();
                        if (status == "y")
                            goto pilihan;
                        else
                            exit();
                        break;
                    case 3:
                        Console.WriteLine("Menu Minuman : ");
                        foreach (var element in beverage)
                        {
                            Console.WriteLine(element);
                        }

                        Console.Write("Kembali ke Menu? (y/n) : ");
                        status = Console.ReadLine();
                        if (status == "y")
                            goto pilihan;
                        else
                            exit();
                        break;
                    case 4:
                        string makanan;
                        Console.Write("Menambahkan makanan : ");
                        makanan = Console.ReadLine();
                        food.Push(makanan);

                        Console.WriteLine("Menu Makanan : ");
                        foreach (var StackItem in food)
                        {
                            Console.WriteLine(StackItem);
                        }

                        Console.Write("Kembali ke Menu? (y/n) : ");
                        status = Console.ReadLine();
                        if (status == "y")
                            goto pilihan;
                        else
                            exit();
                        break;
                    case 5:
                        string minuman;
                        Console.Write("Menambahkan minuman : ");
                        minuman = Console.ReadLine();
                        beverage.Enqueue(minuman);

                        Console.WriteLine("Menu Minuman : ");
                        foreach (var element in beverage)
                        {
                            Console.WriteLine(element);
                        }

                        Console.Write("Kembali ke Menu? (y/n) : ");
                        status = Console.ReadLine();
                        if (status == "y")
                            goto pilihan;
                        else
                            exit();
                        break;
                    case 6:
                        Console.WriteLine("Menu Makanan : ");
                        foreach (var StackItem in food)
                        {
                            Console.WriteLine(StackItem);
                        }

                        Console.WriteLine($"Makanan yang akan dihapus : {food.Pop()}");
                        Console.WriteLine("Menu Makanan : ");
                        foreach (var StackItem in food)
                        {
                            Console.WriteLine(StackItem);
                        }
                        Console.Write("Kembali ke Menu? (y/n) : ");
                        status = Console.ReadLine();
                        if (status == "y")
                            goto pilihan;
                        else
                            exit();
                        break;
                    case 7:
                        Console.WriteLine("Menu Minuman : ");
                        foreach (var element in beverage)
                        {
                            Console.WriteLine(element);
                        }

                        Console.WriteLine($"Minuman yang akan dihapus : {beverage.Dequeue()}");

                        Console.WriteLine("Menu Minuman : ");
                        foreach (var element in beverage)
                        {
                            Console.WriteLine(element);
                        }

                        Console.Write("Kembali ke Menu? (y/n) : ");
                        status = Console.ReadLine();
                        if (status == "y")
                            goto pilihan;
                        else
                            exit();
                        break;
                    case 8:
                        string cekMakanan;
                        Console.Write("Cek Ketersediaan Makanan : ");
                        cekMakanan = Console.ReadLine();
                        Console.WriteLine($"Apakah makanan tersebut masih ada? {food.Contains(cekMakanan)}");
                        Console.Write("Kembali ke Menu? (y/n) : ");
                        status = Console.ReadLine();
                        if (status == "y")
                            goto pilihan;
                        else
                            exit();
                        break;
                    case 9:
                        Console.WriteLine($"Urutan pertama : {beverage.Peek()}");
                        Console.Write("Kembali ke Menu? (y/n) : ");
                        status = Console.ReadLine();
                        if (status == "y")
                            goto pilihan;
                        else
                            exit();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Maaf yang anda inputkan harusnya angka");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Maaf tidak bisa melakukan operasi");
            }
            finally
            {
                Console.WriteLine("Terimakasih telah berkunjung");
            }
        }

        private static void exit()
        {
            Environment.Exit(0);
        }
    }
}