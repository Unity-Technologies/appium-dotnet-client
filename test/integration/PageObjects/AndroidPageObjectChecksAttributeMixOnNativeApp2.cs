﻿using System.Collections.Generic;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using SeleniumExtras.PageObjects;

namespace Appium.Net.Integration.Tests.PageObjects
{
    public class AndroidPageObjectChecksAttributeMixOnNativeApp2
    {
        /////////////////////////////////////////////////////////////////

        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]")]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/text1\")")]
        private IMobileElement _testMobileElement;

        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]")]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/text1\")")]
        private IList<AppiumWebElement> _testMobileElements;

        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]")]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/text1\")")]
        private IMobileElement TestMobileElement { set; get; }

        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]")]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/text1\")")]
        private IList<AppiumWebElement> TestMobileElements { set; get; }

        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/fakeId\")",
            Priority = 1)] [FindsByAndroidUIAutomator(ID = "FakeId", Priority = 2)]
        [FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 3)]
        private IMobileElement _testMultipleElement;

        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/fakeId\")",
            Priority = 1)] [FindsByAndroidUIAutomator(ID = "FakeId", Priority = 2)]
        [FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 3)]
        private IList<AppiumWebElement> _testMultipleElements;


        /////////////////////////////////////////////////////////////////

        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/fakeId\")",
            Priority = 1)]
        [FindsByAndroidUIAutomator(ID = "FakeId", Priority = 2)]
        [FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 3)]
        private IMobileElement TestMultipleFindByElementProperty { set; get; }

        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/fakeId\")",
            Priority = 1)]
        [FindsByAndroidUIAutomator(ID = "FakeId", Priority = 2)]
        [FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 3)]
        private IList<AppiumWebElement> MultipleFindByElementsProperty { set; get; }

        [FindsBySequence] [MobileFindsBySequence(Android = true, IOS = true)]
        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/content\")",
            Priority = 1)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/list\")",
            Priority = 2)] [FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 3)]
        private IMobileElement _foundByChainedSearchElement;

        [FindsBySequence] [MobileFindsBySequence(Android = true, IOS = true)]
        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/content\")",
            Priority = 1)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/list\")",
            Priority = 2)] [FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 3)]
        private IList<AppiumWebElement> _foundByChainedSearchElements;

        /////////////////////////////////////////////////////////////////

        [FindsBySequence]
        [MobileFindsBySequence(Android = true, IOS = true)]
        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/content\")",
            Priority = 1)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/list\")",
            Priority = 2)]
        [FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 3)]
        private IMobileElement TestFoundByChainedSearchElementProperty { set; get; }

        [FindsBySequence]
        [MobileFindsBySequence(Android = true, IOS = true)]
        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/content\")",
            Priority = 1)]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/list\")",
            Priority = 2)]
        [FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 3)]
        private IList<AppiumWebElement> TestFoundByChainedSearchElementsProperty { set; get; }

        [FindsByAll] [MobileFindsByAll(Android = true, IOS = true)]
        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(ID = "android:id/text1", Priority = 1)]
        //[FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 2)]
        //Equals method of WebElement is not consistent for mobile apps
        //The second selector will be commented till the problem is worked out
        private IMobileElement _matchedToAllLocatorsElement;

        [FindsByAll] [MobileFindsByAll(Android = true, IOS = true)]
        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(ID = "android:id/text1", Priority = 1)]
        //[FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 2)]
        //Equals method of WebElement is not consistent for mobile apps
        //The second selector will be commented till the problem is worked out
        private IList<AppiumWebElement> _matchedToAllLocatorsElements;

        /////////////////////////////////////////////////////////////////

        [FindsByAll]
        [MobileFindsByAll(Android = true, IOS = true)]
        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(ID = "android:id/text1", Priority = 1)]
        //[FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 2)]
        //Equals method of WebElement is not consistent for mobile apps
        //The second selector will be commented till the problem is worked out
        private IMobileElement TestMatchedToAllLocatorsElementProperty { set; get; }

        [FindsByAll]
        [MobileFindsByAll(Android = true, IOS = true)]
        [FindsBy(How = How.Id, Using = "FakeHTMLid", Priority = 1)]
        [FindsBy(How = How.ClassName, Using = "FakeHTMLClass", Priority = 2)]
        [FindsBy(How = How.XPath, Using = ".//fakeTag", Priority = 3)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]", Priority = 1)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[1]", Priority = 2)]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[2]", Priority = 3)]
        [FindsByAndroidUIAutomator(ID = "android:id/text1", Priority = 1)]
        //[FindsByAndroidUIAutomator(ClassName = "android.widget.TextView", Priority = 2)]
        //Equals method of WebElement is not consistent for mobile apps
        //The second selector will be commented till the problem is worked out
        private IList<AppiumWebElement> TestMatchedToAllLocatorsElementsProperty { set; get; }

        //////////////////////////////////////////////////////////////////////////
        public string GetMobileElementText()
        {
            return _testMobileElement.Text;
        }

        public int GetMobileElementSize()
        {
            return _testMobileElements.Count;
        }

        public string GetMobileElementPropertyText()
        {
            return TestMobileElement.Text;
        }

        public int GetMobileElementPropertySize()
        {
            return TestMobileElements.Count;
        }

        //////////////////////////////////////////////////////////////////////////
        public string GetMultipleFindByElementText()
        {
            return _testMultipleElement.Text;
        }

        public int GetMultipleFindByElementSize()
        {
            return _testMultipleElements.Count;
        }

        public string GetMultipleFindByElementPropertyText()
        {
            return TestMultipleFindByElementProperty.Text;
        }

        public int GetMultipleFindByElementPropertySize()
        {
            return MultipleFindByElementsProperty.Count;
        }

        //////////////////////////////////////////////////////////////////////////
        public string GetFoundByChainedSearchElementText()
        {
            return _foundByChainedSearchElement.Text;
        }

        public int GetFoundByChainedSearchElementSize()
        {
            return _foundByChainedSearchElements.Count;
        }

        public string GetFoundByChainedSearchElementPropertyText()
        {
            return TestFoundByChainedSearchElementProperty.Text;
        }

        public int GetFoundByChainedSearchElementPropertySize()
        {
            return TestFoundByChainedSearchElementsProperty.Count;
        }

        //////////////////////////////////////////////////////////////////////////
        public string GetMatchedToAllLocatorsElementText()
        {
            return _matchedToAllLocatorsElement.Text;
        }

        public int GetMatchedToAllLocatorsElementSize()
        {
            return _matchedToAllLocatorsElements.Count;
        }

        public string GetMatchedToAllLocatorsElementPropertyText()
        {
            return TestMatchedToAllLocatorsElementProperty.Text;
        }

        public int GetMatchedToAllLocatorsElementPropertySize()
        {
            return TestMatchedToAllLocatorsElementsProperty.Count;
        }
    }
}