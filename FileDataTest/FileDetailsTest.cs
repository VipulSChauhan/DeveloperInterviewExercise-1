using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ThirdPartyTools;

namespace FileDataTest
{
	public class FileDetailsTest
	{
		[Fact]
		public void VersionTest()
		{
			FileDetails fd = new FileDetails();
			string versionResult = fd.Version("test/path");
			Assert.NotEmpty(versionResult);
		}

		[Fact]
		public void SizeTest()
		{
			FileDetails fd = new FileDetails();
			int sizeResulr = fd.Size("test/path");
			Assert.NotEmpty(sizeResulr.ToString());
		}

	}
}
