using System;

namespace NetReactFullStack
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0, num3 = 0; // Değişkenleri başta tanımladım

            // 1: Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme
            Console.Write("Bir sayı girin: ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                if (number > 0)
                    Console.WriteLine("Pozitif");
                else if (number < 0)
                    Console.WriteLine("Negatif");
                else
                    Console.WriteLine("Sıfır");
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı giriniz!");
            }

            // 2: Gün İsmi Belirleme (switch-case)
            Console.Write("Gün numarası (1-7): ");
            if (int.TryParse(Console.ReadLine(), out int day))
            {
                switch (day)
                {
                    case 1: Console.WriteLine("Pazartesi"); break;
                    case 2: Console.WriteLine("Salı"); break;
                    case 3: Console.WriteLine("Çarşamba"); break;
                    case 4: Console.WriteLine("Perşembe"); break;
                    case 5: Console.WriteLine("Cuma"); break;
                    case 6: Console.WriteLine("Cumartesi"); break;
                    case 7: Console.WriteLine("Pazar"); break;
                    default: Console.WriteLine("Geçersiz Gün"); break;
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir gün numarası giriniz!");
            }

            // 3: Basit Hesap Makinesi (switch-case)
            Console.Write("Birinci sayı: ");
            if (double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("İkinci sayı: ");
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("İşlem seç (+, -, *, /): ");
                    char op = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    switch (op)
                    {
                        case '+': Console.WriteLine($"Sonuç: {num1 + num2}"); break;
                        case '-': Console.WriteLine($"Sonuç: {num1 - num2}"); break;
                        case '*': Console.WriteLine($"Sonuç: {num1 * num2}"); break;
                        case '/': Console.WriteLine(num2 != 0 ? $"Sonuç: {num1 / num2}" : "Bölme hatası!"); break;
                        default: Console.WriteLine("Geçersiz İşlem"); break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçerli bir ikinci sayı giriniz!");
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir birinci sayı giriniz!");
            }

            // 4: Üç Sayının En Büyüğünü Bulma (if-else)
            Console.Write("Üçüncü sayı: ");
            if (double.TryParse(Console.ReadLine(), out num3))
            {
                double max = Math.Max(num1, Math.Max(num2, num3));
                Console.WriteLine($"En Büyük Sayı: {max}");
            }
            else
            {
                Console.WriteLine("Geçerli bir üçüncü sayı giriniz!");
            }

            // 5: Şifre Güçlülüğünü Kontrol Etme (if-else)
            Console.Write("Şifrenizi girin: ");
            string password = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Şifre boş olamaz!");
            }
            else if (password.Length < 8)
            {
                Console.WriteLine("Zayıf: En az 8 karakter olmalı!");
            }
            else if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Zayıf: En az bir büyük harf olmalı!");
            }
            else if (!password.Any(c => "@#$%".Contains(c)))
            {
                Console.WriteLine("Zayıf: En az bir özel karakter olmalı!");
            }
            else
            {
                Console.WriteLine("Güçlü Şifre!");
            }

            Console.ReadLine();
        }
    }
}
