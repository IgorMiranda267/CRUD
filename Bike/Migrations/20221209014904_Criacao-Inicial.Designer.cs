// <auto-generated />
using System;
using BikeVale.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BikeVale.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221209014904_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BikeVale.Models.Aluga", b =>
                {
                    b.Property<int>("IdAluga")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Aluga");

                    b.Property<int>("IdAtendente")
                        .HasColumnType("int");

                    b.Property<int>("IdBicicleta")
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdHistorico")
                        .HasColumnType("int");

                    b.HasKey("IdAluga");

                    b.HasIndex("IdAtendente")
                        .IsUnique();

                    b.HasIndex("IdBicicleta")
                        .IsUnique();

                    b.HasIndex("IdCliente")
                        .IsUnique();

                    b.HasIndex("IdHistorico")
                        .IsUnique();

                    b.ToTable("Aluga");
                });

            modelBuilder.Entity("BikeVale.Models.Atendente", b =>
                {
                    b.Property<int>("IdAtendente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Atendente");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Cpf");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Endereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Telefone");

                    b.HasKey("IdAtendente");

                    b.ToTable("Atendente");
                });

            modelBuilder.Entity("BikeVale.Models.Bicicleta", b =>
                {
                    b.Property<int>("Idbicicleta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Bicicleta");

                    b.Property<string>("Modalidade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Modalidade");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Modelo");

                    b.Property<int>("QtdMarchas")
                        .HasColumnType("int")
                        .HasColumnName("Qte-Marchas");

                    b.Property<int>("StatusEmprestimo")
                        .HasColumnType("int")
                        .HasColumnName("Status-Emprestimo");

                    b.HasKey("Idbicicleta");

                    b.ToTable("Bicicleta");
                });

            modelBuilder.Entity("BikeVale.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Cliente");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Cidade");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Endereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Telefone");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("BikeVale.Models.Historico", b =>
                {
                    b.Property<int>("IdHistorico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Historico");

                    b.Property<DateTime>("DataAluguel")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("Data-Alugel");

                    b.Property<string>("LocalPasseio")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Local-Passeio");

                    b.Property<int>("TempoAluguel")
                        .HasColumnType("int")
                        .HasColumnName("Tempo-Aluguel");

                    b.HasKey("IdHistorico");

                    b.ToTable("Historico");
                });

            modelBuilder.Entity("BikeVale.Models.Manutencao", b =>
                {
                    b.Property<int>("IdManutencao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Manutencao");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("Data");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Descricao");

                    b.Property<double>("Preco")
                        .HasColumnType("double")
                        .HasColumnName("Preco");

                    b.HasKey("IdManutencao");

                    b.ToTable("Manutancao");
                });

            modelBuilder.Entity("BikeVale.Models.Possui", b =>
                {
                    b.Property<int>("IdPossui")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Possui");

                    b.Property<int>("IdAtendente")
                        .HasColumnType("int")
                        .HasColumnName("Id_Atendente");

                    b.Property<int>("IdBicicleta")
                        .HasColumnType("int")
                        .HasColumnName("Id_Bicicleta");

                    b.Property<int>("IdManutencao")
                        .HasColumnType("int")
                        .HasColumnName("Id_Manutencao");

                    b.HasKey("IdPossui");

                    b.HasIndex("IdAtendente")
                        .IsUnique();

                    b.HasIndex("IdBicicleta")
                        .IsUnique();

                    b.HasIndex("IdManutencao")
                        .IsUnique();

                    b.ToTable("Possui");
                });

            modelBuilder.Entity("BikeVale.Models.Aluga", b =>
                {
                    b.HasOne("BikeVale.Models.Atendente", "Atendente")
                        .WithOne("Aluga")
                        .HasForeignKey("BikeVale.Models.Aluga", "IdAtendente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BikeVale.Models.Bicicleta", "Bicicleta")
                        .WithOne("Aluga")
                        .HasForeignKey("BikeVale.Models.Aluga", "IdBicicleta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BikeVale.Models.Cliente", "Cliente")
                        .WithOne("Aluga")
                        .HasForeignKey("BikeVale.Models.Aluga", "IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BikeVale.Models.Historico", "Historico")
                        .WithOne("Aluga")
                        .HasForeignKey("BikeVale.Models.Aluga", "IdHistorico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atendente");

                    b.Navigation("Bicicleta");

                    b.Navigation("Cliente");

                    b.Navigation("Historico");
                });

            modelBuilder.Entity("BikeVale.Models.Possui", b =>
                {
                    b.HasOne("BikeVale.Models.Atendente", "Atendente")
                        .WithOne("Possui")
                        .HasForeignKey("BikeVale.Models.Possui", "IdAtendente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BikeVale.Models.Bicicleta", "Bicicleta")
                        .WithOne("Possui")
                        .HasForeignKey("BikeVale.Models.Possui", "IdBicicleta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BikeVale.Models.Manutencao", "Manutencao")
                        .WithOne("Possui")
                        .HasForeignKey("BikeVale.Models.Possui", "IdManutencao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atendente");

                    b.Navigation("Bicicleta");

                    b.Navigation("Manutencao");
                });

            modelBuilder.Entity("BikeVale.Models.Atendente", b =>
                {
                    b.Navigation("Aluga")
                        .IsRequired();

                    b.Navigation("Possui")
                        .IsRequired();
                });

            modelBuilder.Entity("BikeVale.Models.Bicicleta", b =>
                {
                    b.Navigation("Aluga")
                        .IsRequired();

                    b.Navigation("Possui")
                        .IsRequired();
                });

            modelBuilder.Entity("BikeVale.Models.Cliente", b =>
                {
                    b.Navigation("Aluga")
                        .IsRequired();
                });

            modelBuilder.Entity("BikeVale.Models.Historico", b =>
                {
                    b.Navigation("Aluga")
                        .IsRequired();
                });

            modelBuilder.Entity("BikeVale.Models.Manutencao", b =>
                {
                    b.Navigation("Possui")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
