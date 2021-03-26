using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        /* Car */
        public static string CarAdded = "Yeni araç eklendi";
        public static string CarEdited = "Araç bilgisi düzenlendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarModelInvalid = "Araç modeli 2000'den küçük olamaz";
        public static string CarMaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Araçlar listelendi";
        public static string CarNotFound = "Araç bulunamadı";

        /* Brand */
        public static string BrandAdded = "Yeni marka eklendi";
        public static string BrandEdited = "Marka bilgisi düzenlendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Markalar listelendi";

        /* Color */
        public static string ColorAdded = "Yeni renk eklendi";
        public static string ColorEdited = "Renk bilgisi düzenlendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorListed = "Renkler listelendi";

        /* User */
        public static string UserAdded = "Yeni kullanıcı eklendi";
        public static string UserEdited = "Kullanıcı bilgisi düzenlendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserListed = "Kullanıcılar listelendi";

        /* Customer */
        public static string CustomerAdded = "Yeni müşteri eklendi";
        public static string CustomerEdited = "Müşteri bilgisi düzenlendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerListed = "Müşteriler listelendi";

        /* Customer */
        public static string RentalAdded = "Kiralama bilgisi eklendi";
        public static string RentalEdited = "Kiralama bilgisi düzenlendi";
        public static string RentalDeleted = "Kiralama iptal edildi";
        public static string RentalListed = "Tüm kiralananlar listelendi";

        /* Car Image */
        public static string CarImageLimit = "Fotoğraf limit sayısına ulaşıldı";
        public static string CarImageAdded = "Fotoğraf eklendi";
        public static string CarImageDeleted = "Fotoğraf silindi";
        public static string CarImageNotDeleted = "Fotoğraf silinirken bir hata oluştu";
        public static string CarImageNotFound = "Araca ait fotoğraf bulunamadı";
        public static string IdError = "Id numarasına ait kayıt bulunamadı";
        public static string CarImageUpdated = "Araç fotoğrafı güncellendi";
    }
}
