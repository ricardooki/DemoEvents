// See https://aka.ms/new-console-template for more information
using DemoEvents;

Console.WriteLine("Hello, World!");
SendMessage sendMessage = new SendMessage();
SubscriberA subscriberA = new SubscriberA(sendMessage);
SubscriberB subscriberB = new SubscriberB(sendMessage);

sendMessage.OnSendMessageEvent("teste");

Console.ReadKey();