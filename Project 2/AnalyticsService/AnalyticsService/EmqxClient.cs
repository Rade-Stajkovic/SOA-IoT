﻿using System;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Adapter;


public interface IEmqxClient
{
    Task ConnectAsync(string brokerAddress, string clientId);
    Task SubscribeAsync(List<string> topics);
    void ConfigureMessageHandler(Func<MqttApplicationMessageReceivedEventArgs, Task> messageHandler);
    Task PublishMessageAsync(string topic, string payload);
}

public class EmqxClient : IEmqxClient
{
    private IMqttClient mqttClient;

    public EmqxClient()
    {
        var factory = new MqttFactory();
        mqttClient = factory.CreateMqttClient();
    }

    public async Task ConnectAsync(string brokerAddress, string clientId)
    {
        var options = new MqttClientOptionsBuilder()
            .WithTcpServer(brokerAddress, 1883)
            .Build();

        await mqttClient.ConnectAsync(options, CancellationToken.None);
        Console.WriteLine("MQTT client is conected.");
    }

    public async Task SubscribeAsync(List<string> topics)
    {
        topics.ForEach(async item =>
        {
            await mqttClient.SubscribeAsync(item);
            Console.WriteLine($"MQTT client subscribed to topics {item}");
        });
      
    }

    public void ConfigureMessageHandler(Func<MqttApplicationMessageReceivedEventArgs, Task> messageHandler)
    {
        mqttClient.ApplicationMessageReceivedAsync += messageHandler;
    }

    public async Task PublishMessageAsync(string topic, string payload)
    {
        var message = new MqttApplicationMessageBuilder()
            .WithTopic(topic)
            .WithPayload(payload)
            .Build();
        await mqttClient.PublishAsync(message);
        //Console.WriteLine($"Mqtt client publish message {payload} to {topic} topic");

    }
}
