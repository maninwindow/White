using System.Windows.Automation;
using TestStack.White.Configuration;

namespace TestStack.White.AutomationElementSearch
{
    public class DescendantFinderFactory
    {
        public static IDescendantFinder Create(AutomationElement automationElement)
        {
            if (CoreAppXmlConfiguration.Instance.RawElementBasedSearch) return new RawAutomationElementFinder(automationElement);
            return new DescendantFinder(automationElement);
        }
    }
}