namespace SOLID._01_SRP.Good;

public class Report
{
    /*
    Bom exemplo de código,
    A classe Relatorio tem apenas uma responsabilidade, ela gera o relatório.

    - Divida as responsabilidades em classes especializadas.
    - Cada classe deve ter apenas uma responsabilidade.
        
    */
    public void Generate()
    {
        // Generate report
    }
}

public class PrintService
{
    public void Print(Report report)
    {
        // Print report
    }
}

public class ReportRepository
{
    public void Save(Report report)
    {
        // Save report
    }
}