﻿using Stryker.Core.Options;

namespace Stryker.CLI
{
    public static class CLIOptions
    {
        private static StrykerOptions _defaultOptions = new StrykerOptions();
        
        public static readonly CLIOption<string> ConfigFilePath = new CLIOption<string>
        {
            ArgumentName = "--config-file-path",
            ArgumentShortName = "-cp <path>",
            ArgumentDescription = "Sets the config-file-path relative to current workingDirectory | stryker-config.json (default)",
            DefaultValue = "stryker-config.json"
        };

        public static readonly CLIOption<string> Reporter = new CLIOption<string>
        {
            ArgumentName = "--reporter",
            ArgumentShortName = "-r <reporter>",
            ArgumentDescription = $"Sets the reporter | Options [{_defaultOptions.Reporter} (default)]",
            DefaultValue = _defaultOptions.Reporter,
            JsonKey = "reporter"
        };

        public static readonly CLIOption<string> LogLevel = new CLIOption<string>
        {
            ArgumentName = "--log-console",
            ArgumentShortName = "-l <logLevel>",
            ArgumentDescription = "Sets the logging level | Options [error, warning, info (default), debug, trace]",
            DefaultValue = "info",
            JsonKey = "log-level"
        };

        public static readonly CLIOption<bool> UseLogLevelFile = new CLIOption<bool>
        {
            ArgumentName = "--log-file",
            ArgumentShortName = "-f",
            ArgumentDescription = "Makes the logger write to a file | Options [false (default), true]",
            DefaultValue = _defaultOptions.LogOptions.LogToFile,
            JsonKey = "log-file"
        };

        public static readonly CLIOption<bool> DevMode = new CLIOption<bool>
        {
            ArgumentName = "--dev-mode",
            ArgumentShortName = "-dm <enable>",
            ArgumentDescription = "Set to true to activate dev mode to ease debugging of Stryker.Net| Options [true, false (default)]",
            DefaultValue = _defaultOptions.DevMode,
            JsonKey = "dev-mode"
        };

        public static readonly CLIOption<int> AdditionalTimeoutMS = new CLIOption<int>
        {
            ArgumentName = "--timeout-ms",
            ArgumentShortName = "-t <ms>",
            ArgumentDescription = $"When passed, a logfile will be created for this mutation test run on trace level| Options {_defaultOptions.AdditionalTimeoutMS}",
            DefaultValue = _defaultOptions.AdditionalTimeoutMS,
            JsonKey = "timeout-ms"
        };

        public static readonly CLIOption<string[]> ExcludedMutations = new CLIOption<string[]>
        {
            ArgumentName = "--excluded-mutations",
            ArgumentShortName = "-em <mutator-name>",
            ArgumentDescription = "The given mutators will be excluded for this mutation testrun.",
            JsonKey = "excluded-mutations"
        };

        public static readonly CLIOption<string> ProjectFileName = new CLIOption<string>
        {
            ArgumentName = "--project-file",
            ArgumentShortName = "-p <projectFileName>",
            ArgumentDescription = @"Used for matching the project references when finding the project to mutate. Example: ""ExampleProject.csproj""",
            JsonKey = "project-file"
        };

        public static readonly CLIOption<int> MaxConcurrentTestRunners = new CLIOption<int>
        {
            ArgumentName = "--max-concurrent-test-runners",
            ArgumentShortName = "-m <maxConcurrentTestRunners>",
            ArgumentDescription = @"Mutation testing is time consuming. By default Stryker tries to make the most of your CPU, by spawning as many test runners as you have CPU cores.
                                                                 This setting allows you to override this default behavior.

                                                                 Reasons you might want to lower this setting:
                                                                 
                                                                 -Your test runner starts a browser (another CPU-intensive process)
                                                                 -You're running on a shared server and/or
                                                                 -Your hard disk cannot handle the I/O of all test runners",
            DefaultValue = _defaultOptions.MaxConcurrentTestrunners,
            JsonKey = "max-concurrent-test-runners"
        };

        public static readonly CLIOption<int> ThresholdBreak = new CLIOption<int>
        {
            ArgumentName = "--threshold-break",
            ArgumentShortName = "-tb <thresholdBreak>",
            ArgumentDescription = $"Set the minimum mutation score threshold. Anything below this score will return a non-zero exit code. | {_defaultOptions.ThresholdOptions.ThresholdBreak} (default)",
            DefaultValue = _defaultOptions.ThresholdOptions.ThresholdBreak,
            JsonKey = "threshold-break"
        };

        public static readonly CLIOption<int> ThresholdLow = new CLIOption<int>
        {
            ArgumentName = "--threshold-low",
            ArgumentShortName = "-tl <thresholdLow>",
            ArgumentDescription = $"Set the lower bound of the mutation score threshold. It will not fail the test. | {_defaultOptions.ThresholdOptions.ThresholdLow} (default)",
            DefaultValue = _defaultOptions.ThresholdOptions.ThresholdLow,
            JsonKey = "threshold-low"
        };
        
        public static readonly CLIOption<int> ThresholdHigh = new CLIOption<int>
        {
            ArgumentName = "--threshold-high",
            ArgumentShortName = "-th <thresholdHigh>",
            ArgumentDescription = $"Set the prefered mutation score threshold. | {_defaultOptions.ThresholdOptions.ThresholdHigh} (default)",
            DefaultValue = _defaultOptions.ThresholdOptions.ThresholdHigh,
            JsonKey = "threshold-high"
        };
    }
}