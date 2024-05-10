# Desafio Técnico para Analista de Qualidade

Muito obrigado por reservar um tempo para fazer nosso teste técnico :)

O intuito do teste técnico é avaliar seus conhecimentos com:

1. Documentação de casos de Teste
2. Implementação de Testes Automatizados
3. Documentação de Bugs ou Defeitos

## eWay2: E-Commerce dedicado para venda de produtos da Way2.

Nosso time de desenvolvimento implementou uma nova API para gerenciar o processo de Compra dos Produtos dentro do E-Commerce. A aplicação permite que os usuários selecionem os produtos, adicionem ao carrinho e finalizem a compra.

Nosso time é bem ligado com qualidade de software e está procurando um Analista de Qualidade que teste de forma eficaz os endpoints disponibilizados nessa nova API.

Com esse propósito chamamos você que será o responsável por realizar os testes necessários. 

### A aplicação deve cumprir com os requisitos detalhados a continuação:

1. Retornar requests em formato JSON: A aplicação deve retornar detalhes em formato JSON, seguindo as práticas de API RESTful.
2. Verificar Estoque ao Adicionar Produto ao Carrinho: Antes de adicionar um produto ao carrinho, a aplicação deve verificar se há estoque disponível do produto.
3. Verificar o Produto no Carrinho ao Remover: Ao remover um produto do carrinho, a aplicação deve verificar se o produto está presente no carrinho antes de removê-lo.
4. Calcular o Valor Total ao Finalizar a Compra: Ao finalizar uma compra, a aplicação deve calcular corretamente o valor total da compra, incluindo o preço dos produtos, impostos, frete e descontos.

Seu objetivo é garantir a qualidade da aplicação na hora de executar o processo de compra. 
Para isto deverá documentar todos os casos de teste levantados no formato sugerido identificando possíveis problemas e desenvolver dois testes automatizados que ajudem a garantir a integridade da aplicação.

### Parte 1: Documentação de Casos de Teste com Gherkin:

Utilizando a linguagem Gherkin, documente cinco cenários de teste para o processo de compra. Cada cenário deve seguir a estrutura típica de Given-When-Then e cobrir diferentes aspectos da funcionalidade, como:

```Feature: Compra de Produtos

Cenário: Obter produto por id
  Dado: que acessei ao endpoint ObterProdutoPorId passando o Id do Produto
  Quando: executo a ação para retornar o Produto
  Devo: receber uma resposta no padrão RESTFull com formato JSON com código de resposta 200 e no corpo do resultado devem vir os dados do Produto solicitado

# Adicione outros cenários aqui
```

### Parte 2: Criação de Testes Automatizados:

Automatize dois Casos de teste levantados por você que verifiquem se os requisitos foram atendidos conforme o esperado. Cumpra com os requisitos a seguir:

* Utilize um framework de teste de sua escolha, como CYPRESS, Selenium, etc.
* Certifique-se de que os testes sejam claros, concisos e abordem diferentes cenários possíveis.
* Execute os testes automatizados desenvolvidos.
* Prepare um relatório resumindo os resultados dos testes, incluindo:
  
  -	Número total de testes executados.
    
  -	Número de testes bem-sucedidos e falhos.
    
  -	Descrição das falhas encontradas, incluindo detalhes sobre os cenários em que ocorreram.

### Parte 3: Documentação dos bugs detectados:

Documente pelo menos dois bugs ou defeitos seguindo o formato definido a continuação:

**Título:**
*título do problema*

**Descrição:**
*breve descrição do problema*

**Cenário de teste:**
*cenário/ambiente/condições onde o problema acontece*

**Evidências:**
*prints/mensagens dos resultados do teste*

**Providencias:**
*o que deve ser ajustado, qual é o resultado esperado após correção do problema*

## Critérios de avaliação

O resultado do desafio deverá ser entregue num documento (word) dividido nas sessões definidas anteriormente:

1. Documentação de casos de Teste
2. Implementação de Testes Automatizados
3. Documentação de Bugs ou Defeitos

O prazo de entrega do desafio é de 5 dias corridos.
Não compartilhe este teste com ninguém.
Seja original e criativo nas respostas.
Se ajuste ao conhecimento próprio, somos muito ligados com sinceridade e honestidade.

**Muito obrigado!**
