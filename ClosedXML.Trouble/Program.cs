using ClosedXML.Report;

var resultPath = "C:/Projects/ClosedXML.Trouble/result.xlsx"; //TODO сюда путь до файла
var templatePath = "C:/Projects/ClosedXML.Trouble/Template.xlsx"; //TODO сюда путь до файла
var template = new XLTemplate(templatePath);

var dto = new Dto
{
    Test = "Название",
    Table1 = Enumerable.Range(0, 1).Select(x => new Table { Name = $"Имя {x}" }).ToArray(),
    Table2 = Enumerable.Range(0, 5).Select(x => new Table { Name = $"Имя {x}" }).ToArray(),
    Table3 = Enumerable.Range(0, 5).Select(x => new Table { Name = $"Имя {x}" }).ToArray(),
};

template.AddVariable(dto);
template.Generate();

template.SaveAs(resultPath);

public class Dto
{
    public string Test { get; set; }
    public Table[] Table1 { get; set; }
    public Table[] Table2 { get; set; }
    public Table[] Table3 { get; set; }
}

public class Table
{
    public string Name { get; set; }
}