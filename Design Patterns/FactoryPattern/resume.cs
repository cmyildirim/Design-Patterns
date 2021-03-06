﻿namespace Design_Patterns.FactoryPattern
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Resume : Dokuman
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
