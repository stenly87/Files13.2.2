// Тема 13.2, Задание 2

// Создадим файл с книгами
/*using (var fs = File.Create("Bibl"))
using (var bw = new BinaryWriter(fs))
{
    bw.Write(6);*/
/* запись книг с консоли
for (int i = 0; i < 10; i++)
{
    bw.Write(Console.ReadLine());
    bw.Write(Console.ReadLine());
    bw.Write(int.Parse(Console.ReadLine()));
}
*/
/*bw.Write("Иванов");
bw.Write("Информатика");
bw.Write(1980);

bw.Write("Петров");
bw.Write("Информатика");
bw.Write(1990);

bw.Write("Сидоров");
bw.Write("Как не опоздать на пары");
bw.Write(2023);

bw.Write("Пушкин");
bw.Write("Как отчислить студентов");
bw.Write(2016);

bw.Write("Михайлюк");
bw.Write("Не родись красивой");
bw.Write(2000);

bw.Write("Побежимов");
bw.Write("Опасные рассказы про PHP");
bw.Write(2020);
}
*/

// Задание а
/*Console.WriteLine("Фамилия автора?");
string searchAuthor = Console.ReadLine();

using (var fs = File.OpenRead("Bibl"))
using (var br = new BinaryReader(fs))
{
    int countBook = br.ReadInt32(); // кол-во книг
    for (int i = 0; i < countBook; i++)
    {
        string author = br.ReadString();
        string book = br.ReadString();
        int year = br.ReadInt32();

        if (author == searchAuthor && year >= 1960)
            Console.WriteLine($"{book} - {year}г.");
    }
}*/

// Задание б
using (var fs = File.OpenRead("Bibl"))
using (var br = new BinaryReader(fs))
{
    int countBook = br.ReadInt32(); // кол-во книг
    for (int i = 0; i < countBook; i++)
    {
        string author = br.ReadString();
        string book = br.ReadString();
        int year = br.ReadInt32();

        if (book == "Информатика")
            Console.WriteLine($"{author} - {year}г.");
    }
}