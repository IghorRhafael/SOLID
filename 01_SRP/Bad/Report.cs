namespace SOLID._01_SRP.Bad;

public class Report
{
/*
Mau exemplo de código,
A classe Relatorio tem mais de uma responsabilidade, ela gera, salva e imprime o relatório.

*/

    public void Generate()
    {
        // Generate report
    }

    public void Save()
    {
        // Save report
    }

    public void Print()
    {
        // Print report
    }
}