Interface Segregation Principle (ISP)

- O ISP afima que uma interface não deve forçar classes a implementar métodos que elas não utilizam.

- Benefícios:
    - Flexibilidade e Clareza: Interfaces específicas evitam que classes implementem métodos desnecessaários.
    - Manutenção e Testes Fáceis: Classes ficam mais fáceis de manter e testar, pois têm interfaces enxutas e focadas.
    - Interfaces Enxutas: Classes implementam apenas métodos relevantes, evitando implementações vazias.
    - Facilitada de Manutenção: Mudanças afetam menos classes, pois as interfaces são específicas.

- Exemplo de Má Pratica. Interfaces grandes que obrigam classes a implementar métodos irrelevantes para elas.

- Quando projetar interfaces, pergunte-se todas as classes realmente precisarão de todos os métodos. Se a resposta for "não", é hora de aplicar ISP.