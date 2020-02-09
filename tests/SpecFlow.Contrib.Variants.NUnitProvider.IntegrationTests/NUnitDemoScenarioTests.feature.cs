﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.Contrib.Variants.NUnitProvider.IntegrationTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("NUnitDemoScenarioTests")]
    public partial class NUnitDemoScenarioTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NUnitDemoScenarioTests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "NUnitDemoScenarioTests", "\tIn order to verify the SpecFlow variants plugin for scenarios\r\n\tAs a developer\r\n" +
                    "\tI want to be able to run integration tests to validate the plugin", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("I am on the input forms page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A single test without examples or tags")]
        public virtual void ASingleTestWithoutExamplesOrTags()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A single test without examples or tags", null, ((string[])(null)));
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 10
 testRunner.When("check the checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("the checkbox text is \'Success - Check box is checked\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A test with non-variant tags")]
        [NUnit.Framework.CategoryAttribute("Option_1")]
        [NUnit.Framework.CategoryAttribute("Option_2")]
        [NUnit.Framework.CategoryAttribute("Option_3")]
        [NUnit.Framework.CategoryAttribute("Option_4")]
        public virtual void ATestWithNon_VariantTags()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with non-variant tags", null, new string[] {
                        "Option_1",
                        "Option_2",
                        "Option_3",
                        "Option_4"});
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 18
 testRunner.When("I check all the option check boxes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("the tags check boxes should be checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A test with variant tags: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        public virtual void ATestWithVariantTags_Chrome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with variant tags", null, new string[] {
                        "Browser:Chrome",
                        "Browser:Firefox"});
#line 23
this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Chrome");
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 24
 testRunner.When("check the checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("the checkbox text is \'Success - Check box is checked\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A test with variant tags: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        public virtual void ATestWithVariantTags_Firefox()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with variant tags", null, new string[] {
                        "Browser:Chrome",
                        "Browser:Firefox"});
#line 23
this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Firefox");
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 24
 testRunner.When("check the checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("the checkbox text is \'Success - Check box is checked\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestCaseAttribute("Input Forms", "Simple Form Demo", "https://www.seleniumeasy.com/test/basic-first-form-demo.html", "Chrome", null, Category="Browser:Chrome", TestName="ATestWithVariantTagsAndExamples with Chrome and \"Input Forms\", \"Simple Form Demo\"" +
            ", \"https://www_seleniumeasy_com/test/basic-first-form-demo_html\"")]
        [NUnit.Framework.TestCaseAttribute("Input Forms", "Simple Form Demo", "https://www.seleniumeasy.com/test/basic-first-form-demo.html", "Firefox", null, Category="Browser:Firefox", TestName="ATestWithVariantTagsAndExamples with Firefox and \"Input Forms\", \"Simple Form Demo" +
            "\", \"https://www_seleniumeasy_com/test/basic-first-form-demo_html\"")]
        [NUnit.Framework.TestCaseAttribute("Date pickers", "Bootstrap Date Picker", "https://www.seleniumeasy.com/test/bootstrap-date-picker-demo.html", "Chrome", null, Category="Browser:Chrome", TestName="ATestWithVariantTagsAndExamples with Chrome and \"Date pickers\", \"Bootstrap Date P" +
            "icker\", \"https://www_seleniumeasy_com/test/bootstrap-date-picker-demo_html\"")]
        [NUnit.Framework.TestCaseAttribute("Date pickers", "Bootstrap Date Picker", "https://www.seleniumeasy.com/test/bootstrap-date-picker-demo.html", "Firefox", null, Category="Browser:Firefox", TestName="ATestWithVariantTagsAndExamples with Firefox and \"Date pickers\", \"Bootstrap Date " +
            "Picker\", \"https://www_seleniumeasy_com/test/bootstrap-date-picker-demo_html\"")]
        public virtual void ATestWithVariantTagsAndExamples(string link, string sublink, string site, string browser, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser:Chrome",
                    "Browser:Firefox"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with variant tags and examples", null, @__tags);
#line 29
this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", browser);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 30
 testRunner.And(string.Format("I drill into the \'{0}\' link", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When(string.Format("I drill into the \'{0}\' link", sublink), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then(string.Format("the page should be \'{0}\'", site), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
