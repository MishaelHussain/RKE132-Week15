
string[] data = GetDataFromMyFile(); 
ReadDataFromArray(data);


foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] { ';'}, StringSplitOptions.RemoveEmptyEntries);
}
static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Users\37255\Downloads\movies.txt";
    return File.ReadAllLines(filePath);

} 

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
} 

class Movie
{
    string title;
    string year; 

    public Movie(string _title, string _year)
    {
        title = title; 
        year = _year;
    }
}