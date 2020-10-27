// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>Resource type used for verification.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CheckNameResourceTypesTypeConverter))]
    public partial struct CheckNameResourceTypes :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Site".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Site", "Site", global::System.Management.Automation.CompletionResultType.ParameterValue, "Site");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Slot".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Slot", "Slot", global::System.Management.Automation.CompletionResultType.ParameterValue, "Slot");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "HostingEnvironment".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("HostingEnvironment", "HostingEnvironment", global::System.Management.Automation.CompletionResultType.ParameterValue, "HostingEnvironment");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PublishingUser".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("PublishingUser", "PublishingUser", global::System.Management.Automation.CompletionResultType.ParameterValue, "PublishingUser");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Microsoft.Web/sites".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Microsoft.Web/sites", "Microsoft.Web/sites", global::System.Management.Automation.CompletionResultType.ParameterValue, "Microsoft.Web/sites");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Microsoft.Web/sites/slots".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Microsoft.Web/sites/slots", "Microsoft.Web/sites/slots", global::System.Management.Automation.CompletionResultType.ParameterValue, "Microsoft.Web/sites/slots");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Microsoft.Web/hostingEnvironments".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Microsoft.Web/hostingEnvironments", "Microsoft.Web/hostingEnvironments", global::System.Management.Automation.CompletionResultType.ParameterValue, "Microsoft.Web/hostingEnvironments");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Microsoft.Web/publishingUsers".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Microsoft.Web/publishingUsers", "Microsoft.Web/publishingUsers", global::System.Management.Automation.CompletionResultType.ParameterValue, "Microsoft.Web/publishingUsers");
            }
        }
    }
}