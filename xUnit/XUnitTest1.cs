using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace @namespace
{
    public class XUnitTest1
    {
        ITestOutputHelper _log;

        public XUnitTest1(ITestOutputHelper log)
        {
            _log = log;
        }
        
        [Theory]
        [ClassData(typeof(IntDataSet1))]
        public void Test1(int data)
        {
            _log.WriteLine(data);

            Assert.Equal(data, data);
        }
    }

    public class IntDataSet1 : IEnumerable<object[]>
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
            throw new NotImplementedException();
        }
    }
}


/*
 * (C) @year @copyrightName
 */
