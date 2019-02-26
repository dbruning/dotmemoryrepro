using JetBrains.dotMemoryUnit;
using Xunit;
using Xunit.Abstractions;

namespace ClassLibrary1
{
	public class Class1
	{
		public Class1(ITestOutputHelper outputHelper)
		{
			// Ensure that dotMemory output appears in test output
			// https://blog.jetbrains.com/dotnet/2018/10/04/unit-testing-memory-leaks-using-dotmemory-unit/
			DotMemoryUnitTestOutput.SetOutputMethod(
				message => outputHelper.WriteLine(message));
		}
		
		[Fact]
		public void CanRunTestWithDotMemory()
		{
			dotMemory.Check(memory =>
				Assert.Equal(1, 1));
		}
	}
}