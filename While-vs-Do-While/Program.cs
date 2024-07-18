
// 1 ----> ------------- While döngüsü ile --------------------

Console.WriteLine("Bir limit değeri giriniz.");
string textpatika = "Ben bir Patika'lıyım!";
int input = Convert.ToInt32(Console.ReadLine());
int count = 0;

Console.WriteLine("With while : ");
while (count <= input)
{
    Console.WriteLine(textpatika);
    count++;
}


// 2 ----> ------------- Do - While döngüsü ile --------------------

count = 0;             // do - while döngüsünü de yapabilmek için sayacı sıfırlıyoruz.
Console.WriteLine("With do - while : ");
do
{
    Console.WriteLine(textpatika);
    count++;
} while (count <= input);

// Bu projede negatif bir değer girildiği zaman fark açıkça görülüyor.
// -4 gibi bir değer girildiğinde while döngüden direk çıkarken do-while bir kere çalıştırıyor.
