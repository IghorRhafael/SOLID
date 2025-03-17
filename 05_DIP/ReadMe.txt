Dependency Inversion Principle (DIP)

- O DIP afima que módulos de alto nível não devem depender de módulos de baixo nível, mas sim de abstrações. Abstrações não devem depender de detalhes; 
    os detalhes é que devem depender das abstrações.

- Benefícios:
    - Desacoplamento: Facilita a troca de implementações sem impactar o código de alto nível.
    - Facilidade de Teste: Módulos podem ser testados isoladamente usando abstrações, e permite a criação de mocks e stubs para testes unitários.

- Exemplo de Má Prática: Um módulo de alto nível que depende diretamente de uma classe concreta de baixo nível.

- Verifique se as classes de alto nível estão acopladas a classes de baixo nível. Se sim, considere introduzir abstrações para facilitar a manutenção e evolução do código.