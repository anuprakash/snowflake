﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Snowflake.Core.Interface;
using Snowflake.Emulator;
using Snowflake.Plugin;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using Snowflake.Scraper;

namespace Snowflake.Core
{
    public class PluginManager : IPluginManager
    {
        private string AppDataDirectory { get; set; }

        [ImportMany(typeof(IIdentifier))]
        IEnumerable<Lazy<IIdentifier>> identifiers;
        [ImportMany(typeof(IEmulator))]
        IEnumerable<Lazy<IEmulator>> emulators;
        [ImportMany(typeof(IScraper))]
        IEnumerable<Lazy<IScraper>> scrapers;
        [ImportMany(typeof(IGenericPlugin))]
        IEnumerable<Lazy<IGenericPlugin>> plugins;


        public IDictionary<string, IIdentifier> LoadedIdentifiers { get; private set; }
        public IDictionary<string, IEmulator> LoadedEmulators { get; private set; }
        public IDictionary<string, IScraper> LoadedScrapers { get; private set; }
        public IDictionary<string, IGenericPlugin> LoadedPlugins { get; private set; }
        public IDictionary<string, Type> PluginRegistry { get; private set; }
        public PluginManager(string appDataDirectory)
        {
            this.AppDataDirectory = appDataDirectory;
            this.PluginRegistry = new Dictionary<string, Type>();
            this.ComposeImports();
        }

        public void LoadAllPlugins()
        {
            this.LoadedIdentifiers = this.LoadPlugin(this.identifiers);
            this.LoadedEmulators = this.LoadPlugin(this.emulators);
            this.LoadedScrapers = this.LoadPlugin(this.scrapers);
            this.LoadedPlugins = this.LoadPlugin(this.plugins);
        }
        private void ComposeImports()
        {
            var catalog = new DirectoryCatalog(Path.Combine(this.AppDataDirectory, "plugins"));
            var container = new CompositionContainer(catalog);
            container.SatisfyImportsOnce(this);
        }

        private Dictionary<string, T> LoadPlugin<T>(IEnumerable<Lazy<T>> unloadedPlugins) where T : IPlugin
        {
            var loadedPlugins = new Dictionary<string, T>();
            foreach (var plugin in unloadedPlugins)
            {
                var instance = (IPlugin)plugin.Value;
                loadedPlugins.Add(instance.PluginName, plugin.Value);
                this.PluginRegistry.Add(instance.PluginName, typeof(T));
                Console.WriteLine(typeof(T).Name);

            }
            return loadedPlugins;
        }
    }
}
