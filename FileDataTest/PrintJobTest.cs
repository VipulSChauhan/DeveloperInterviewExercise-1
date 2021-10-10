using System;
using Xunit;
using FileData;

namespace FileDataTest
{
	public class printJobTest
	{
		[Fact]
		public void printResultTest()
		{
			printJob.printResult("Test Result");
		}
	}
}
