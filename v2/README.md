# Kalkulator Challenge 2: Model String dan Simbol
Kalkulator sederhana yang merupakan pengembangan dari [Kalkulator Sederhana: Model String dan Simbol](https://github.com/sulthonaw/kalkulator-model-string-dan-simbol), yang berbeda adalah diversi ini operasi matematika bisa dilakukan beberapa kali. Dan kalkulator ini dibuat menggunakan bahasa pemrograman c#.

## Demo
![](https://github.com/sulthonaw/kalkulator-challenge-2/blob/main/v2/assets/D__titip_kalkulator-challenge-2_v2_bin_Debug_net7.0_ModelStringDanSimbol.exe-2023-03-20-11-10-57.gif)

## Installasi 
Untuk menjalankan proyek kalkulator sederhana ini, Anda harus memiliki environment berikut terlebih dahulu:
- Microsoft Visual Studio 2022 atau versi yang lebih baru
- .NET Framework 4.7.2 atau versi yang lebih baru

Saran dokumentasi:
- [Visual Studio](https://visualstudio.microsoft.com/)
- [.Net](https://dotnet.microsoft.com/en-us/)
- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)

## Usage
1. Sebelum anda menggunakan kalkulator ini, pastikan anda sudah memenuhi syarat installasi agar program berjalan sesuai alurnya.
2. Clone repository kedalam komputer anda dan buka di IDE Visual Studio.
3. Run program atau anda bisa menggunakan shortcut F5, dan anda akan melihat sebuah console dengan output sebagai berikut:

    ```
    Input operasi :
    ```
    
    Untuk mengisi output tersebut ada beberapa syarat agar program tidak mencapai error. yaitu :
    - Inputan tidak boleh mengandung spasi
    - Inputan hanya bisa melakukan satu operasi matematika, cth : `(10*5+11=) tidak bisa digunakan`
    - Inputan harus diakhiri tanda sama dengan `=`
    - Berikut merupakan tabel acuan untuk melakukan operasi aritmatik:
    
        | Operasi   | Kata  | 
        |----------|:-------------:|
        | Tambah |  `+` |
        | Kurang |    `-`   |  
        | Kali | `*` |  
        | Bagi | `:` |  
4. Lalu operasi akan melakukan perulangan dan anda bisa memasukkan input operasi lagi. Jika anda ingin melakukan operasi pada operasi sebelumnya, anda hanya cukup menginputkan operator aritmatik diawal dan angka yang ingin anda eksekusi lalu tanda sama dengan diakhir, contoh :
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
    15 - 10

    Hasil = 5
    ```
5. Jika anda masih bingung, anda bisa melihat live demo setelah judul.


