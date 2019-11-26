### Design Patterns - Pattern Builder

Mais informações sobre este padrão de projeto podem ser encontradas através deste [endereço](https://www.tutorialspoint.com/design_pattern/builder_pattern.htm).

Este exemplo implementa uma estratégia de Pattern Builder para a criação de objetos complexos tendo pouco acoplamento e baixa dificuldade de entendimento do que está acontecendo.
Este tipo de design provem uma das melhores maneiras de criar um objeto, pois faz o mesmo através de um passo à passo.

Passo à passo:
 * Criar as interfaces `IItem.cs` e `IPacking.cs`, que irão representar os itens comestíveis e de embalagem.
 * Criar a classe concreta que implementa a interface `IPacking.cs`.
 * Criar a classe abstrata que implementara o `IItem.cs` provendo as funcionalidades padrão.
 * Criar a classe concreta que extendera `Burguer.cs` e `ColdDrink.cs`.
 * Criar a classe `Meal.cs` tendo os objetos Item definidos anteriormente.
 * Criar a classe `MealBuilder.cs`, a atual classe builder responsável por criar os objetos do tipo _Meal_.