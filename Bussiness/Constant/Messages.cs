using Core.Entities.Concrete;
using System;

namespace Business.Constant
{
    public class Messages
    {
        public static string NotAuthorized = "Yetkiniz Yok";
        public static string RestaurantNotAdded = "adlı restoran daha önce eklenmiştir";
        public static string RestaurantAdded = "Restoran ekleme işlemi başarılı";

        public static string UserFirstNameNotEmpty = "Ad Boş Geçilmemeli";
       

        public static string RestaurantDeleted = "Restoran kayıtlardan silinmiştir.";
        public static string RestaurantUpdated ="Restoran güncellenmiştir.";
        public static string AccessTokenCreated= "Oturum Açıldı";
        public static string UserAlreadyExist = "Daha önce kayıt yapılmış";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string PasswordError = "Parola Hatalı";

        public static string UserNotFound = "Kullanıcı Bulunamadı";

        public static string UserRegistered = "Hoşgeldiniz";
        public static string UserAdded = "Kayıt Başarılı";
        public static string UserDeleted = "Kullanıcı Silindi";

        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserFirstNameMinimumLength = "Minimum 3 karakter ile oluşturunuz.";

        public static string UserLastNameNotEmpty = "Soyad Boş Geçilmemeli";

        public static string UserEmailAddress = "Lütfen sadece email adresi giriniz.";

        public static string UserEmailNotEmpty = "Email adresini boş bırakmayınız.";
    }
}