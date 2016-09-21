namespace Design_Patterns.FactoryPattern
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Report : Dokuman
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
