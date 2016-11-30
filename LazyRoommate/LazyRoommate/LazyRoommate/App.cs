﻿using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LazyRoommate
{
    //implementing an authentication interface
    public interface IAuthenticate
    {
        Task<bool> Authenticate();
    }

    public class App : Application
    {
        //initializing the interface with a platform-specific implementation
        public static IAuthenticate Authenticator { get; private set; }

        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }

        public App()
        {
            // The root page of your application

            MainPage = new LoginPage();
        }

        public static MobileServiceClient client = new MobileServiceClient("https://lazyroommate.azurewebsites.net");

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
