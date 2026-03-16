using Xunit;
using LogiTrack.Controller;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Microsoft.Extensions.Caching.Memory;
using LogiTrack.Data;
using LogiTrack.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class InventoryControllerTests
{
    [Fact]
    public async Task GetInventory_ReturnsOkResult()
    {
        // Arrange
        var mockContext = new Mock<LogiTrackContext>();
        var mockCache = new MemoryCache(new MemoryCacheOptions());
        var controller = new InventoryController(mockContext.Object, mockCache);

        // Act
        var result = await controller.GetInventory();

        // Assert
        Assert.IsType<ActionResult<IEnumerable<InventoryItem>>>(result);
    }
}
