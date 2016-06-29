using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ApplicationDeveloper;
using ApplicationDeveloper.Controllers;
using ApplicationDeveloper.Data.Repositories;
using ApplicationDeveloper.Domain.Models;


namespace ApplicationDeveloperTest
{
    [TestClass]
    public class GetTradesTest
    {
        //TEST METHOD TO ASSURE TRADE METHOD RETURNS CORRECT AMOUNT OF ROWS
        [TestMethod]
        public void TestMethodTrades()
        {
            //Arrange
            TradeRepository tradeRepo = new TradeRepository();

            //Act
            var trades = tradeRepo.GetTrades();
            var tradeCount = trades.Count();

            //Assert
            Assert.AreEqual(tradeCount, 500);
            
        }
    }
}
