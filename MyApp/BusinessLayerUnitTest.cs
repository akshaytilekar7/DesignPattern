using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThirdPartyService;

namespace MyApp;

[TestClass]
public class BusinessLayerTests
{
    [TestMethod]
    public void Start_CallsEmployeeServiceCalculateTotalCost()
    {
        // Arrange
        var mockService = new Mock<IEmployeeService>();
        var businessLayer = new BusinessLayer(mockService.Object);

        // Act
        businessLayer.Start();

        // Assert
        // Verify that the interface method was called at least once (for employeeService.CalculateTotalCost(5))
        mockService.Verify(s => s.CalculateTotalCost(5), Times.AtLeastOnce);
    }

    [TestMethod]
    public void DecoratorClient_WithMock_CallsInnerService()
    {
        // Arrange
        var mockInnerService = new Mock<IEmployeeService>();
        var decoratorClient = new DecoratorClient(mockInnerService.Object);

        // Act
        decoratorClient.CalculateTotalCost(5);

        // Assert
        mockInnerService.Verify(s => s.CalculateTotalCost(5), Times.Once);
    }

    [TestMethod]
    public void DecoratorClient_WithLogging_WithMock_CallsInnerService()
    {
        // Arrange
        var mockInnerService = new Mock<IEmployeeService>();
        var client = new DecoratorClient(mockInnerService.Object.WithLogging());

        // Act
        client.CalculateTotalCost(5);

        // Assert
        mockInnerService.Verify(s => s.CalculateTotalCost(5), Times.Once);
    }
}
