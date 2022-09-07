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
    public partial class cartao_creditoConfiguration : IEntityTypeConfiguration<cartao_credito>
    {
        public void Configure(EntityTypeBuilder<cartao_credito> entity)
        {
            entity.HasKey(e => e.id_cartao);

            entity.Property(e => e.id_cartao).HasDefaultValueSql("(newid())");

            entity.Property(e => e.bandeira)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.emissor)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.limite).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.nome_cartao)
                .HasMaxLength(20)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<cartao_credito> entity);
    }
}