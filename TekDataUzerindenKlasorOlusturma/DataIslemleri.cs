using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekDataUzerindenKlasorOlusturma
{
    public class DataIslemleri
    {

        public void KlasorOlusturma(List<Kisi> liste)
        {
            foreach (var item in liste)
            {
                if (Directory.Exists("C:\\Sınıf403\\" + item.ulke))
                { }

                else {
                    Directory.CreateDirectory("C:\\Sınıf403\\" + item.ulke);
                    File.Create("C:\\Sınıf403\\" + item.ulke +"\\"+item.isim+"."+item.soyisim);
                }

            }
            

        }
        public List<Kisi> KisiGetir()
        {

            List<Kisi> liste = new List<Kisi>();

            for (int i = 1; i < 100; i++)
            {
                Kisi k = new Kisi();
                k.id = i;
                k.isim = FakeData.NameData.GetFirstName();
                k.soyisim = FakeData.NameData.GetSurname();
                k.email = FakeData.NetworkData.GetEmail();
                k.ulke = FakeData.PlaceData.GetCountry();
                liste.Add(k);
            }
            return liste;
        }

    }

   
}
