using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace @namespace
{
    public class @test
    {
        ITestOutputHelper _log;

        public @test(ITestOutputHelper log)
        {
            _log = log;
        }
        
        [Theory]
        [ClassData(typeof(@testDataSet1))]
        public void @test1(int data)
        {
            _log.WriteLine(data);

            Assert.Equal(data, data);
        }
    }

    public class @testDataSet1 : IEnumerable<object[]>
    {
        object[] _data = {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
            };

        public IEnumerator<object[]> GetEnumerator()
        {
            foreach (var item in _data) yield return new object[] { item };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}


/*
 * (C) @year @copyrightName
 */
