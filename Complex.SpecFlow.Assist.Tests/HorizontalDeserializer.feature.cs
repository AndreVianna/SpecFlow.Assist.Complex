﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Complex.SpecFlow.Assist.Tests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class HorizontalDeserializerFeature : object, Xunit.IClassFixture<HorizontalDeserializerFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "HorizontalDeserializer.feature"
#line hidden
        
        public HorizontalDeserializerFeature(HorizontalDeserializerFeature.FixtureData fixtureData, Complex_SpecFlow_Assist_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Horizontal deserializer", "Transforms a horizontal table in a collection of complex object", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void TestTearDown()
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
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Using horizontal table for primitive types")]
        [Xunit.TraitAttribute("FeatureTitle", "Horizontal deserializer")]
        [Xunit.TraitAttribute("Description", "Using horizontal table for primitive types")]
        [Xunit.TraitAttribute("Category", "Deserializer")]
        public virtual void UsingHorizontalTableForPrimitiveTypes()
        {
            string[] tagsOfScenario = new string[] {
                    "Deserializer"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Using horizontal table for primitive types", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                            "{self}"});
                table44.AddRow(new string[] {
                            "E7BD910E-B939-4711-978E-C6D81AC037D8"});
                table44.AddRow(new string[] {
                            "3346B887-5219-43DE-980D-213985D33847"});
                table44.AddRow(new string[] {
                            "CADA29E3-A126-48F7-81BD-F07083773A6A"});
                table44.AddRow(new string[] {
                            "B7B95D5B-CE20-4FE4-987D-694511AF880C"});
                table44.AddRow(new string[] {
                            "5E882615-E83A-45BD-A950-AD61633BEE9A"});
                table44.AddRow(new string[] {
                            "BE61A824-52B0-42BC-978B-A23AF10B06EB"});
                table44.AddRow(new string[] {
                            "30D73007-9D42-48B8-8D09-E67485EC01D7"});
#line 6
 testRunner.Given("I define a table like", ((string)(null)), table44, "Given ");
#line hidden
#line 15
 testRunner.When("I request a set of strings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("the result collection of strings should have 7 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.And("the item 0 should be \'E7BD910E-B939-4711-978E-C6D81AC037D8\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("the item 3 should be \'B7B95D5B-CE20-4FE4-987D-694511AF880C\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Using horizontal table for complex types")]
        [Xunit.TraitAttribute("FeatureTitle", "Horizontal deserializer")]
        [Xunit.TraitAttribute("Description", "Using horizontal table for complex types")]
        [Xunit.TraitAttribute("Category", "Deserializer")]
        public virtual void UsingHorizontalTableForComplexTypes()
        {
            string[] tagsOfScenario = new string[] {
                    "Deserializer"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Using horizontal table for complex types", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "String",
                            "Integer",
                            "Decimal",
                            "Boolean",
                            "DateTime",
                            "Guid"});
                table45.AddRow(new string[] {
                            "1",
                            "Some string.",
                            "42",
                            "3.141592",
                            "True",
                            "\'2020-02-20T12:34:56.789\'",
                            "\"8D8CDA94-861B-42E4-9836-D972E2F3235B\""});
                table45.AddRow(new string[] {
                            "2",
                            "Another string.",
                            "43",
                            "6.283185",
                            "True",
                            "\'2020-02-21T12:35:00.000\'",
                            "\"72346CA1-B732-4674-9685-491A1C9020D0\""});
                table45.AddRow(new string[] {
                            "3",
                            "One more string.",
                            "44",
                            "2.718282",
                            "False",
                            "\'2020-02-22T23:55:55.111\'",
                            "\"0562F255-A838-415F-9082-3D4A00F06C07\""});
#line 22
 testRunner.Given("I define a table like", ((string)(null)), table45, "Given ");
#line hidden
#line 27
 testRunner.When("I request a complex set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.Then("the result collection should have 3 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.And("the \'Id\' property of the item 0 should be \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("the \'Id\' property of the item 2 should be \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="With a onCreated delegate")]
        [Xunit.TraitAttribute("FeatureTitle", "Horizontal deserializer")]
        [Xunit.TraitAttribute("Description", "With a onCreated delegate")]
        [Xunit.TraitAttribute("Category", "Deserializer")]
        public virtual void WithAOnCreatedDelegate()
        {
            string[] tagsOfScenario = new string[] {
                    "Deserializer"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("With a onCreated delegate", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table46 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "!Extra"});
                table46.AddRow(new string[] {
                            "1",
                            "Pi"});
                table46.AddRow(new string[] {
                            "2",
                            ""});
                table46.AddRow(new string[] {
                            "3",
                            "Tau"});
#line 34
 testRunner.Given("I define a table like", ((string)(null)), table46, "Given ");
#line hidden
#line 39
 testRunner.When("I request a complex set with a onCreated delegate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.Then("the result collection should have 3 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.And("the \'Id\' property of the item 0 should be \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("the \'String\' property of the item 0 should be \'Set during config at index 0.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And("the \'Decimal\' property of the item 0 should be \'3.141592\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("the \'Id\' property of the item 1 should be \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("the \'String\' property of the item 1 should be \'Set during config at index 1.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And("the \'Decimal\' property of the item 1 should be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("the \'Id\' property of the item 2 should be \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And("the \'String\' property of the item 2 should be \'Set during config at index 2.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And("the \'Decimal\' property of the item 2 should be \'6.283185\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="One line with a invalid property value")]
        [Xunit.TraitAttribute("FeatureTitle", "Horizontal deserializer")]
        [Xunit.TraitAttribute("Description", "One line with a invalid property value")]
        [Xunit.TraitAttribute("Category", "Deserializer")]
        public virtual void OneLineWithAInvalidPropertyValue()
        {
            string[] tagsOfScenario = new string[] {
                    "Deserializer"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("One line with a invalid property value", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 52
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table47 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id"});
                table47.AddRow(new string[] {
                            "1"});
                table47.AddRow(new string[] {
                            "Invalid"});
                table47.AddRow(new string[] {
                            "3"});
#line 53
 testRunner.Given("I define a table like", ((string)(null)), table47, "Given ");
#line hidden
#line 58
 testRunner.When("I request a complex set with an error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.Then("it should throw \'InvalidOperationException\' with message \"An error has occurred w" +
                        "hile deserializing line 1.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.And("the inner exception should be \'InvalidCastException\' with message \"The value at \'" +
                        "Id\' is not of the correct type.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Collection property index must not be negative")]
        [Xunit.TraitAttribute("FeatureTitle", "Horizontal deserializer")]
        [Xunit.TraitAttribute("Description", "Collection property index must not be negative")]
        [Xunit.TraitAttribute("Category", "Deserializer")]
        public virtual void CollectionPropertyIndexMustNotBeNegative()
        {
            string[] tagsOfScenario = new string[] {
                    "Deserializer"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Collection property index must not be negative", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 63
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table48 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Lines[-1]"});
                table48.AddRow(new string[] {
                            "1",
                            "\"Some line\""});
                table48.AddRow(new string[] {
                            "2",
                            "\"Other line\""});
#line 64
 testRunner.Given("I define a table like", ((string)(null)), table48, "Given ");
#line hidden
#line 68
 testRunner.When("I request a complex set with an error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.Then("it should throw \'InvalidOperationException\' with message \"An error has occurred w" +
                        "hile deserializing line 0.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.And("the inner exception should be \'InvalidDataException\' with message \"Invalid array " +
                        "index at \'Lines[-1]\'.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                HorizontalDeserializerFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                HorizontalDeserializerFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
