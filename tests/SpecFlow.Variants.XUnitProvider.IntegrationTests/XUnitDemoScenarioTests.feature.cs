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
namespace SpecFlow.Variants.XUnitProvider.IntegrationTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class XUnitDemoScenarioTestsFeature : Xunit.IClassFixture<XUnitDemoScenarioTestsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "XUnitDemoScenarioTests.feature"
#line hidden
        
        public XUnitDemoScenarioTestsFeature(XUnitDemoScenarioTestsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "XUnitDemoScenarioTests", "\tIn order to verify the SpecFlow variants plugin for scenarios\r\n\tAs a developer\r\n" +
                    "\tI want to be able to run integration tests to validate the plugin", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
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
 testRunner.Given("I am on the Google home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="A single test without examples or tags")]
        [Xunit.TraitAttribute("FeatureTitle", "XUnitDemoScenarioTests")]
        [Xunit.TraitAttribute("Description", "A single test without examples or tags")]
        public virtual void ASingleTestWithoutExamplesOrTags()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A single test without examples or tags", null, ((string[])(null)));
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 10
 testRunner.When("I search for \'totaltest github\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("the following result should be listed:", "TotalTest (Prab) · GitHub", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="A test with non-variant tags")]
        [Xunit.TraitAttribute("FeatureTitle", "XUnitDemoScenarioTests")]
        [Xunit.TraitAttribute("Description", "A test with non-variant tags")]
        [Xunit.TraitAttribute("Category", "Settings")]
        [Xunit.TraitAttribute("Category", "Tools")]
        public virtual void ATestWithNon_VariantTags()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with non-variant tags", null, new string[] {
                        "Settings",
                        "Tools"});
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 19
 testRunner.When("I search for \'totaltest github\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("there should be links to the tags specified", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="A test with variant tags: Chrome")]
        [Xunit.TraitAttribute("FeatureTitle", "XUnitDemoScenarioTests")]
        [Xunit.TraitAttribute("Description", "A test with variant tags: Chrome")]
        [Xunit.TraitAttribute("Category", "Browser:Chrome")]
        public virtual void ATestWithVariantTags_Chrome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with variant tags", null, new string[] {
                        "Browser:Chrome",
                        "Browser:Firefox"});
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 25
 testRunner.When("I search for \'totaltest github\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.And("I select the result \'TotalTest (Prab) · GitHub\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.Then("I should be on the website \'https://github.com/totaltest\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="A test with variant tags: Firefox")]
        [Xunit.TraitAttribute("FeatureTitle", "XUnitDemoScenarioTests")]
        [Xunit.TraitAttribute("Description", "A test with variant tags: Firefox")]
        [Xunit.TraitAttribute("Category", "Browser:Firefox")]
        public virtual void ATestWithVariantTags_Firefox()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with variant tags", null, new string[] {
                        "Browser:Chrome",
                        "Browser:Firefox"});
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 25
 testRunner.When("I search for \'totaltest github\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.And("I select the result \'TotalTest (Prab) · GitHub\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.Then("I should be on the website \'https://github.com/totaltest\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void ATestWithVariantTagsAndExamples(string repo, string site, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser:Chrome",
                    "Browser:Firefox"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with variant tags and examples", null, @__tags);
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 32
 testRunner.And("I navigate to the \'TotalTest\' Github page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.When(string.Format("I drill into the \'{0}\' repository", repo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then(string.Format("I should be on the website \'{0}\'", site), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="A test with variant tags and examples: totaltest.github.io_Chrome")]
        [Xunit.TraitAttribute("FeatureTitle", "XUnitDemoScenarioTests")]
        [Xunit.TraitAttribute("Description", "A test with variant tags and examples: totaltest.github.io_Chrome")]
        [Xunit.TraitAttribute("Category", "Browser:Chrome")]
        public virtual void ATestWithVariantTagsAndExamples_Totaltest_Github_Io_Chrome()
        {
#line 31
this.ATestWithVariantTagsAndExamples("totaltest.github.io", "https://github.com/TotalTest/totaltest.github.io", ((string[])(null)));
#line hidden
        }
        
        [Xunit.FactAttribute(DisplayName="A test with variant tags and examples: SpecFlow.Variants_Chrome")]
        [Xunit.TraitAttribute("FeatureTitle", "XUnitDemoScenarioTests")]
        [Xunit.TraitAttribute("Description", "A test with variant tags and examples: SpecFlow.Variants_Chrome")]
        [Xunit.TraitAttribute("Category", "Browser:Chrome")]
        public virtual void ATestWithVariantTagsAndExamples_SpecFlow_Variants_Chrome()
        {
#line 31
this.ATestWithVariantTagsAndExamples("SpecFlow.Variants", "https://github.com/TotalTest/SpecFlow.Variants", ((string[])(null)));
#line hidden
        }
        
        [Xunit.FactAttribute(DisplayName="A test with variant tags and examples: totaltest.github.io_Firefox")]
        [Xunit.TraitAttribute("FeatureTitle", "XUnitDemoScenarioTests")]
        [Xunit.TraitAttribute("Description", "A test with variant tags and examples: totaltest.github.io_Firefox")]
        [Xunit.TraitAttribute("Category", "Browser:Firefox")]
        public virtual void ATestWithVariantTagsAndExamples_Totaltest_Github_Io_Firefox()
        {
#line 31
this.ATestWithVariantTagsAndExamples("totaltest.github.io", "https://github.com/TotalTest/totaltest.github.io", ((string[])(null)));
#line hidden
        }
        
        [Xunit.FactAttribute(DisplayName="A test with variant tags and examples: SpecFlow.Variants_Firefox")]
        [Xunit.TraitAttribute("FeatureTitle", "XUnitDemoScenarioTests")]
        [Xunit.TraitAttribute("Description", "A test with variant tags and examples: SpecFlow.Variants_Firefox")]
        [Xunit.TraitAttribute("Category", "Browser:Firefox")]
        public virtual void ATestWithVariantTagsAndExamples_SpecFlow_Variants_Firefox()
        {
#line 31
this.ATestWithVariantTagsAndExamples("SpecFlow.Variants", "https://github.com/TotalTest/SpecFlow.Variants", ((string[])(null)));
#line hidden
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                XUnitDemoScenarioTestsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                XUnitDemoScenarioTestsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
