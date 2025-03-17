Liskov Substitution Principle (LSP)

- O LSP afirma que objetos de uma classe derivada devem poder substituir objetos de sua classe base sem alterar a funcionalidade do programa.

- Benefício:
    - Consistência e Confiabilidade: Classes derivadas devem manter o comportamento esperado da classe base.
    - Polimorfismo Seguro: Permite que substituições sejam feitas sem quebrar o código.
    - Confiabilidade: Evita comportamentos inesperados ao substituir classes base por derivadas
    - Polimorfismo Correto: Classes derivadas mantêm o contrato da classe base.

- Exemplo de Má Prática: Classes derivadas que alteram ou invalidam funcionalidades da classe base.

- Certifique-se de que as classes derivadas respeitam o comportamento esperado da classe base.

- Pergunte-se: "Essa classe derivada pode realmente substituir a classe base sem problemas?"