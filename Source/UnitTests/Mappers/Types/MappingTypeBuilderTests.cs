﻿using System;
using System.Linq;
using Nelibur.ObjectMapper.Core.DataStructures;
using Nelibur.ObjectMapper.Mappers.MappingTypes;
using Xunit;

namespace UnitTests.Mappers.Types
{
    public sealed class MappingTypeBuilderTests
    {
        [Fact]
        public void Buid_Recursion_Ok()
        {
            MappingType member = MappingTypeBuilder.Build(new TypePair(typeof(MyClass), typeof(MyClass1)));
            Assert.Equal(2, member.Members.Count());
        }
    }


    public class MyClass
    {
        public MyClass1 Class { get; set; }
        public int Id { get; set; }
    }


    public class MyClass1
    {
        public MyClass Class { get; set; }
        public int Id { get; set; }
    }
}
