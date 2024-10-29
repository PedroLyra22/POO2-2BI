# Era da Guerra - Documentação

## Visão Geral

O projeto **Era da Guerra** é uma simulação em C# inspirada no jogo *Age of War 2*, onde dois lados se enfrentam em uma batalha estratégica com o objetivo de destruir a base inimiga. Cada base pode criar guerreiros, que se movem em direção à base oposta, enfrentando os guerreiros adversários no caminho. O projeto utiliza os princípios da **Programação Orientada a Objetos (POO)** e o **Padrão Decorator** para definir diferentes tipos de guerreiros e itens de equipamento que podem ser aplicados dinamicamente. 

### Funcionalidades

1. **Criação de Bases e Guerreiros:** As bases geram guerreiros aleatórios, que podem ser de diferentes tipos (Espadachim, Arqueiro, Cavaleiro).
2. **Decorators para Personalização dos Guerreiros:** Os guerreiros podem ser personalizados dinamicamente com equipamentos (Espada, Armadura, Anel e Esfera de Poder), que aumentam seus atributos.
3. **Sistema de Combate e Turnos:** Cada turno, os guerreiros se movem em direção à base inimiga, enfrentando oponentes e causando dano.
4. **Esfera de Poder:** A Esfera de Poder, quando coletada pelo guerreiro com o Anel, concede um aumento nos poderes de dano reflexivo.
5. **Condição de Vitória:** O jogo termina quando uma das bases é destruída.

---

## Estrutura do Projeto

### Diretórios e Arquivos

```bash
Models/                    # Modelos e classes principais
├── Base.cs                # Classe da Base
├── Guerreiro.cs           # Classe base de Guerreiros
├── Decorators/            # Decorators de equipamentos
│   ├── EspadaDecorator.cs # Decorator para adicionar espada
│   ├── ArmaduraDecorator.cs # Decorator para adicionar armadura
│   ├── AnelDecorator.cs   # Decorator para adicionar anel
│   └── EsferaDePoder.cs   # Classe que gerencia a Esfera de Poder
└── TiposDeGuerreiros/     # Decorators para tipos de guerreiros
    ├── EspadachimDecorator.cs # Decorator para Espadachim
    ├── ArqueiroDecorator.cs # Decorator para Arqueiro
    └── CavaleiroDecorator.cs # Decorator para Cavaleiro
Services/
└── JogoService.cs         # Serviço principal que gerencia o jogo
Program.cs                 # Arquivo principal para iniciar o jogo
README.md                  # Documentação do projeto
```

---

## Classes e Componentes

### 1. **Base.cs**
Representa a base de cada lado, com vida inicial e a capacidade de gerar guerreiros aleatórios.

#### Propriedades:
- `Nome`: Nome da base.
- `Vida`: Pontos de vida da base.

#### Métodos:
- `GerarGuerreiroAleatorio()`: Gera um guerreiro aleatoriamente, que pode ser Espadachim, Arqueiro ou Cavaleiro.
- `ReceberDano(int dano)`: Reduz a vida da base com base no dano recebido.

### 2. **Guerreiro.cs**
Classe base que define os atributos comuns a todos os guerreiros e a estrutura básica para o ataque e defesa.

#### Propriedades:
- `Nome`: Nome do guerreiro.
- `Ataque`: Pontos de ataque.
- `Defesa`: Pontos de defesa.
- `Vida`: Pontos de vida.

#### Métodos:
- `Atacar(Guerreiro oponente)`: Ataca um guerreiro oponente, calculando o dano com base na defesa do oponente.
- `ReceberDano(int dano)`: Reduz a vida com base no dano recebido.

### 3. **Decorators de Equipamento (Espada, Armadura, Anel)**

Esses decorators adicionam atributos ao guerreiro, oferecendo benefícios variados. Todos os equipamentos são aplicados como decoradores da classe base `Guerreiro`.

#### Exemplo: **EspadaDecorator.cs**
- Aumenta o ataque do guerreiro.

#### Exemplo: **ArmaduraDecorator.cs**
- Aumenta a defesa do guerreiro.

#### Exemplo: **AnelDecorator.cs**
- Aumenta o reflexo de dano recebido pelo guerreiro.

### 4. **EsferaDePoder.cs**
Classe que interage especificamente com o `AnelDecorator` e concede um aumento nos poderes reflexivos do guerreiro com o anel quando coletada.

#### Métodos:
- `ColetarEsfera(AnelDecorator guerreiroComAnel)`: Aumenta o dano reflexivo do guerreiro que possui o anel.

### 5. **Decorators para Tipos de Guerreiros (Espadachim, Arqueiro, Cavaleiro)**

Esses tipos de guerreiros são decorators que adicionam características únicas. 

#### Exemplo: **EspadachimDecorator.cs**
- Aumenta o ataque do guerreiro em uma quantidade fixa ao ser aplicado.

#### Exemplo: **ArqueiroDecorator.cs**
- Adiciona um bônus de ataque à distância.

#### Exemplo: **CavaleiroDecorator.cs**
- Concede uma defesa extra ao guerreiro.

### 6. **JogoService.cs**
Classe de serviço que gerencia o fluxo de turnos, movimentação e combate dos guerreiros.

#### Propriedades:
- `baseA` e `baseB`: Instâncias das bases de cada lado.
- `guerreirosA` e `guerreirosB`: Listas de guerreiros de cada lado.

#### Métodos:
- `IniciarJogo()`: Loop principal do jogo que alterna entre os turnos.
- `CriarGuerreiroDecorado(Base baseDeOrigem)`: Cria guerreiros com decorators de tipo e de equipamento.
- `ProcessarTurno()`: Gerencia a movimentação e combate dos guerreiros, além de atualizar a condição das bases.

### 7. **Program.cs**
Arquivo principal para iniciar a aplicação e executar a simulação do jogo.

---

## Exemplo de Funcionamento

### Etapas do Jogo

1. **Inicialização:** As bases `baseA` e `baseB` são criadas com vida inicial.
2. **Turnos:**
   - Cada base gera guerreiros aleatoriamente a cada turno.
   - Os guerreiros são decorados com tipos (Espadachim, Arqueiro, Cavaleiro) e equipamentos (Espada, Armadura, Anel, Esfera de Poder).
   - Os guerreiros avançam em direção à base oposta, atacando qualquer guerreiro adversário no caminho.
3. **Combate:**
   - Cada guerreiro ataca seu oponente, calculando o dano com base em seu ataque e na defesa do oponente.
   - Se um guerreiro é derrotado (vida reduzida a 0), ele é removido da lista.
4. **Ataque às Bases:**
   - Se os guerreiros de um lado derrotam todos os guerreiros oponentes no turno, eles atacam a base inimiga, reduzindo seus pontos de vida.
5. **Condição de Vitória:** O jogo termina quando uma das bases é destruída (vida = 0), e a base vencedora é declarada.

---

### Exemplo de Saída

```
--- Novo turno ---
Guerreiro da Base A (Espadachim) causou 15 de dano a Guerreiro da Base B
Guerreiro da Base B (Cavaleiro) causou 10 de dano a Guerreiro da Base A
Base B recebeu 30 de dano. Vida restante: 970
--- Novo turno ---
...
Base A foi destruída. Base B venceu!
```

---

## Expansões e Melhorias Futuras

1. **Evolução de Guerreiros:** Adicionar fases de evolução para os guerreiros com o tempo, representando o progresso de eras.
2. **Tipos Adicionais de Guerreiros e Equipamentos:** Criar novos tipos de guerreiros e equipamentos que acrescentem mais complexidade à estratégia.
3. **Habilidades Especiais:** Implementar habilidades exclusivas para cada tipo de guerreiro e equipamento, aumentando a variedade nas estratégias.
4. **Modo Multiplayer e Interface Gráfica:** Expandir o jogo para um ambiente multiplayer com interface gráfica para melhorar a experiência do usuário.

---

## Conclusão

O projeto **Era da Guerra** demonstra o uso de **POO** e do **Padrão Decorator** para criar um sistema flexível de personalização de personagens e mecânicas de jogo dinâmicas. A estrutura modular permite a fácil expansão e manutenção do código, adicionando novos tipos de guerreiros, equipamentos e habilidades sem afetar o funcionamento do sistema principal.
