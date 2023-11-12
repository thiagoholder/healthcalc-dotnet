# HealthCalc

## Descrição

O HealthCalc é um projeto que calcula o Índice de Massa Corporal (IMC), classifica o resultado e realiza o cálculo de macronutrientes. Essa ferramenta é valiosa para aqueles que desejam monitorar sua saúde e bem-estar. Abaixo, detalhamos como a aplicação funciona:

## Funcionamento

### Cálculo do IMC

O IMC é calculado usando a fórmula IMC = peso (kg) / (altura (m) * altura (m)). O resultado é categorizado de acordo com as classificações padrão do IMC.

### Cálculo de Macronutrientes

A proporção de macronutrientes (carboidratos, proteínas e gorduras) é determinada com base nos objetivos do usuário (perda de peso, manutenção de peso, ganho de peso) e nas diretrizes nutricionais recomendadas. Os valores são exibidos em gramas.

## Benefícios

Os usuários podem monitorar seu IMC, uma métrica importante para avaliar o peso corporal. A aplicação ajuda a entender a classificação do IMC e os riscos associados à categoria. A determinação dos macronutrientes oferece uma orientação dietética personalizada, auxiliando os usuários em suas metas de saúde e condicionamento físico.

## Notas Adicionais

É fundamental lembrar que esta aplicação fornece informações gerais e não substitui a orientação de um profissional de saúde ou nutricionista. Recomenda-se consultar um profissional antes de realizar mudanças significativas na dieta ou no estilo de vida.

## Pré-requisitos

- Visual Studio 2022 ou posterior.
- .NET 7.0 SDK.
- xUnit.net para execução de testes.

## Configuração do Projeto

1. Clone este repositório em sua máquina local: [https://github.com/thiagoholder/healthcalc-dotnet.git](https://github.com/thiagoholder/healthcalc-dotnet.git)
2. Certifique-se de ter o .NET 7.0 SDK instalado.
3. Restaure as dependências do NuGet usando o seguinte comando:

   ```
   dotnet restore
   ```

4. Compile o projeto novamente.

## Estrutura do Projeto

```
healthcalc-dotnet/
|-- healthcalc-console-ditnet
|-- healthcalc-pack-dotnet
|-- healthcalc-pack-tests
```

## Executando Testes

dotnet test

## Uso do Pacote

Você pode usar o pacote fornecido para calcular o IMC e os macronutrientes. O pacote está disponível no NuGet. Para instalá-lo, execute o seguinte comando:

```
dotnet add package healthcalc-ninegroup --version 1.0.0
```

## Contribuição

Se desejar contribuir para este projeto, siga estas etapas:

1. Faça um clone do repositório.
2. Crie uma nova branch para sua contribuição: `git checkout -b feature/sua-contribuicao`.
3. Faça suas alterações e adicione testes, se necessário.
4. Envie um pull request.

## Autores

- Thiago Holder
- Dara Negreiros
- Deivis Neves
- Mariana Terra