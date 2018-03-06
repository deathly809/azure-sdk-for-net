// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CheckSkuAvailabilityOperations.
    /// </summary>
    public static partial class CheckSkuAvailabilityOperationsExtensions
    {
            /// <summary>
            /// Check available SKUs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Resource location.
            /// </param>
            /// <param name='skus'>
            /// The SKU of the resource.
            /// </param>
            /// <param name='kind'>
            /// The Kind of the resource. Possible values include: 'Academic',
            /// 'Bing.Autosuggest', 'Bing.Autosuggest.v7', 'Bing.CustomSearch',
            /// 'Bing.Search', 'Bing.Search.v7', 'Bing.Speech', 'Bing.SpellCheck',
            /// 'Bing.SpellCheck.v7', 'ComputerVision', 'ContentModerator', 'CustomSpeech',
            /// 'Emotion', 'Face', 'LUIS', 'Recommendations', 'SpeakerRecognition',
            /// 'Speech', 'SpeechTranslation', 'TextAnalytics', 'TextTranslation', 'WebLM'
            /// </param>
            /// <param name='type'>
            /// The Type of the resource.
            /// </param>
            public static CheckSkuAvailabilityResultList List(this ICheckSkuAvailabilityOperations operations, string location, IList<string> skus, string kind, string type)
            {
                return operations.ListAsync(location, skus, kind, type).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check available SKUs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Resource location.
            /// </param>
            /// <param name='skus'>
            /// The SKU of the resource.
            /// </param>
            /// <param name='kind'>
            /// The Kind of the resource. Possible values include: 'Academic',
            /// 'Bing.Autosuggest', 'Bing.Autosuggest.v7', 'Bing.CustomSearch',
            /// 'Bing.Search', 'Bing.Search.v7', 'Bing.Speech', 'Bing.SpellCheck',
            /// 'Bing.SpellCheck.v7', 'ComputerVision', 'ContentModerator', 'CustomSpeech',
            /// 'Emotion', 'Face', 'LUIS', 'Recommendations', 'SpeakerRecognition',
            /// 'Speech', 'SpeechTranslation', 'TextAnalytics', 'TextTranslation', 'WebLM'
            /// </param>
            /// <param name='type'>
            /// The Type of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckSkuAvailabilityResultList> ListAsync(this ICheckSkuAvailabilityOperations operations, string location, IList<string> skus, string kind, string type, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, skus, kind, type, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
