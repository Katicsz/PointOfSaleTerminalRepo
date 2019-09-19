using Microsoft.AspNetCore.Mvc;
using ShopApp.Controllers;
using ShopApp.Infrastructure;
using ShopApp.Services;
using System;
using Xunit;

namespace ShopApp.Test
{
    public class TerminalControllerTest
    {
        [Fact]
        public void CalculateTotalOrderAmount_Test1()
        {
            ProductsRepository repo = new ProductsRepository();
            PointOfSaleTerminalService serv = new PointOfSaleTerminalService(repo);
            TerminalController terminalController = new TerminalController(serv);
            string[] productsNames = new string[] { "A", "B", "C", "D", "A", "B", "A" };
            ActionResult<double> total = terminalController.Post(productsNames);
            Assert.Equal(13.25, total.Value);
        }

        [Fact]
        public void CalculateTotalOrderAmount_Test2()
        {
            ProductsRepository repo = new ProductsRepository();
            PointOfSaleTerminalService serv = new PointOfSaleTerminalService(repo);
            TerminalController terminalController = new TerminalController(serv);
            string[] productsNames = new string[] { "C", "C", "C", "C", "C", "C", "C"};
            ActionResult<double> total = terminalController.Post(productsNames);
            Assert.Equal(6.00, total.Value);
        }

        [Fact]
        public void CalculateTotalOrderAmount_Test3()
        {
            ProductsRepository repo = new ProductsRepository();
            PointOfSaleTerminalService serv = new PointOfSaleTerminalService(repo);
            TerminalController terminalController = new TerminalController(serv);
            string[] productsNames = new string[] { "A", "B", "C", "D" };
            ActionResult<double> total = terminalController.Post(productsNames);
            Assert.Equal(7.25, total.Value);
        }

        [Fact]
        public void CalculateTotalOrderAmount_Test_Not_Found()
        {
            ProductsRepository repo = new ProductsRepository();
            PointOfSaleTerminalService serv = new PointOfSaleTerminalService(repo);
            TerminalController terminalController = new TerminalController(serv);
            string[] productsNames = new string[] { "A", "B", "C", "D", "H" };
            ActionResult<double> total = terminalController.Post(productsNames);
            Assert.IsType<NotFoundObjectResult>(total.Result);
        }
    }
}
