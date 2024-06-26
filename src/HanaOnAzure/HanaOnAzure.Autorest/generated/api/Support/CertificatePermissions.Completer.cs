// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support
{

    /// <summary>Argument completer implementation for CertificatePermissions.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.CertificatePermissionsTypeConverter))]
    public partial struct CertificatePermissions :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "get".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'get'", "get", global::System.Management.Automation.CompletionResultType.ParameterValue, "get");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "list".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'list'", "list", global::System.Management.Automation.CompletionResultType.ParameterValue, "list");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "delete".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'delete'", "delete", global::System.Management.Automation.CompletionResultType.ParameterValue, "delete");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "create".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'create'", "create", global::System.Management.Automation.CompletionResultType.ParameterValue, "create");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "import".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'import'", "import", global::System.Management.Automation.CompletionResultType.ParameterValue, "import");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "update".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'update'", "update", global::System.Management.Automation.CompletionResultType.ParameterValue, "update");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "managecontacts".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'managecontacts'", "managecontacts", global::System.Management.Automation.CompletionResultType.ParameterValue, "managecontacts");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "getissuers".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'getissuers'", "getissuers", global::System.Management.Automation.CompletionResultType.ParameterValue, "getissuers");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "listissuers".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'listissuers'", "listissuers", global::System.Management.Automation.CompletionResultType.ParameterValue, "listissuers");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "setissuers".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'setissuers'", "setissuers", global::System.Management.Automation.CompletionResultType.ParameterValue, "setissuers");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "deleteissuers".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'deleteissuers'", "deleteissuers", global::System.Management.Automation.CompletionResultType.ParameterValue, "deleteissuers");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "manageissuers".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'manageissuers'", "manageissuers", global::System.Management.Automation.CompletionResultType.ParameterValue, "manageissuers");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "recover".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'recover'", "recover", global::System.Management.Automation.CompletionResultType.ParameterValue, "recover");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "purge".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'purge'", "purge", global::System.Management.Automation.CompletionResultType.ParameterValue, "purge");
            }
        }
    }
}