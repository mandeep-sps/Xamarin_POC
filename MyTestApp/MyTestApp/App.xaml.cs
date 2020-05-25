﻿using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyTestApp.Data;
using MyTestApp.Views;

namespace MyTestApp
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }

        static NoteDatabase database;

        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }


    }
}
