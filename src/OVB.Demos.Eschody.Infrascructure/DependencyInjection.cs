﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OVB.Demos.Eschody.Domain.StudentContext.DataTransferObject;
using OVB.Demos.Eschody.Infrascructure.EntityFrameworkCore;
using OVB.Demos.Eschody.Infrascructure.EntityFrameworkCore.Repositories;
using OVB.Demos.Eschody.Infrascructure.EntityFrameworkCore.Repositories.Base.Interfaces;
using OVB.Demos.Eschody.Infrascructure.EntityFrameworkCore.Repositories.Extensions;
using OVB.Demos.Eschody.Infrascructure.EntityFrameworkCore.UnitOfWork;
using OVB.Demos.Eschody.Infrascructure.EntityFrameworkCore.UnitOfWork.Interfaces;

namespace OVB.Demos.Eschody.Infrascructure;

public static class DependencyInjection
{
    public static void ApplyInfrascructureDependenciesConfiguration(
        this IServiceCollection serviceCollection, string connectionString)
    {
        #region Entity Framework Core DbContext Configuration

        serviceCollection.AddDbContextPool<DataContext>(optionsAction: p =>
            p.UseNpgsql(
                connectionString: connectionString,
                npgsqlOptionsAction: p => p.MigrationsAssembly("OVB.Demos.Eschody.Infrascructure")));

        #endregion

        #region Entity Framework Core Unit Of Work Configuration

        serviceCollection.AddScoped<IUnitOfWork, DefaultUnitOfWork>();

        #endregion

        #region Repositories Configuration

        serviceCollection.AddScoped<IBaseRepository<Student>, StudentRepository>();
        serviceCollection.AddScoped<IExtensionStudentRepository, StudentRepository>();

        #endregion
    }
}