Kütüphane Otomasyon Sistemi Bu proje, bir kütüphane otomasyon sistemini yönetmek için geliştirilmiş bir yazılımdır. Kullanıcılar kitap ödünç alabilir, iade edebilir, kitap ekleyebilir, düzenleyebilir ve silebilir. Sistem aynı zamanda ödünç alma işlemi sırasında gecikme cezasını hesaplayarak yönetir.

Proje Yapısı Proje, aşağıdaki modüllerden oluşmaktadır:

Kütüphane Sistemi: Kitap yönetimi, kullanıcı yönetimi, ödünç alma ve iade işlemleri. Veritabanı: Kullanıcı bilgileri, kitaplar ve ödünç kitaplar için SQL Server veritabanı. Raporlama: Popüler kitaplar ve aktif kullanıcılar için raporlar. Kurulum Aşağıdaki adımları izleyerek projeyi bilgisayarınıza kurabilirsiniz.

Gerekli Yazılımlar Visual Studio: Projeyi derlemek ve çalıştırmak için Visual Studio gereklidir. SQL Server Management Studio (SSMS): Veritabanını yönetmek için SSMS'e ihtiyaç vardır.

Projeyi Klonlayın GitHub üzerindeki proje deposunu bilgisayarınıza klonlayın: git clone https://github.com//kutuphane.git

Veritabanını Geri Yükleyin Veritabanı Dosyasını Bulma: Proje dosyalarınız içinde database klasörüne gidin. Burada .bak uzantılı bir yedek dosyası bulunmaktadır. SQL Server'a Yükleme: SQL Server Management Studio'yu (SSMS) açın. "Veritabanları" sekmesine sağ tıklayın ve "Veritabanı Yedekle"yi seçin. .bak dosyasını seçin ve geri yükleyin.

SQL Bağlantısını Düzenleyin Projede kullanılan SQL Server bağlantısını kendi bilgisayarınıza göre düzenlemeniz gerekir.

Bağlantı Dizesini Bulun: Projeye ait Controller dosyalarına gidin. Bağlantı dizesi genellikle şu şekilde tanımlanır:

private readonly string _connectionString = "Data Source=TALHAY\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;"; Bağlantı Dizesini Düzenleyin: Eğer SQL Server'ınız farklı bir sunucuya veya instance'a kuruluysa, Data Source kısmını değiştirin. Örnek: private readonly string _connectionString = "Data Source=YourServerName;Initial Catalog=KutuphaneDB;Integrated Security=True;"; YourServerName kısmını kendi SQL Server instance adınızla değiştirin. 5. Projeyi Çalıştırın Visual Studio'yu açın ve projeyi Kutuphane.sln dosyasını kullanarak açın.

Projeyi Çalıştırmak İçin: Visual Studio'da F5 tuşuna basın veya "Çözümü Derle" seçeneğini kullanarak projeyi çalıştırabilirsiniz. Katkıda Bulunma Bu proje açık kaynaklıdır. Katkıda bulunmak isterseniz, aşağıdaki adımları takip edebilirsiniz:

Proje deposunu fork edin. Yeni bir branch oluşturun. Yaptığınız değişiklikleri commit edin ve pull request oluşturun.
