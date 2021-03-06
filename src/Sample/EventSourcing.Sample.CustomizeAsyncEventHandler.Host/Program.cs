﻿using System;
using System.Reflection;
using CodeSharp.EventSourcing;

namespace EventSourcing.Sample.CustomizeAsyncEventHandler.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Configuration.Config("EventSourcing.Sample.CustomizeAsyncEventHandler.Host", assembly, assembly);

            Configuration.Instance
                .AsyncEventHandlerProvider<InterfaceAsyncEventHandlerProvider>()
                .RegisterAsyncEventHandlers(assembly)
                .StartAsyncEventSubscriberEndpoint();

            Console.WriteLine("EventSourcing.Sample.CustomizeAsyncEventHandler.Host started, press Enter to exit.");
            Console.ReadLine();
        }
    }
}
