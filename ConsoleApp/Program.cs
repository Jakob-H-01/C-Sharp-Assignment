using Business.Interfaces;
using Business.Services;
using ConsoleApp.Dialogs;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<IFileService>(new FileService("contacts.json"))
    .AddSingleton<IContactService, ContactService>()
    .AddSingleton<Menu>()
    .BuildServiceProvider();

var menu = serviceProvider.GetRequiredService<Menu>();

menu.Main();