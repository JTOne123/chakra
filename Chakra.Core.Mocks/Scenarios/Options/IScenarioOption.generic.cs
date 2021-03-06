﻿namespace ZenProgramming.Chakra.Core.Mocks.Scenarios.Options
{
    /// <summary>
    /// Interface for scenario option with scenario implementation
    /// </summary>
    /// <typeparam name="TScenarioImplementation">Type of scenario implementation</typeparam>
    public interface IScenarioOption<TScenarioImplementation>: IScenarioOption
        where TScenarioImplementation : class, IScenario, new()
    {
        /// <summary>
        /// Get instance of scenario working
        /// </summary>
        /// <returns>Returns scenario instance</returns>
        TScenarioImplementation GetInstance();
    }
}
