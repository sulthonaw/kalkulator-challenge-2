# Kalkulator Challenge 2
Kalkulator sederhana yang merupakan pengembangan dari kalkulator model string dan simbol yang sebelumnya pernah saya buat [link proyek](https://github.com/sulthonaw/kalkulator-model-string-dan-simbol), yang berbeda adalah diversi ini operasi matematika bisa dilakukan beberapa kali. Dan kalkulator ini dibuat menggunakan bahasa pemrograman c#

## Instalasi
Untuk menjalankan aplikasi anda perlu menginstal c# atau dotnet pada komputer anda, berikut dokumentasi yang saya sarankan untuk anda baca:
- [Install c#](https://www.petanikode.com/cs-windows/)
- [Dokumentasi csharp](https://learn.microsoft.com/en-us/dotnet/csharp/)

## Penggunaan
Pada saat anda memulai program, anda akan mendapatkan tampilan berikut pada console
```
Input operasi :
```

Lalu, masukkan input operasi matematika yang anda inginkan pada console, contoh :
```
Input operasi : 10+5=
```
Output : 
```
Input operasi : 10+5=

Hasil = 15

Input operasi : 
```
Lalu operasi akan melakukan perulangan dan anda bisa memasukkan input operasi lagi. Jika anda ingin melakukan operasi pada operasi sebelumnya, anda hanya cukup menginputkan operator aritmatik diawal dan angka yang ingin anda eksekusi lalu tanda sama dengan diakhir, contoh :
```
Input operasi : 10+5=

Hasil = 15

Input operasi : -10=
```
Output :
```
Input operasi : 10+5=

Hasil = 15

Input operasi : -10=

Hasil = 5
```

### Perhatian ❗
- Input operasi harus berupa angka dan operator aritmatik `(+, -, *, :)`. Jika anda menginputkan selain angka dan operator aritmatik, anda akan mendapati error pada baris tertentu
- Setiap operasi harus diakhiri dengan tanda sama dengan `=`, jika tidak anda akan mendapati error pada baris tertentu
