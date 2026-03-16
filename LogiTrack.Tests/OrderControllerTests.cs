using Xunit;
using LogiTrack.Controller;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Microsoft.Extensions.Caching.Memory;
using LogiTrack.Data;
using LogiTrack.Models;
using System.Threading.Tasks;

public class OrderControllerTests
{
    [Fact]
    public async Task GetOrders_ReturnsOkResult()
    {
        // Arrange
        var mockContext = new Mock<LogiTrackContext>();
        var mockCache = new MemoryCache(new MemoryCacheOptions());
        var controller = new OrderController(mockContext.Object, mockCache);

        // Act
        var result = await controller.GetOrders();

        // Assert
        Assert.IsType<ActionResult<IEnumerable<Order>>>(result);
    }
}
