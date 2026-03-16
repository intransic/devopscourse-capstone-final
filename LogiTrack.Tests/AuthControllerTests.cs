using Xunit;
using LogiTrack.Controller;
using Microsoft.AspNetCore.Mvc;
using Moq;
using LogiTrack.Models;
using System.Threading.Tasks;

public class AuthControllerTests
{
    [Fact]
    public void RegisterModel_Validation_Works()
    {
        var model = new AuthController.RegisterModel
        {
            Username = "user1",
            Email = "user1@example.com",
            Password = "Password123!"
        };
        Assert.NotNull(model);
    }
}
