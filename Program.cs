using System;

namespace Auth
{
    class Program
    {
        static void Main(string[] args)
        {
            string
                kullanici,
                sifre; 
            int hak=3;        

            while (hak>0)
            {

                 Console.Write("Kullanıcı : ");
            kullanici = Console.ReadLine()!;

            Console.Write("Şifre : ");
            sifre = Console.ReadLine()!;
                 if (kullanici == "admin" && sifre == "123456")
            {
                Console.WriteLine("Hoşgeldiniz!");
                break;
            }
            else
            {
                hak--;   
                Console.WriteLine(" KullanıHatalıcı adı / Şifre! {0} adet hakkınız kaldı!", hak); 

                if (hak<=0)
                {
                Console.WriteLine("Çok sayıda hatalı giriş yaptığınız için. Ip Adresiniz engellenmiştir! Lütfen 5 dk sona tekrar deneyiniz."); 
                    
                }
                            
            }
            }


           
        }
    }
}
