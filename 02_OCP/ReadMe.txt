Open/Closed Principle (OCP)

- O OCP afirma que as classes devem estar "abertas para extensão, mas fechadas para modificação"

- Benefícios:
    - Facilidade de Extensão. Novas funcionalidades podem ser adicionadas sem alterar o código existente.
    - Redução de Bugs: Minima o risco de introduzir erros em funcionalidades já implementadas.
    - Facilidade de Manutenção: Código já existente não é alterado, evitando a introdução de novos bugs.
    - Extensibilidade: Novos comportamentos são adicionados por meio de novas classes.

- Exemplo de Má Prática: Modificar uma classe diretamente para adicionar um novo comportamento.

- Pense em como tornar o código extensível. A adição de novas funcionalidades não deve sifnificar modificar o código existente.