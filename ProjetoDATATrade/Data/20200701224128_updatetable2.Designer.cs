﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoDATATrade.Data;

namespace ProjetoDATATrade.Data
{
    [DbContext(typeof(IESContext))]
    [Migration("20200701224128_updatetable2")]
    partial class updatetable2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoDATATrade.Models.Carteira", b =>
                {
                    b.Property<int>("CarteiraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Lucro")
                        .HasColumnType("real");

                    b.Property<float>("Saldo")
                        .HasColumnType("real");

                    b.Property<float>("TotalAcumulado")
                        .HasColumnType("real");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("CarteiraID");

                    b.HasIndex("UsuarioID")
                        .IsUnique();

                    b.ToTable("Carteiras");
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Estrategia", b =>
                {
                    b.Property<int>("EstrategiaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Como")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEstrategia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Onde")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Porque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quando")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("EstrategiaID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Estrategias");
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Indicador", b =>
                {
                    b.Property<int>("InidicadorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TraderID")
                        .HasColumnType("int");

                    b.HasKey("InidicadorID");

                    b.HasIndex("TraderID");

                    b.ToTable("Indicadores");
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Login", b =>
                {
                    b.Property<int>("LoginID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("LoginID");

                    b.HasIndex("UsuarioID")
                        .IsUnique();

                    b.ToTable("Login");
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Operacao", b =>
                {
                    b.Property<int>("OperacaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Carteira")
                        .HasColumnType("real");

                    b.Property<string>("DataeHora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstrategiaID")
                        .HasColumnType("int");

                    b.Property<string>("EstrategiaOperacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Lote")
                        .HasColumnType("real");

                    b.Property<int>("NumeroOperacao")
                        .HasColumnType("int");

                    b.Property<string>("Ordem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PrecoEntrada")
                        .HasColumnType("real");

                    b.Property<float>("Resultado")
                        .HasColumnType("real");

                    b.Property<float>("Risco")
                        .HasColumnType("real");

                    b.Property<float>("StopLoss")
                        .HasColumnType("real");

                    b.Property<float>("TakeProfit")
                        .HasColumnType("real");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("OperacaoID");

                    b.HasIndex("EstrategiaID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Operacoes");
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.PerfilTrader", b =>
                {
                    b.Property<int>("PerfilTraderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PerfilTraderID");

                    b.ToTable("perfilTraders");
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Trader", b =>
                {
                    b.Property<int>("TraderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AtivoOperado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiasOperacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioOperacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IndicadorID")
                        .HasColumnType("int");

                    b.Property<string>("IndicadorTrader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("InvestimentoMensal")
                        .HasColumnType("real");

                    b.Property<float>("LimitePerdaDiaria")
                        .HasColumnType("real");

                    b.Property<float>("LimitePerdaMensal")
                        .HasColumnType("real");

                    b.Property<float>("LimitePerdaSemanal")
                        .HasColumnType("real");

                    b.Property<float>("ObjetivoGanhoDiario")
                        .HasColumnType("real");

                    b.Property<float>("ObjetivoGanhoMensal")
                        .HasColumnType("real");

                    b.Property<float>("ObjetivoGanhoSemanal")
                        .HasColumnType("real");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PerfilTraderID")
                        .HasColumnType("int");

                    b.Property<string>("PrincipaisCandle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TempoInvestimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("TraderID");

                    b.HasIndex("PerfilTraderID")
                        .IsUnique();

                    b.HasIndex("UsuarioID")
                        .IsUnique();

                    b.ToTable("Traders");
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Carteira", b =>
                {
                    b.HasOne("ProjetoDATATrade.Models.Usuario", "Usuario")
                        .WithOne("Carteira")
                        .HasForeignKey("ProjetoDATATrade.Models.Carteira", "UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Estrategia", b =>
                {
                    b.HasOne("ProjetoDATATrade.Models.Usuario", "Usuario")
                        .WithMany("Estrategias")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Indicador", b =>
                {
                    b.HasOne("ProjetoDATATrade.Models.Trader", "Trader")
                        .WithMany("Indicadores")
                        .HasForeignKey("TraderID");
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Login", b =>
                {
                    b.HasOne("ProjetoDATATrade.Models.Usuario", "Usuario")
                        .WithOne("Login")
                        .HasForeignKey("ProjetoDATATrade.Models.Login", "UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Operacao", b =>
                {
                    b.HasOne("ProjetoDATATrade.Models.Estrategia", "Estrategia")
                        .WithMany("Operacoes")
                        .HasForeignKey("EstrategiaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoDATATrade.Models.Usuario", "Usuario")
                        .WithMany("Operacoes")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoDATATrade.Models.Trader", b =>
                {
                    b.HasOne("ProjetoDATATrade.Models.PerfilTrader", "PerfilTrader")
                        .WithOne("Trader")
                        .HasForeignKey("ProjetoDATATrade.Models.Trader", "PerfilTraderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoDATATrade.Models.Usuario", "Usuario")
                        .WithOne("Trader")
                        .HasForeignKey("ProjetoDATATrade.Models.Trader", "UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
