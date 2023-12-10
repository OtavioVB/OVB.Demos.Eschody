﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OVB.Demos.Eschody.Infrascructure.EntityFrameworkCore;

#nullable disable

namespace OVB.Demos.Eschody.Infrascructure.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OVB.Demos.Eschody.Domain.StudentContext.DataTransferObject.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("UUID")
                        .HasColumnName("idstudent")
                        .IsFixedLength();

                    b.Property<Guid?>("CorrelationId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("UUID")
                        .HasColumnName("correlation_id")
                        .IsFixedLength();

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("TIMESTAMPTZ")
                        .HasColumnName("created_at")
                        .IsFixedLength();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("email")
                        .IsFixedLength(false);

                    b.Property<string>("ExecutionUser")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("execution_user")
                        .IsFixedLength(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("first_name")
                        .IsFixedLength(false);

                    b.Property<Guid?>("LastCorrelationId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("UUID")
                        .HasColumnName("last_correlation_id")
                        .IsFixedLength();

                    b.Property<string>("LastExecutionUser")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("last_execution_user")
                        .IsFixedLength(false);

                    b.Property<DateTime?>("LastModifiedAt")
                        .IsRequired()
                        .HasColumnType("TIMESTAMPTZ")
                        .HasColumnName("last_modified_at")
                        .IsFixedLength();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("last_name")
                        .IsFixedLength(false);

                    b.Property<string>("LastSourcePlatform")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("last_source_platform")
                        .IsFixedLength(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("CHAR")
                        .HasColumnName("password")
                        .IsFixedLength();

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("CHAR")
                        .HasColumnName("phone")
                        .IsFixedLength();

                    b.Property<string>("SourcePlatform")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("source_platform")
                        .IsFixedLength(false);

                    b.HasKey("Id")
                        .HasName("pk_student_id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("uk_student_email");

                    b.ToTable("students", (string)null);
                });

            modelBuilder.Entity("OVB.Demos.Eschody.Domain.TenantContext.DataTransferObject.Tenant", b =>
                {
                    b.Property<Guid>("ClientId")
                        .HasMaxLength(36)
                        .HasColumnType("UUID")
                        .HasColumnName("client_id")
                        .IsFixedLength();

                    b.Property<Guid>("ClientSecret")
                        .HasMaxLength(36)
                        .HasColumnType("UUID")
                        .HasColumnName("client_secret")
                        .IsFixedLength();

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("CHAR")
                        .HasColumnName("document_cnpj")
                        .IsFixedLength();

                    b.Property<string>("ComercialName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("comercial_name")
                        .IsFixedLength(false);

                    b.Property<short>("Composition")
                        .HasColumnType("SMALLINT")
                        .HasColumnName("composition")
                        .IsFixedLength(false);

                    b.Property<Guid>("CorrelationId")
                        .HasMaxLength(36)
                        .HasColumnType("UUID")
                        .HasColumnName("correlation_id")
                        .IsFixedLength();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMPTZ")
                        .HasColumnName("created_at")
                        .IsFixedLength();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ExecutionUser")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("execution_user")
                        .IsFixedLength(false);

                    b.Property<DateTime>("FoundationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("IsTenantAvailableUntil")
                        .HasColumnType("TIMESTAMPTZ")
                        .HasColumnName("is_available_until")
                        .IsFixedLength(false);

                    b.Property<bool>("IsTenantEnabled")
                        .HasColumnType("BOOLEAN")
                        .HasColumnName("is_tenant_enabled")
                        .IsFixedLength(false);

                    b.Property<Guid>("LastCorrelationId")
                        .HasMaxLength(36)
                        .HasColumnType("UUID")
                        .HasColumnName("last_correlation_id")
                        .IsFixedLength();

                    b.Property<string>("LastExecutionUser")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("last_execution_user")
                        .IsFixedLength(false);

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("TIMESTAMPTZ")
                        .HasColumnName("last_modified_at")
                        .IsFixedLength();

                    b.Property<string>("LastSourcePlatform")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("last_source_platform")
                        .IsFixedLength(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PrimaryCnaeCode")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("CHAR")
                        .HasColumnName("primary_cnae_code")
                        .IsFixedLength();

                    b.Property<string>("Scope")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("scope")
                        .IsFixedLength(false);

                    b.Property<string>("SocialReason")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("social_reason")
                        .IsFixedLength(false);

                    b.Property<string>("SourcePlatform")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("source_platform")
                        .IsFixedLength(false);

                    b.HasKey("ClientId")
                        .HasName("pk_tenant_client_id");

                    b.HasIndex("Cnpj")
                        .IsUnique()
                        .HasDatabaseName("uk_tenant_cnpj");

                    b.ToTable("tenants", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
