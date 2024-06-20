*******************************************************
*                                                     *
*                  Doviz Ofisi Uygulaması             *
*                                                     *
*******************************************************

Bu proje, C# programlama dili ve Windows Forms kullanılarak geliştirilmiş bir döviz ofisi uygulamasıdır. Uygulama, Türkiye Cumhuriyet Merkez Bankası'nın (TCMB) günlük döviz kurlarını kullanarak döviz alım-satım işlemleri yapmanızı sağlar.

## Özellikler

- Güncel döviz kurlarını TCMB web sitesinden çeker.
- Dolar ve Euro için alış ve satış kurlarını gösterir.
- Kullanıcının girdiği miktara göre döviz alım ve satım hesaplamaları yapar.
- Kur ve miktar bilgilerine göre toplam tutarı hesaplar.
- Kalan miktarı hesaplama özelliği.

## Nasıl Çalıştırılır

1. **Gereksinimler:**
   - Visual Studio veya benzeri bir C# IDE (Integrated Development Environment) gereklidir.
   - .NET Framework veya .NET Core ortamı.
   - İnternet bağlantısı (güncel döviz kurlarını çekmek için).

2. **Projeyi İndirme:**
   - Bu repository'i klonlayın veya ZIP olarak indirin.

3. **Visual Studio ile Açma:**
   - Visual Studio'yu açın.
   - Proje dosyasını (`Doviz_Ofisi.sln`) açın.

4. **Proje Derleme ve Çalıştırma:**
   - Projeyi derleyin (`Ctrl + Shift + B`).
   - Projeyi başlatmak için `Start` düğmesine basın (`F5`).

5. **Uygulamayı Kullanma:**
   - Uygulama açıldığında, güncel döviz kurları otomatik olarak yüklenecektir.
   - Döviz alış veya satış kurunu görmek için ilgili butona tıklayın (örneğin, `btnDolarAlis` veya `btnEuroSatis`).
   - Döviz miktarını `txtMiktar` alanına girin.
   - Döviz kurunu `txtKur` alanına girin veya butonlara tıklayarak doldurun.
   - `btnSatisYap` butonuna tıklayarak toplam tutarı hesaplayın.
   - `btnSatisYap2` butonuna tıklayarak kalan miktarı hesaplayın.

## Kod Açıklamaları

- **Form1_Load:** Form yüklendiğinde güncel döviz kurlarını TCMB web sitesinden çeker ve ilgili etiketlere (`label2`, `label4`, `label7`, `label8`) yerleştirir.
- **btnDolarAlis_Click, btnDolarSatis_Click, btnEuroAlis_Click, button4_Click:** İlgili butonlar tıklandığında `txtKur` alanına ilgili döviz kurunu yerleştirir.
- **btnSatisYap_Click:** Döviz alım/satım miktarına göre toplam tutarı hesaplar ve `txtTutar` alanına yazar.
- **btnSatisYap2_Click:** Döviz alım/satım miktarına göre toplam tutarı hesaplar, kalan miktarı `txtKalan` alanına yazar.
- **txtKur_TextChanged:** `txtKur` alanına girilen değeri, nokta yerine virgül kullanarak günceller.

---

Uygulamanın Ekran Görüntüsü:

![Doviz Ofisi Uygulaması Ekran Görüntüsü](path/to/screenshot.png)

