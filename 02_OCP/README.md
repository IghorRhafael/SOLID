## Princípio Aberto/Fechado (OCP)

- O OCP afirma que as classes devem estar "abertas para extensão, mas fechadas para modificação".

### Benefícios:
- **Facilidade de Extensão**: Novas funcionalidades podem ser adicionadas sem alterar o código existente.
- **Redução de Bugs**: Minimiza o risco de introduzir erros em funcionalidades já implementadas.
- **Facilidade de Manutenção**: Código já existente não é alterado, evitando a introdução de novos bugs.
- **Extensibilidade**: Novos comportamentos são adicionados por meio de novas classes.

### Exemplo de Má Prática:
- Modificar uma classe diretamente para adicionar um novo comportamento.

### Dica:
- Pense em como tornar o código extensível. A adição de novas funcionalidades não deve significar modificar o código existente.

## Open/Closed Principle (OCP) in English

- The OCP states that classes should be "open for extension, but closed for modification."

### Benefits:
- **Ease of Extension**: New functionalities can be added without altering existing code.
- **Reduction of Bugs**: Minimizes the risk of introducing errors into already implemented functionalities.
- **Ease of Maintenance**: Existing code is not altered, avoiding the introduction of new bugs.
- **Extensibility**: New behaviors are added through new classes.

### Example of Bad Practice:
- Modifying a class directly to add new behavior.

### Tip:
- Think about how to make the code extensible. Adding new functionalities should not mean modifying existing code.
