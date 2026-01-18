using OpenBaseNetSqlServerCLI.Commands;
using Spectre.Console.Cli;

var app = new CommandApp();

app.Configure(config =>
{
    config.SetApplicationName("openbase");

    config.AddCommand<InstallCommand>("install")
        .WithDescription("Instala o template do OpenBaseNET");

    config.AddCommand<UpdateCommand>("update")
        .WithDescription("Atualiza o template e a CLI do OpenBaseNET");

    config.AddCommand<NewCommand>("new")
        .WithDescription("Cria um novo projeto baseado no OpenBaseNET");

    config.AddCommand<HelpCommand>("help")
        .WithDescription("Exibe a ajuda para os comandos do OpenBaseNET");

    config.AddCommand<VersionCommand>("version")
        .WithDescription("Exibe as versões da CLI e do template do OpenBaseNET");

});

return app.Run(args);