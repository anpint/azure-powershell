// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support
{

    /// <summary>Argument completer implementation for ExtensionCategory.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionCategoryTypeConverter))]
    public partial struct ExtensionCategory :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "NotSpecified".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("NotSpecified", "NotSpecified", global::System.Management.Automation.CompletionResultType.ParameterValue, "NotSpecified");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceCreationValidate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourceCreationValidate", "ResourceCreationValidate", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceCreationValidate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceCreationBegin".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourceCreationBegin", "ResourceCreationBegin", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceCreationBegin");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceCreationCompleted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourceCreationCompleted", "ResourceCreationCompleted", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceCreationCompleted");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceReadValidate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourceReadValidate", "ResourceReadValidate", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceReadValidate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceReadBegin".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourceReadBegin", "ResourceReadBegin", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceReadBegin");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourcePatchValidate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourcePatchValidate", "ResourcePatchValidate", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourcePatchValidate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourcePatchCompleted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourcePatchCompleted", "ResourcePatchCompleted", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourcePatchCompleted");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceDeletionValidate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourceDeletionValidate", "ResourceDeletionValidate", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceDeletionValidate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceDeletionBegin".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourceDeletionBegin", "ResourceDeletionBegin", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceDeletionBegin");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceDeletionCompleted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourceDeletionCompleted", "ResourceDeletionCompleted", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceDeletionCompleted");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourcePostAction".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourcePostAction", "ResourcePostAction", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourcePostAction");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SubscriptionLifecycleNotification".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SubscriptionLifecycleNotification", "SubscriptionLifecycleNotification", global::System.Management.Automation.CompletionResultType.ParameterValue, "SubscriptionLifecycleNotification");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourcePatchBegin".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourcePatchBegin", "ResourcePatchBegin", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourcePatchBegin");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceMoveBegin".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourceMoveBegin", "ResourceMoveBegin", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceMoveBegin");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ResourceMoveCompleted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ResourceMoveCompleted", "ResourceMoveCompleted", global::System.Management.Automation.CompletionResultType.ParameterValue, "ResourceMoveCompleted");
            }
        }
    }
}