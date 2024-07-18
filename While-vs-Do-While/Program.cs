
// 1 ----> ------------- While döngüsü ile --------------------

Console.WriteLine("Bir limit değeri giriniz.");
int limit = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (limit < 0)
{
    Console.WriteLine("Negatif bir limit değeri girdiniz.");
}
else
{
    while (count <= limit)
    {
        Console.WriteLine("Ben bir Patika'lıyım");
        count++;
    }
}


// 2 ----> ------------- Do - While döngüsü ile --------------------

Console.WriteLine("Bir limit değeri giriniz.");
int limit = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (limit < 0)
{
    Console.WriteLine("Negatif bir limit değeri girdiniz.");
}

else
{
    {
    }
    do
    {
        Console.WriteLine("Ben bir Patika'lıyım");
        count++;
    } while (count <= limit);
}

// Bu projede while döngüsü kullanmak daha mantıklı.
// Çünkü eklediğim negatif olmama koşulu nedeniyle negatif olma durumunda döngünün hiç çalışmaması daha mantıklı.
// Do - while kullanmak istediğimizde negatif bir değer girilmiş olsa da döngü en az 1 kere çalışacaktır..
