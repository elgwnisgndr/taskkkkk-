//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            RezervasiyaSay();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Xeta: {ex.Message}");
//        }
//        finally
//        {
//            Console.WriteLine("Sistem baglandi ");
//        }
//    }
//    static void RezervasiyaSay()
//    {
//        Console.WriteLine("Nece neferlik olacaq?");
//        int nefer = int.Parse(Console.ReadLine());
//        if (nefer <= 0)
//        {
//            throw new Exception("Nefer sayi 0-dan kicik ve ya berabere ola bilmez");
//        }
//        if (nefer > 10)
//        {
//            throw new Exception("Nefer sayi 10-dan boyuk ola bilmez");
//        }
//        Console.WriteLine($"Rezervasiya qebul edilmisdir!");

//    }

//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            BarkodNomresi();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Xeta: {ex.Message}");
//        }
//        finally
//        {
//            Console.WriteLine("Barkod yoxlamasi basa catdi! ");
//        }
//    }

//    static void BarkodNomresi()
//    {
//        Console.WriteLine("Barkod nomresini daxil edin:");
//        string barkod = Console.ReadLine();

//        if (barkod.Length != 12)
//        {
//            throw new Exception("Barkod nomresi 12 simvoldan ibaret olmalidir.");
//        }
//        string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
//        foreach (char c in barkod)
//        {
//            if (letters.Contains(c))
//            {
//                throw new Exception("Barkod nomresi yalniz reqemlerden ibaret olmalidir.");
//            }
//        }
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            SeriyaNomresi();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Xeta: {ex.Message}");
//        }
//        finally
//        {
//            Console.WriteLine("Sened yoxlamasi basa catdi! ");
//        }
//        static void SeriyaNomresi()
//        {
//            Console.WriteLine("Sexiyyetin seriya nomresini daxil edin:");
//            string seriya = Console.ReadLine();
//            if (!seriya.StartsWith("AZE"))
//            {
//                throw new Exception("Seriya nomresi 'AZE' ile baslamalidir.");
//            }
//            if (seriya.Length < 8 && !seriya.All(char.IsDigit))
//            {
//                throw new Exception("Seriya nomresi yalniz reqemlerden ibaret olmalidir.");
//            }
//            {
//                throw new Exception("Seriya nomresi en azi 8 simvoldan ibaret olmalidir.");
//            }
//        }
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            ImtahanNeticesi();
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Xeta: Daxil edilen melumat reqem olmalidir!");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Xeta: {ex.Message}");
//        }
//        finally
//        {
//            Console.WriteLine("Imtahan neticesi yoxlamasi basa catdi! ");
//        }
//    }
//    static void ImtahanNeticesi()
//    {
//        Console.WriteLine("imtahan neticesini daxil edin!(0-100):" );
//        int netice = int.Parse(Console.ReadLine());
//        if (netice < 0 || netice > 100)
//        {
//            throw new Exception("bal duzgun araliqda deyil!");
//        }
//        if (netice >= 90)
//        {
//            Console.WriteLine("Ela");
//        }
//        else if (netice >= 80)
//        {
//            Console.WriteLine("Yaxsi");
//        }
//        else if (netice >= 70)
//        {
//            Console.WriteLine("orta");
//        }
//        else if (netice >= 60)
//        {
//            Console.WriteLine("Kafi");
//        }
//        else
//        {
//            Console.WriteLine("Kesildiniz");
//        }
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            User();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Xeta: {ex.Message}");
//        }
//        finally
//        {
//            Console.WriteLine("Istifadeci yoxlamasi basa catdi! ");
//        }
//        static void User()
//        {
//            string[] ValidUsers = { "admin", "user1", "guest" };
//            string[] ValidPasswords = { "admin123", "user123", "guest123" };

//            Console.WriteLine("Istifadeci adini daxil edin:");
//            string username = Console.ReadLine();

//            Console.WriteLine("Sifreni daxil edin:");
//            string password = Console.ReadLine();

//            bool isValidUser = false;
//            for (int i = 0; i < ValidUsers.Length; i++)
//            {
//                if (username == ValidUsers[i] && password == ValidPasswords[i])
//                {
//                    isValidUser = true;
//                    break;
//                }
//            }
//            if (!isValidUser)
//            {
//                throw new Exception("Istifadeci adi ve ya sifre sehvdir.");
//            }
//            else
//            {
//                Console.WriteLine("Ugurla daxil oldunuz!");
//            }
//        }
//    }
//}
