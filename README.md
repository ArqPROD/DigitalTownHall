# Atividade 05

API de serviços para um cenário de uma transformação
digital de um prefeitura, composto dos seguintes serviços de utilidade
pública para cidadãos.

*URL Swagger:* http://localhost:49318/swagger

# Serviços Exemplo
OBS: Os endereços enviador as URL's da api são aceitos apenas endereços que estão armazenados na memória do Serviço.

- Consulta de IPTU [Recebe o código cadastral do imóvel e devolve o imposto a ser pago]  
*URL:* http://localhost:49318/api/v1.0/imovel/consulta\_iptu/1

- Consulta de Coleta de Lixo [Recebe o logradouro.]  
*URL:* http://localhost:49318/api/v1.0/aluno/historico_aluno/1

- Solicitação de Poda de Árvore [Recebe o logradouro.]  
*URL:* http://localhost:49318/api/v1.0/servico\_publico/poda_arvore  
param = { "Logradouro": "Rua Sumarã", "Numero": 100, "Cidade": "Contagem" } }

- Solicitação de Construção de Meio-Fio [Recebe o logradouro.]  
*URL:* http://localhost:49318/api/v1.0/servico\_publico/construcao\_meio\_fio  
param = { "Logradouro": "Rua Sumarã", "Numero": 100, "Cidade": "Contagem" } }

- Solicitação de Recolhimento de Carros Abandonados [Recebe o logradouro.]  
*URL:* http://localhost:49318/api/v1.0/servico\_publico/recolhimento\_carro\_abandonado  
param = { "Logradouro": "Rua Sumarã", "Numero": 100, "Cidade": "Contagem" } }

- Solicitação de Desobstrução de Vias Públicas [Recebe o logradouro.]  
*URL:* http://localhost:49318/api/v1.0/servico\_publico/desobstrucao\_via\_publica  
param = { "Logradouro": "Rua Sumarã", "Numero": 100, "Cidade": "Contagem" } }

- Solicitação de Desobstrução de Córregos [Recebe o logradouro.]  
*URL:* http://localhost:49318/api/v1.0/servico\_publico/desobstrucao\_corrego  
param = { "Logradouro": "Rua Sumarã", "Numero": 100, "Cidade": "Contagem" } }

- Solicitação de Coleta de Animal Morto [Recebe o logradouro.]  
*URL:* http://localhost:49318/api/v1.0/servico\_publico/coleta\_animal\_morto  
param = { "Logradouro": "Rua Sumarã", "Numero": 100, "Cidade": "Contagem" } }

- Solicitação de Limpeza de Boca de Lobo [Recebe o logradouro.]  
*URL:* http://localhost:49318/api/v1.0/servico\_publico/limpeza\_boca\_lobo  
param = { "Logradouro": "Rua Sumarã", "Numero": 100, "Cidade": "Contagem" } }

- Consulta de Histórico de Aluno de Rede Pública [Recebe o código do aluno e devolve o histórico do mesmo.]  
*URL:* http://localhost:49318/api/v1.0/aluno/historico_aluno/1

- Pedido de adoção de cães [Recebe o CPF, endereço e dados cadastrais do cidadão.]  
*URL:* http://localhost:49318/api/v1.0/animal/adocao\_cao  
param = { "Cpf": "12345678901", "Endereco": { "Logradouro": "Rua Sumarã", "Numero": 100, "Cidade": "Contagem" } }

- Pedido de adoção de gatos [Recebe o CPF, endereço e dados cadastrais do cidadão.]   
*URL:* http://localhost:49318/api/v1.0/animal/adocao\_gato  
param = { "Cpf": "12345678901", "Endereco": { "Logradouro": "Rua Sumarã", "Numero": 100, "Cidade": "Contagem" } }


