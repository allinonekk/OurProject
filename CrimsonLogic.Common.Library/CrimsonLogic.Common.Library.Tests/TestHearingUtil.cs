namespace CrimsonLogic.Common.Library.Tests
{
    using System;
    using System.IO;

    using CrimsonLogic.Common.Library.Hearing;

    using log4net.Config;

    using NUnit.Framework;

    [TestFixture]
    public class TestHearingUtil
    {
        #region Methods

        [TestFixtureSetUp]
        public void Init()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_commonlibrary.Config"));
        }

        [Test]
        public void TestGetPaperHearingTimeSlot()
        {
            DateTime submissionDateForTodaySlot = new DateTime(DateTime.Today.Year
                                        , DateTime.Today.Month
                                        , DateTime.Today.Day
                                        , 10, 30, 00);

            DateTime todaySlot = new DateTime(submissionDateForTodaySlot.Year
                                        , submissionDateForTodaySlot.Month
                                        , submissionDateForTodaySlot.Day
                                        , 14, 30, 00);

            Assert.AreEqual(todaySlot, HearingUtil.GetPaperHearingTimeSlot(submissionDateForTodaySlot));

            DateTime submissionDateForNextDaySlot = new DateTime(DateTime.Today.Year
                                        , DateTime.Today.Month
                                        , DateTime.Today.Day
                                        , 15, 30, 00);

            DateTime nextDaySlot = new DateTime(submissionDateForNextDaySlot.Year
                                        , submissionDateForNextDaySlot.Month
                                        , submissionDateForNextDaySlot.Day
                                        , 09, 00, 00).AddDays(1);

            Assert.AreEqual(nextDaySlot, HearingUtil.GetPaperHearingTimeSlot(submissionDateForNextDaySlot));
        }

        #endregion Methods
    }
}