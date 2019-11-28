# BoasPraticasCSharp
Repositório contém os conteúdos da Alura sobre Boas Práticas com C#.

Implementado exemplo dos padrões:
 * Builder => Classes que simplificam a criação de objetos complexos, a implementa métodos que populam as informações do objeto complexo e também um método que retorna o objeto complexo.
 * Chain of Responsability => Interface com Métodos que define uma responsabilidade, as classes que a implementam verificar se as responsabilidade condiz à ela ou se deve encaminhar para outra classe.
 * Decorator => Composição de métodos através de classes abstratas que auxilia na composição de resultados entre instancias diferentes.
 * Observer => Implementação de uma interface que é herdada por classes que implementam uma rotina que deve ser executada em dada mudança de estado da classe pai, a classe pai por vez tem uma propriedade com todas as ações e também tem uma iteração executando as ações que compõem o Observer.
 * State => Implementação de uma interface genérica para a definição de estados de uma classe pai, com ela é possível executar tarefas de maneiras específicas para cada estado que implementa a interface.
 * Strategy => Interfaces com Métodos que devem ser implementados pelos classes, permitindo que a chamada seja genérica e alterada em tempo de execução.
 * Template Method => Classes abstratas que tem parte da implementação comum e tem lacunas de implementação para ser feito pelas classes concretas...


 * Factory => Classe que simplifica a criação de objetos, ele é muito parecido com o __Pattern Builder__ porém a diferença entre eles é que o __Factory__ utiliza sempre os mesmos parâmetros para a instanciar o objeto.


Exemplos Implementados:

__Parte 1__
 * [Builder Pattern](https://github.com/edu-tomasi/BoasPraticasCSharp/blob/master/DesignPatternsParteUm/PatternBuilder-GeradorDeNotaFiscal/Exemplo%20Tutorials%20Point/exemplo.md)
 * [Chain of Responsability Pattern](https://github.com/edu-tomasi/BoasPraticasCSharp/blob/master/DesignPatternsParteUm/PatternChainOfResponsibility-DescontosOr%C3%A7amento/ExemploTutorialsPoint/exemplo.md)
 * [Decorator Pattern ](https://github.com/edu-tomasi/BoasPraticasCSharp/blob/master/DesignPatternsParteUm/PatternDecorator-ImpostosCompostos/ExemploTutorialsPoint/exemplo.md)
 * [Observer Pattern](https://github.com/edu-tomasi/BoasPraticasCSharp/blob/master/DesignPatternsParteUm/PatternObserver-ExecutandoAcoesDiferentes/Exemplo%20Tutorials%20Point/exemplo.md)
 * [State Pattern](https://github.com/edu-tomasi/BoasPraticasCSharp/blob/master/DesignPatternsParteUm/PatternState-VariacaoEstadoOrcamento/ExemploTutorialsPoint/exemplo.md)
 * [Strategy Pattern](https://github.com/edu-tomasi/BoasPraticasCSharp/blob/master/DesignPatternsParteUm/PatternStrategy-MuitosImpostos/ExemploTutorialsPoint/exemplo.md)
 * [Template Pattern](https://github.com/edu-tomasi/BoasPraticasCSharp/blob/master/DesignPatternsParteUm/PatternTemplateMethod-Or%C3%A7amentoImpostos/ExemploTutorialsPoint/exemplo.md)

 __Parte 2__
 * [Factory Pattern](https://github.com/edu-tomasi/BoasPraticasCSharp/blob/master/DesignPatternsParteDois/PatternFactory-CriandoConexaoComDb/Exemplo%20Tutorials%20Point/exemplo.md)