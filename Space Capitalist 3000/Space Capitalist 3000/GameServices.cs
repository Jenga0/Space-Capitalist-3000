﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Space_Capitalist_3000
{
    public static class GameServices
    {
        private static GameServiceContainer container;
        public static GameServiceContainer Instance
        {
            get
            {
                if (container == null)
                {
                    container = new GameServiceContainer();
                }
                return container;
            }
        }


        public static GraphicsDeviceManager DeviceManager
        { get { return GetService<GraphicsDeviceManager>(); } }


        public static void Initialize(GraphicsDeviceManager deviceManager)
        {


            AddService(deviceManager);

        }

        public static void Dispose()
        {

            RemoveService<GraphicsDeviceManager>();

        }


        private static T GetService<T>()
        {
            return (T)Instance.GetService(typeof(T));
        }

        private static void AddService<T>(T service)
        {
            Instance.AddService(typeof(T), service);
        }

        public static void RemoveService<T>()
        {
            Instance.RemoveService(typeof(T));
        }
    }
}
