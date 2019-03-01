# xUnit Class Template

Dotnet CLI template that adds a xUnit test class to the project.

## Installation

```powershell
dotnet new -i GatewayProgrammingSchool.xUnit.CSharp
```

## License

The xUnit Class Template is released under the MIT license.

## Usage

```powershell
dotnet new xunit-class -na My.Namespace -y "2018 - 2019" -c "Copyright holder"
```

Adds a new xUnit test class to namespace `My.Namespace` in the current folder with a copyright year for `"2018 - 2019"` and copyright holder of `"Copyright holder"`

May be used without arguments to get default values.

Example output:

```csharp

using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace My.Namespace
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
 * (C) 2018 - 2019 Copyright holder
 */

```
