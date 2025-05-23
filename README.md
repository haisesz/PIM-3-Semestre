Como usar o programa:

PostgreSQL instalado e em execução localmente

Visual Studio (ou outro ambiente de desenvolvimento C#)

Pacote Npgsql instalado (via NuGet)

Configuração do Banco de Dados
Antes de iniciar o programa, você precisa configurar o banco de dados PostgreSQL:

Crie um banco de dados chamado pim.

Execute os scripts SQL disponíveis na pasta scripts/ do repositório.

Eles criam as tabelas departamento, funcionario e chamado.

Também inserem os departamentos iniciais: RH, Produção e Gerência.

Certifique-se de que a string de conexão nos arquivos .cs aponte corretamente para seu banco.

A padrão utilizada é:
``
Host=localhost;Port=5432;Database=pim;User ID=postgres;Password=belofode``

Você pode ajustar conforme suas credenciais no PostgreSQL.



