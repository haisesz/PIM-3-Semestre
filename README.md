# Sistema de Chamados - PIM

Este projeto é um sistema básico de gerenciamento de chamados com autenticação de usuários, utilizando C# com PostgreSQL.

---

## ✅ Requisitos

Antes de executar o projeto, certifique-se de ter:

- PostgreSQL instalado e em execução localmente
- Visual Studio (ou outro ambiente de desenvolvimento C#)
- Pacote `Npgsql` instalado (via NuGet)

---

## ⚙️ Configuração do Banco de Dados

1. Crie um banco de dados chamado `pim` no PostgreSQL.
2. Execute os scripts SQL disponíveis na pasta `scripts/` do repositório.
   - Eles criam as tabelas `departamento`, `funcionario` e `chamado`.
   - Também inserem os departamentos iniciais: **RH**, **Produção** e **Gerência**.

---

## 🔌 String de Conexão

A string de conexão agora está centralizada na classe `Conexao.cs`:

```csharp
public static class Conexao
{
    public static string ConexaoString { get; } =
        "Host=localhost;Port=5432;Database=pim;User ID=postgres;Password=belofode";
}
