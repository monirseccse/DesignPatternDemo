using IteratorPattern;

var bookCollection = new BookCollection();
bookCollection.Add("a");
bookCollection.Add("b");

foreach (var item in bookCollection)
    Console.WriteLine(item);

List<int>list  = new List<int>() { 1,2,4,5};
var enumetor = list.GetEnumerator();
while (enumetor.MoveNext())
{
    Console.WriteLine(enumetor.Current);
}
