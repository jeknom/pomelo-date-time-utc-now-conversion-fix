// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    public partial class DbContextModel
    {
        private DbContextModel()
            : base(skipDetectChanges: true, modelId: new Guid("00000000-0000-0000-0000-000000000000"), entityTypeCount: 0)
        {
        }

        partial void Initialize()
        {
            var sequences = new Dictionary<(string, string), ISequence>();
            var @long = new RuntimeSequence(
                "Long",
                this,
                typeof(long),
                startValue: -4L,
                incrementBy: 2,
                cyclic: true,
                minValue: -2L,
                maxValue: 2L);

            sequences[("Long", null)] = @long;

            AddAnnotation("Relational:Sequences", sequences);
            AddAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
            AddAnnotation("Relational:MaxIdentifierLength", 64);
            AddRuntimeAnnotation("Relational:RelationalModelFactory", () => CreateRelationalModel());
        }

        private IRelationalModel CreateRelationalModel()
        {
            var relationalModel = new RelationalModel(this);
            return relationalModel.MakeReadOnly();
        }
    }
}
