using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;
using Xunit;

namespace FileDataTest

{

	public class PrintJobTest
	{
		[Fact]
		public void TestMethod1()
		{
			printJob.printResult("test Result");
		}
	}
}
