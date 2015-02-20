using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayerX.Domain;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace DataLayerX_Tests
{
    [TestFixture]
    public class GenerateSchema_fixture
    {
        [Test]
        public void Can_generate_schema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(People).Assembly);

            new SchemaExport(cfg).Execute(false, true, false); 
        }
    }
}
