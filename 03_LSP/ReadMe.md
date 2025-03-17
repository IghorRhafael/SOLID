## Princípio da Substituição de Liskov (LSP)

- O LSP afirma que objetos de uma classe derivada devem poder substituir objetos de sua classe base sem alterar a funcionalidade do programa.

### Benefícios:
- **Consistência e Confiabilidade**: Classes derivadas devem manter o comportamento esperado da classe base.
- **Polimorfismo Seguro**: Permite que substituições sejam feitas sem quebrar o código.
- **Confiabilidade**: Evita comportamentos inesperados ao substituir classes base por derivadas.
- **Polimorfismo Correto**: Classes derivadas mantêm o contrato da classe base.

### Exemplo de Má Prática:
- Classes derivadas que alteram ou invalidam funcionalidades da classe base.

### Recomendações:
- Certifique-se de que as classes derivadas respeitam o comportamento esperado da classe base.
- Pergunte-se: "Essa classe derivada pode realmente substituir a classe base sem problemas?"

## Liskov Substitution Principle (LSP) in English

- The LSP states that objects of a derived class should be able to replace objects of its base class without altering the functionality of the program.

### Benefits:
- **Consistency and Reliability**: Derived classes should maintain the expected behavior of the base class.
- **Safe Polymorphism**: Allows substitutions to be made without breaking the code.
- **Reliability**: Prevents unexpected behaviors when replacing base classes with derived ones.
- **Correct Polymorphism**: Derived classes maintain the contract of the base class.

### Example of Bad Practice:
- Derived classes that alter or invalidate functionalities of the base class.

### Recommendations:
- Ensure that derived classes respect the expected behavior of the base class.
- Ask yourself: "Can this derived class really replace the base class without issues?"
