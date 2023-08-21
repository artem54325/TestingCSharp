// // Создаем параметры для x и Id
// var xParameter = Expression.Parameter(typeof(Directory), "x");
// var idProperty = Expression.Property(xParameter, "Id");
//
// // Создаем константу для списка ids
// var idsConstant = Expression.Constant(new List<int> { 1, 2, 3 }, typeof(List<int>));
//
// // Создаем вызов метода Contains для списка ids
// var containsMethod = typeof(List<int>).GetMethod("Contains", new[] { typeof(int) });
// var containsCall = Expression.Call(idsConstant, containsMethod!, idProperty);
//
// // Создаем лямбда-выражение для x => ids.Contains(x.Id)
// var lambda = Expression.Lambda<Func<Directory, bool>>(containsCall, xParameter);
//
// var actualFilteredList = _directories.All.AsQueryable().Where(lambda).ToList();


// Так как файл не большой, то можно читать сразу весь, иначе построчно читать файл


var fileName = "./Test.txt";
var allText = File.ReadAllText(fileName);
// Предполагаю что каждое слово в новой строчке, по ТЗ не понятно
var lines = allText.Split("\n")
    .Select(ParseLine)
    .Where(q => q != null)
    .ToList();

var wordCounts = lines
    .GroupBy(word => word,
        (key, list) => new WordCount
        {
            Word = key,
            FileName = fileName,
            Count = list.Count()
        }).ToArray();

string ParseLine(string line)
{
    if (string.IsNullOrWhiteSpace(line))
        return null;
    return line.Trim();
}

public class WordCount
{
    public string Word { get; set; }
    // index
    public string FileName { get; set; }
    public int Count { get; set; } = 0;
}

/*
CREATE TABLE WordCount
(
    Word NVARCHAR(20),
    FileName NVARCHAR(20),
    Count INT
);
// index word_filename
*/