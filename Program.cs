//1. soru

Console.WriteLine("Kaç adet sayı gireceksiniz ? :");
int sayiAdet = int.Parse(Console.ReadLine());

int[] sayilar = new int[sayiAdet];

for(int i = 0; i < sayiAdet; i++){
    Console.WriteLine("{0}. sayıyı giriniz", i+1);
    sayilar[i] =int.Parse(Console.ReadLine());
}

Console.WriteLine("girilen çift sayılar: ");
foreach (var item in sayilar)
{
    if(item%2==0){
        Console.WriteLine(item);
    }
}


//2. soru

Console.WriteLine("Kaç adet sayı gireceksiniz ? :");
int n = int.Parse(Console.ReadLine());


Console.WriteLine("Bir sayı daha giriniz :");
int m = int.Parse(Console.ReadLine());

int[] yeniSayilar = new int[n];

for(int i = 0; i < n; i++){
    Console.WriteLine("{0}. sayıyı giriniz", i+1);
    yeniSayilar[i] =int.Parse(Console.ReadLine());
}

foreach (var item in yeniSayilar)
{
    if(item % m == 0 || item == m){
        Console.WriteLine(item);
    }
}


//3. soru

Console.WriteLine("Kaç adet kelime gireceksiniz ? :");
int kelimeSayisi = int.Parse(Console.ReadLine());

String[] kelimeler = new String[kelimeSayisi];

for(int i=0; i<kelimeSayisi; i++){
    Console.WriteLine("{0}. kelimeyi giriniz", i+1);
    kelimeler[i] =Console.ReadLine();
}

for(int i=kelimeSayisi-1; i>=0; i--){
    Console.WriteLine(kelimeler[i] + " ");
}

//4. soru

Console.WriteLine("Bir cümle giriniz: ");
String cümle = Console.ReadLine();

//int harfSayisi = cümle.length;

//boşluğa göre kelimeler ayrıldı
string[] kelimeler = cümle.Split(' ');

int kelimeSayisi = kelimeler.Length;

// Boşluk olmayan kelimeleri yeni bir dize olarak birleştirelim
string yeniCümle = string.Join("", kelimeler);

int harfSayisi = yeniCümle.Length;

Console.WriteLine("Kelime sayısı: "+kelimeSayisi+" Harf sayısı: "+harfSayisi );
