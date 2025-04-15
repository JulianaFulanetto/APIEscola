//Arquivo de context - responsáve  por fazer a conexão com o banco de dados
//herdando o pacote 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext //Que o arquivo de contexto herde do IdentityDbContext
    {

        //Método construtor - pegue todas as options q jogue no meu context 
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options) : base(options)
        {
        }

        //sobrescrever o método onmodelcreating para configurar o modelo a partir da identityDbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //chama o método OnmodelCreating da classe base para a criação das tabelas pedão
            base.OnModelCreating(modelBuilder);
            // configurar a criação de tabelas adicionais aqui 

        }
    }
}
