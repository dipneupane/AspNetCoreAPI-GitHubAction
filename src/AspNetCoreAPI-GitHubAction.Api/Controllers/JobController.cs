using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreAPI_GitHubAction.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class JobController : ControllerBase
	{
		private static readonly string[] _availableJobs = new[]
		{
			"Asp.Net Core (C#) Developer", "ReactJs Developer", "Microsoft Azure Develoepr", "Blockchain Developer", "UI/UX Designer", "Database Administrator", "Azure DevOps Engineer"
		};

		[HttpGet(Name = "get-all-jobs")]
		public IActionResult Get()
		{
			return Ok(_availableJobs);
		}
	}
}