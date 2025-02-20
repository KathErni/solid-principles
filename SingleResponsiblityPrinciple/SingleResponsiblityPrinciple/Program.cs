class Program
{
    static void Main(string[] args)
    {
        Report report = new Report();
        report.GenerateReport("This is some content.");

        ReportFormatter formatter = new ReportFormatter();
        report.Content = formatter.FormatReport(report.Content);

        ReportSaver saver = new ReportSaver();
        saver.SaveToFile("report.txt", report.Content);

        FileLoader loader = new FileLoader();
        loader.LoadFromFile("report.txt");
    }
}
public class Report
{
    public string Content { get; set; }

    public Report()
    {

    }

    public void GenerateReport(string content)
    {
        Content = content;
    }
}
public class ReportFormatter
{
    public string FormatReport(string content)
    {
        return content.ToLower();
    }
}

public class ReportSaver
{
    public void SaveToFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }
}

public class FileLoader
{
    public string LoadFromFile(string filename)
    {
        return File.ReadAllText(filename);
    }
}

