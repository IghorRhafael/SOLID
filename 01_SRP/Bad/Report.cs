/// <summary>
/// Bad example of code,
/// The Report class has more than one responsibility, it generates, saves, and prints the report.
/// 
/// - Divide the responsibilities into specialized classes.
/// - Each class should have only one responsibility.
/// 
/// Mau exemplo de código,
/// A classe Relatorio tem mais de uma responsabilidade, ela gera, salva e imprime o relatório.
/// 
/// - Divida as responsabilidades em classes especializadas.
/// - Cada classe deve ter apenas uma responsabilidade.
/// </summary>

namespace SOLID._01_SRP.Bad;

public class Report
{
    public void Generate()
    {        
        Console.WriteLine("Generating report");
    }

    public void Save()
    {
        Console.WriteLine("Saving report");
    }

    public void Print()
    {
        Console.WriteLine("Printing report");
    }
}