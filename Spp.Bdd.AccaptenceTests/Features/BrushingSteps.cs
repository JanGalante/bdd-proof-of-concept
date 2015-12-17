using System;
using SpecResults;
using TechTalk.SpecFlow;

namespace Spp.Bdd.AccaptenceTests.Features
{
    [Binding]
    public class BrushingSteps : ReportingStepDefinitions
    {
        [Given]
        public void Given_there_is_GRAMS_grams_of_BRAND_toothpaste_on_the_brush(int grams, string brand)
        {
            ScenarioContext.Current.Pending();
        }

        [Given]
        public void Given_the_mouth_is_open()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given]
        public void Given_I_have_the_following_tools(Table table)
        {
            var firstToolName = table.Rows[0][0];
            var firstToolQuality = table.Rows[0][1];

            var secondToolName = table.Rows[1]["ToolName"];
            var secondToolQuality = table.Rows[1]["ToolQuality"];

            var isToolColumnSpecified = table.ContainsColumn("HokusPokus");

            ScenarioContext.Current.Pending();
        }
        
        [Given]
        public void Given_I_m_using_BRAND_brand_toothpaste(string brand)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void When_the_backteeth_are_brushed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void When_I_brush_for_P0_minutes(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_the_teeth_look_clean()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_the_mouth_feels_fresh()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_the_braces_aren_t_damaged()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_the_teeth_look_P0_white(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
