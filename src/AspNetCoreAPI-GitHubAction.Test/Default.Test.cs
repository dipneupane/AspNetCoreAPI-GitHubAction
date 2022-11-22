namespace AspNetCoreAPI_GitHubAction.Test
{
	public class DefaultTest
	{
		[Test]
		public void DefaultTest_ReturnsExpected()
		{
			//Arrange
			var a = 1;
			var b = 2;
			var expected = 3;

			// Act`
			var sum = a + b;

			// Assert`
			Assert.That(expected, Is.EqualTo(sum));
		}
	}
}
