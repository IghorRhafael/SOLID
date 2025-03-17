# Interface Segregation Principle (ISP)

## O que é o ISP?

O ISP afirma que uma interface não deve forçar classes a implementar métodos que elas não utilizam.

## Benefícios

- **Flexibilidade e Clareza**: Interfaces específicas evitam que classes implementem métodos desnecessários.
- **Manutenção e Testes Fáceis**: Classes ficam mais fáceis de manter e testar, pois têm interfaces enxutas e focadas.
- **Interfaces Enxutas**: Classes implementam apenas métodos relevantes, evitando implementações vazias.
- **Facilidade de Manutenção**: Mudanças afetam menos classes, pois as interfaces são específicas.

## Exemplo de Má Prática

Interfaces grandes que obrigam classes a implementar métodos irrelevantes para elas.

## Dica de Design

Quando projetar interfaces, pergunte-se se todas as classes realmente precisarão de todos os métodos. Se a resposta for "não", é hora de aplicar ISP.

## Interface Segregation Principle (ISP) in English

### What is ISP?

The ISP states that an interface should not force classes to implement methods they do not use.

### Benefits

- **Flexibility and Clarity**: Specific interfaces prevent classes from implementing unnecessary methods.
- **Easy Maintenance and Testing**: Classes are easier to maintain and test because they have lean and focused interfaces.
- **Lean Interfaces**: Classes implement only relevant methods, avoiding empty implementations.
- **Ease of Maintenance**: Changes affect fewer classes because the interfaces are specific.

### Example of Bad Practice

Large interfaces that force classes to implement irrelevant methods.

### Design Tip

When designing interfaces, ask yourself if all classes will really need all the methods. If the answer is "no," it's time to apply ISP.
