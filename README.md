# 🚗 Explorando Orientação a Objetos em C\#

## Verificação de Veículo Apto

### 📌 Descrição

Este projeto consiste em um aplicativo simples para **monitoramento de carros**, cujo objetivo é verificar se um veículo está **apto para rodar** com base em seu ano de fabricação e no ano atual.

Um carro é considerado **apto** se tiver até **10 anos de uso**.
Para resolver este desafio, foram aplicados conceitos de **Programação Orientada a Objetos (POO)** em C#, como:

* Estruturação da lógica em classes;
* Definição de **métodos estáticos**, permitindo a verificação sem a necessidade de instanciar objetos;
* Retorno do resultado de forma organizada e clara.


### 📝 Entrada

O programa solicita as seguintes informações:

1. **Modelo do carro** (String)
2. **Ano de fabricação** (int)
3. **Ano atual** (int)


### 📤 Saída

O programa retorna uma mensagem indicando se o carro está **Apto** ou **Não apto** para rodar, no seguinte formato:

```
[Modelo]: Apto
```

ou

```
[Modelo]: Nao apto
```


### 📊 Exemplos de execução

| Entrada               | Saída         |
| --------------------- | ------------- |
| Civic / 2015 / 2025   | Civic: Apto   |
| Gol / 2012 / 2025     | Gol: Nao apto |
| Corolla / 2018 / 2025 | Corolla: Apto |


### ⚙️ Estrutura do Projeto

O código foi desenvolvido em **C#** utilizando os princípios de POO.

* **Classe**: responsável por organizar a lógica de verificação.
* **Método Estático**: realiza a checagem da aptidão do carro sem criar instâncias.


### ▶️ Como Executar

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/veiculo-apto.git
   ```
2. Acesse a pasta do projeto:

   ```bash
   cd veiculo-apto
   ```
3. Compile e execute o programa em C#:

   ```bash
   dotnet run
   ```

### 🚀 Tecnologias Utilizadas

* Linguagem: **C#**
* Paradigma: **Programação Orientada a Objetos (POO)**
* Framework: **.NET**


### 📚 Habilidades e Aprendizados Desenvolvidos

Durante o desenvolvimento deste projeto, foi possível exercitar e consolidar diferentes competências:

* Estruturação do código com **classes e métodos**.
* Aplicação prática de **métodos estáticos**.
* Uso de **condições lógicas** para resolver problemas do mundo real.
* Boas práticas na separação de **entrada, processamento e saída**.
* Manipulação de **strings** e **números inteiros** em C#.
* Experiência na execução de programas no ambiente **.NET**.

### 📌 Principais Competências

✔️ Fundamentos de **POO em C#**
✔️ Criação e uso de **métodos estáticos**
✔️ Estruturação de programas com **entrada e saída padronizadas**
✔️ Raciocínio lógico aplicado a regras de negócio
✔️ Prática com **.NET CLI** e execução de programas em console


### 🔧 Pontos de Melhoria

Embora o projeto atenda ao desafio proposto, alguns pontos podem ser aprimorados em versões futuras:

* Permitir que o usuário insira múltiplos veículos em uma mesma execução.
* Implementar **tratamento de erros** para entradas inválidas (ex.: ano negativo ou não numérico).
* Criar uma interface gráfica simples para interação mais intuitiva.
* Adicionar testes automatizados para validar os casos de uso.
* Refatorar o código para aplicar princípios de **SOLID** em POO.


