# xUnit Class Template

Dotnet CLI template that adds a xUnit test class to the project.

## Installation

```powershell
dotnet new -i GatewayProgrammingSchool.xUnit.CSharp
```

## License

The xUnit Class Template is released under the [MIT](https://mit-license.org/) license.

## Usage

### All Parameters

| Argument | Description | Required | Default |
|-|-|-|-|
| -test | Test Name | Yes | _N/A_  |
| -na | Namespace | No | "MyApp.Tests" |
| -year | Copyright Year | No | "2019" |
| -copy | Owner/Company Name | No | "Your Legal Entity's Name" |

__Example__
```powershell
dotnet new xunit-class -test "WidgetTest" -na "My.Namespace" -y "2018 - 2019" -c "Copyright holder"
```

Adds a new xUnit test class named `WidgetTest` to namespace `My.Namespace` in the current folder with a copyright year for `"2018 - 2019"` and copyright holder of `"Copyright holder"`

__Output__

```csharp

using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace My.Namespace
{
    public class WidgetTest
    {
        ITestOutputHelper _log;

        public WidgetTest(ITestOutputHelper log)
        {
            _log = log;
        }

        [Theory]
        [ClassData(typeof(IntDataSet1))]
        public void WidgetTest1(int data)
        {
            _log.WriteLine(data);

            Assert.Equal(data, data);
        }
    }

    public class WidgetTestDataSet1 : IEnumerable<object[]>
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
 * (C) 2018 - 2019 Copyright holder
 */

```
