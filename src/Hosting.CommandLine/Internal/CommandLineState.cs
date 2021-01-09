// Copyright (c) Nate McMaster.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using McMaster.Extensions.CommandLineUtils;
using McMaster.Extensions.CommandLineUtils.Abstractions;

namespace McMaster.Extensions.Hosting.CommandLine.Internal
{
    /// <summary>
    ///     A DI container for storing command line arguments.
    /// </summary>
    public class CommandLineState : CommandLineContext
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="args"></param>
        public CommandLineState(string[] args)
        {
            Arguments = args;
        }

        internal void SetConsole(IConsole console)
        {
            Console = console;
        }

        /// <summary>
        /// Exit code of the application.
        /// </summary>
        public int ExitCode { get; set; }
    }
}
