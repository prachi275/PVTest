using Microsoft.VisualStudio.TestTools.UnitTesting;
using PVTest2021;
using System;
using System.Threading.Tasks;

namespace PVTest2021.UnitTest
{
	[TestClass]
	public  class ReturnAllTextformFileTests {

		[TestMethod]
		[ExpectedException(typeof(Exception), "Exception Occured")]
		public void TestMethod1Async()
		{
			//Arrange

			//Act
			ReturnAllTextFormFile returnAllTextFormFile = new ReturnAllTextFormFile();
		    ReturnAllTextFormFile.ReturnallTextformFile("","");
			//Assert
		}
	}
}
