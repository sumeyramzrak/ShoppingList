# ShoppingList
Bootcamp Final Project

#Hakkında
ShoppingList sayesinde almayı planladığınız ürünleri kaydedip takibini yapabileceksiniz.

# Başlangıç

Projenin 'API' katmanı ```'ASP.NetCore Web API'``` ile oluşturulmuştur. 
```'Code First' ``` anlayışı benimsenmiştir. 
Proje tasarımında ```CQRS Pattern```, ```IUnitOfWork Pattern```, ```RepositoryDesign Pattern``` kullanılmıştır.
Proje içerisinde ``` Microsoft.EntityFrameworkCore```, ``` AutoMapper```,``` MediatR```kütüphaneleri kullanılmıştır. 
```SOLID``` prensiblerine uyulmuştur. 

Uygulamanın kullanıma hazırlanması için gereksinimler :
```
-Visual Studio 2022
```
```
-'SQL SERVER' ile bağlantılı herhangi bir Database uygulaması
```
# Uygulamanın Kullanımı

**API Katmanı için**:

-İlgili repository code kısmındaki HTTPS linkini Git Bash terminalinize kopyalayıp,localinize klonlayınız.(clon komutu=>git clone <repositoryLinki>)

Klasördeki ```'Tlp.ShoppingList.sln'``` uygulamasını çalıştırınız. 

-Açılan uygulamada api katmanında bulunan ```'Tlp.ShoppingList.Api'``` projesinin içerisindeki ```'appsettings.Development.json'``` ve ```'appsettings.json'``` dosyalarında yazılı olan server bağlantı kodunu kendi ```'SQL SERVER'``` bağlantınıza göre ayarlayınız.

```("Server=localhost,[port bilgisi];Database=TlpDb;User Id=[kullanıcı Id];Password=[şifre]")```
	
- ```'Tlp.ShoppingList.Data.Seed'``` içerisinde kullanılmak üzere seed veriler hazırlanmıştır.

-Migration dosyası projenin içerisinde hazır olduğu için gerekli verileri database aktarmak için ```'_docs/Migration.txt'``` içerisindeki 
```
"Update-Database -P Tlp.ShoppingList.Persistence -Context AppDbContext -S Tlp.ShoppingList.Api"
```
komut kopyalanıp ```"Package Manager Console" ```bölümünde çalıştırılmalıdır. 

-Update-Database komutu çalıştırıldıktan sonra API katmanı ve database hazır olacaktır. 

Test süreçlerinin gerçekleştirilebilmesi için sql dosyası içerisindeki query leri ilgili databaselerde çalıştırınız.

-Bu adımları tamamladıktan sonra uygulamayı üst sekmede bulunan yeşil ok simgeli Run butonu ile çalıştırınız. 
-'API' browser **açılmadan** çalışmaya başlayacaktır