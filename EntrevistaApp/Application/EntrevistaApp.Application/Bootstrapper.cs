using EntrevistaApp.Application.Abstraction.Questao.Querys;
using EntrevistaApp.Application.Abstraction.Questao.Responses;
using EntrevistaApp.Application.Questao.Queries;
using MediatR;
using EntrevistaApp.Application.Abstraction.Questao.Commands;
using EntrevistaApp.Application;
using EntrevistaApp.Application.Abstraction.Questao.Command;
using EntrevistaApp.Application.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntrevistaApp.Application
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddBootstrapperApplication(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<CriarQuestaoCommand, CommandExecution>, CriarQuestaoCommandHandler>();
            services.AddScoped<IRequestHandler<AtualizarQuestaoCommand, CommandExecution>, AtualizarQuestaoCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteQuestaoCommand, CommandExecution>, DeleteQuestaoCommandHandler>();
            services.AddScoped<IRequestHandler<ListarQuestaoQuery, ListarQuestaoResponse>, ListarQuestaoQueryHandler>();
            services.AddScoped<IRequestHandler<PesquisarQuestoesQuery, PesquisarQuestoesResponse>, PesquisarQuestoesQueryHandler>();
            services.AddScoped<IRequestHandler<DetalharQuestoesQuery, DetalharQuestoesResponse>, DetalharQuestoesQueryHandler>();
            services.AddScoped<IRequestHandler<InativarQuestaoQuery, InativarQuestaoResponse>, InativarQuestaoQueryHandler>();
            return services;
        }
    }
}