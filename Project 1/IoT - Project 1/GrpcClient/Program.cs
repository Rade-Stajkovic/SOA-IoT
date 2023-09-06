// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;

Console.WriteLine("Hello, World!");

using var channel = GrpcChannel.ForAddress("https://localhosy:7048");
