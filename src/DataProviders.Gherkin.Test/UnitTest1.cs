﻿using System.Collections.Generic;
using CherrySeed.Configuration;
using CherrySeed.DataProviders.Gherkin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataProviders.Gherkin.Test
{
    [TestClass]
    public class GherkinDataProviderTest
    {
        [TestMethod]
        public void DefaultTest()
        {
            var config = new CherrySeedConfiguration(cfg =>
            {
                cfg.WithDataProvider(new GherkinDataProvider(new GherkinDataProviderConfiguration
                {
                    FilePaths = new List<string> { @"Testfeature.feature" }
                }));
            });

            var seeder = config.CreateSeeder();
            seeder.Seed();
        }
    }
}
