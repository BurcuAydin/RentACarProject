using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda. ";

        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarsPriceInvalid = "Araba günlük fiyatı 0'dan büyük olmalıdır.";
        public static string CarDeleted = "Araba silindi.";

        public static string CarImageAdded="Araba fotoğrafı eklendi.";
        public static string CountOfImageLimitError="Bir araca en fazla 5 fotoğraf eklenebilir.";
        public static string CarImageDeleted="Araca ait fotoğraf silindi.";

        public static string BrandAdded="Marka eklendi.";
    }
}
