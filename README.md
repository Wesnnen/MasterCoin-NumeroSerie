# Gerador de Sequências de Número de Série

Este projeto é um **gerador de sequências de números de série** que permite ao usuário gerar uma quantidade específica de números de série com base em um número de série inicial. O número de série pode ser composto por letras (A-Z) e números (0-9), utilizando um sistema **base 32**, ou seja, os caracteres disponíveis para incremento são de `0` a `9` e `A` a `Z`. Após `9`, o próximo caractere será `A`, e após `Z`, o número será reiniciado para `0`.

## Funcionalidades

- **Entrada de Número de Série Inicial**: O usuário fornece um número de série inicial composto por letras e números. A sequência será gerada com base nesse número.
- **Validação do Número de Série**: O número de série deve ser composto apenas por caracteres alfanuméricos (de `A-Z` e `0-9`), e cada caractere é tratado como parte de um sistema baseado em 32.
- **Entrada de Quantidade de Sequências**: O usuário pode determinar quantas novas sequências deseja gerar.
- **Incremento das Sequências**: O programa incrementa a sequência com base no sistema base 32, de forma inteligente, tratando transbordamentos de caracteres.
- **Exibição das Sequências Geradas**: O programa exibe as sequências geradas após o número de série inicial, até a quantidade solicitada.

## Como Funciona

1. **Número de Série Inicial**: O programa solicita que o usuário insira um número de série inicial, composto por letras e números (por exemplo, `abc99z`). Este número será utilizado para gerar as sequências subsequentes.
   
2. **Validação do Número de Série**: O número de série inserido é validado para garantir que ele contenha apenas caracteres alfanuméricos (letras `A-Z` e números `0-9`). Caso contrário, o programa emite um erro.

3. **Quantas Sequências?**: O usuário informa quantas novas sequências ele deseja gerar. O número de série será incrementado com base na quantidade de sequências solicitadas.

4. **Incremento das Sequências**: O programa percorre o número de série de trás para frente, incrementando a última posição de acordo com o sistema base 32. Se ocorrer um transbordamento (como de `9` para `A` ou de `Z` para `0`), o incremento será corretamente tratado.

5. **Exibição das Sequências Geradas**: As novas sequências geradas são exibidas uma a uma, após o número de série inicial, até a quantidade solicitada.

## Sistema Base 32

O sistema utilizado neste programa é baseado em 32 caracteres possíveis, que são:

- **Números**: 0-9
- **Letras**: A-Z

O incremento é feito da seguinte maneira:

- De `0` a `9`: O caractere é incrementado para o próximo número.
- De `9` para `A`: Após o número `9`, o caractere passa para `A`.
- De `Z` para `0`: Quando o caractere `Z` é atingido, o próximo caractere será `0`.

## Testes

Aqui estão os testes principais para validar o funcionamento do programa:

### Teste 1: Validação do Número de Série

**Objetivo**: Verificar se o programa valida corretamente a entrada do número de série, aceitando apenas caracteres alfanuméricos e garantindo que as letras e números estejam dentro dos limites corretos.

**Entrada**:
```plaintext
Digite o número de série inicial (ex: abc99z): abc!@#
```
**Resultado Esperado**:

```plaintext
Erro: O número de série deve conter apenas letras e números!
```
**Entrada**:

```plaintext
Digite o número de série inicial (ex: abc99z): abc99z
```

**Resultado Esperado**:

```plaintext
Número de série válido.
```
## Teste 2: Quantidade de Sequências
**Objetivo**: Validar se a quantidade de sequências solicitada pelo usuário é um número inteiro positivo.

**Entrada**:

```plaintext
Digite a quantidade de novas sequências a serem geradas: -5
```
**Resultado Esperado**:

```plaintext
Erro: A quantidade deve ser um número inteiro positivo!
```

**Entrada**:

```plaintext
Digite a quantidade de novas sequências a serem geradas: 3
```
**Resultado Esperado**:

```plaintext
Sequências geradas: 
abc9a0
abc9a1
abc9a2
```
## Teste 3: Incremento de Sequências
**Objetivo**: Verificar se o programa gera corretamente as sequências seguintes, lidando com os casos de transbordamento de caracteres, como de '9' para 'A' e de 'Z' para '0'.

**Entrada**:

```plaintext
Digite o número de série inicial (ex: abc99z): abc99z
Digite a quantidade de novas sequências a serem geradas: 3
```
**Resultado Esperado**:

```plaintext
ABC9A0
ABC9A1
ABC9A2
```
**Entrada**:

```plaintext
Digite o número de série inicial (ex: abc99z): abz9z
Digite a quantidade de novas sequências a serem geradas: 5
```
**Resultado Esperado**:

```plaintext
ABZA0
ABZA1
ABZA2
ABZA3
ABZA4
```

## Teste 4: Transbordamento Completo (De 'Z' a '0')
**Objetivo**: Validar o comportamento do programa quando a sequência atingir o valor 'Z' e precisar reiniciar para '0'.

**Entrada**:

```plaintext
Digite o número de série inicial (ex: abc99z): abz99z
Digite a quantidade de novas sequências a serem geradas: 3
```
**Resultado Esperado**:

```plaintext
ABZ9A0
ABZ9A1
ABZ9A2
```
# Como Executar
1. Compile e execute o programa.
2. Digite o número de série inicial no formato desejado (letras e números).
3. Informe a quantidade de sequências a serem geradas.
4. O programa irá gerar e exibir as novas sequências baseadas na sequência inicial.


