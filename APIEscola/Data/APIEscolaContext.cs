//Arquivo de context - responsáve  por fazer a conexão com o banco de dados
//herdando o pacote 
using APIEscola.Models;
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

        public DbSet<Aluno> Alunos { get; set; } //Cria a tabela Alunos no banco de dados

        public DbSet<Curso> Cursos { get; set; } //Cria a tabela Curso no banco de dados

        public DbSet<Turma> Turmas { get; set; } //Cria a tabela Turma no banco de dados
        public DbSet<Matricula> Matriculas { get; set; } //Cria a tabela Matricula no banco de dados


        //sobrescrever o método onmodelcreating para configurar o modelo a partir da identityDbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //chama o método OnmodelCreating da classe base para a criação das tabelas pedão
            base.OnModelCreating(modelBuilder);
            // configurar a criação de tabelas adicionais aqui 
            modelBuilder.Entity<Aluno>().ToTable("Alunos");
            modelBuilder.Entity<Curso>().ToTable("Cursos");
            modelBuilder.Entity<Turma>().ToTable("Turmas");
            modelBuilder.Entity<Matricula>().ToTable("Matriculas");


        }
    }
}
