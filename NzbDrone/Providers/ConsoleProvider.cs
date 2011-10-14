﻿using System;
using NLog;

namespace NzbDrone.Providers
{
    public class ConsoleProvider
    {
        private static readonly Logger Logger = LogManager.GetLogger("Host.ConsoleProvider");

        public virtual void WaitForClose()
        {
            while (true)
            {
                Console.ReadLine();
            }
        }

        public virtual void PrintHelp()
        {
            Logger.Info("Printing Help");
            Console.WriteLine("Help");
        }

        public virtual void PrintServiceAlreadyExist()
        {
            Console.WriteLine("A service with the same name ({0}) already exists. Aborting installation", ServiceProvider.NzbDroneServiceName);
        }
    }
}