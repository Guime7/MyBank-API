﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Infrastructure.Data.Database;
using Infrastructure.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Database.Configurations
{
    public partial class extrato_cartaoConfiguration : IEntityTypeConfiguration<extrato_cartao>
    {
        public void Configure(EntityTypeBuilder<extrato_cartao> entity)
        {
            entity.Property(e => e.data).HasColumnType("date");

            entity.Property(e => e.data_pgto_fatura).HasColumnType("date");

            entity.Property(e => e.descricao)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.fatura).HasColumnType("date");

            entity.Property(e => e.status_fatura).HasDefaultValueSql("((0))");

            entity.Property(e => e.valor).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.id_cartaoNavigation)
                .WithMany(p => p.extrato_cartao)
                .HasForeignKey(d => d.id_cartao)
                .HasConstraintName("FK_extrato_cartao_id_cartao");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<extrato_cartao> entity);
    }
}
