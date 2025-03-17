# Single Responsibility Principle (SRP)

O SRP afirma que uma classe deve ter apenas uma responsabilidade e uma razão para mudar.

## Benefícios
- **Manutenção facilitada**: Classes com uma responsabilidade específica são mais fáceis de entender e modificar.
- **Reutilização e Testes**: Classes focadas em uma única responsabilidade são mais reutilizáveis e fáceis de testar.
- **Organização e Clareza**: Cada classe tem um propósito claro.
- **Redução de Acoplamento**: Cada classe pode ser alterada sem impactar outras partes desnecessariamente.

## Exemplo de Má Prática
Uma classe que lida com lógica de negócios e também se encarrega de salvar dados no banco.

Sempre se pergunte: "Esta classe tem mais de uma razão para mudar?" Se "sim", então aplique SRP.

## Single Responsibility Principle (SRP) in English

The SRP states that a class should have only one responsibility and one reason to change.

### Benefits
- **Easier Maintenance**: Classes with a specific responsibility are easier to understand and modify.
- **Reuse and Testing**: Classes focused on a single responsibility are more reusable and easier to test.
- **Organization and Clarity**: Each class has a clear purpose.
- **Reduced Coupling**: Each class can be changed without unnecessarily impacting other parts.

### Example of Bad Practice
A class that handles business logic and also takes care of saving data to the database.

Always ask yourself: "Does this class have more than one reason to change?" If "yes", then apply SRP.
