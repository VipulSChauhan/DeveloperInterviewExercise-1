using System;
using System.Collections.Generic;
using System.Text;
using FileData;
using Xunit;

namespace FileDataTest
{
	public class ProgramTest
	{
		[Fact]
		public void MainTest()
		{
			Program.Main(new[] { "-v", "-s" });
			Program.Main(new[] { "-t", "-s" });
			Program.Main(new[] { "-version", "-s" });
			Program.Main(new[] { "-size", "-s" });
		}
	}
}
