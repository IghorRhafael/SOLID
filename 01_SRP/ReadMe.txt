Single Responsibility Principle (SRP)

- O SRP afirma que uma classe deve ter apenas uma responsabilidade e uma razão para mudar.

- Benefícios:
    - Manutenção facilitada: Classes com uma responsabilidade específica são mais fáceis de entender e modificar.
    - Reutilização e Testes: Classes focadas em uma única responsabilidade são mais reutilizáveis e fáceis de testar.
    - Organização e Clareza: Cada classe tem um propósito claro.
    - Redução de Acoplamento: Cada classe pode ser alterada sem impactar outras partes desnecessariamente.

- Exemplo de Má Prática: Uma classe que lida com lógica de negócios e também se encarrega de salvar dados no banco.

- Sempre se pergunte: "Esta classe tem mais de uma razão para mudar?" se "sim", então aplique SRP.