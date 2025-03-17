/// <summary>
/// Good example of code,
/// The Report class has only one responsibility, it generates the report.
/// 
/// - Divide responsibilities into specialized classes.
/// - Each class should have only one responsibility.
/// 
/// Bom exemplo de código,
/// A classe Relatorio tem apenas uma responsabilidade, ela gera o relatório.
/// 
/// - Divida as responsabilidades em classes especializadas.
/// - Cada classe deve ter apenas uma responsabilidade.
/// </summary>

namespace SOLID._01_SRP.Good;

public class Report

{
    public void Generate()
    {
        Console.WriteLine("Generating report");
    }
}

public class PrintService
{
    public void Print(Report report)
    {
        Console.WriteLine("Printing report");
    }
}

public class ReportRepository
{
    public void Save(Report report)
    {
        Console.WriteLine("Saving report");
    }
}