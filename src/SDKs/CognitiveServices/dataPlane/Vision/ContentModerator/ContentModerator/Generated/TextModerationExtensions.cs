// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TextModeration.
    /// </summary>
    public static partial class TextModerationExtensions
    {
            /// <summary>
            /// Detect profanity and match against custom and shared blacklists
            /// </summary>
            /// <remarks>
            /// Detects profanity in more than 100 languages and match against custom and
            /// shared blacklists.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='language'>
            /// Language of the terms.
            /// </param>
            /// <param name='textContentType'>
            /// The content type. Possible values include: 'text/plain', 'text/html',
            /// 'text/xml', 'text/markdown'
            /// </param>
            /// <param name='textContent'>
            /// Content to screen.
            /// </param>
            /// <param name='autocorrect'>
            /// Autocorrect text.
            /// </param>
            /// <param name='pII'>
            /// Detect personal identifiable information.
            /// </param>
            /// <param name='listId'>
            /// The list Id.
            /// </param>
            /// <param name='classify'>
            /// Classify input.
            /// </param>
            public static Screen ScreenText(this ITextModeration operations, string language, string textContentType, string textContent, bool? autocorrect = false, bool? pII = false, string listId = default(string), bool? classify = false)
            {
                return operations.ScreenTextAsync(language, textContentType, textContent, autocorrect, pII, listId, classify).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Detect profanity and match against custom and shared blacklists
            /// </summary>
            /// <remarks>
            /// Detects profanity in more than 100 languages and match against custom and
            /// shared blacklists.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='language'>
            /// Language of the terms.
            /// </param>
            /// <param name='textContentType'>
            /// The content type. Possible values include: 'text/plain', 'text/html',
            /// 'text/xml', 'text/markdown'
            /// </param>
            /// <param name='textContent'>
            /// Content to screen.
            /// </param>
            /// <param name='autocorrect'>
            /// Autocorrect text.
            /// </param>
            /// <param name='pII'>
            /// Detect personal identifiable information.
            /// </param>
            /// <param name='listId'>
            /// The list Id.
            /// </param>
            /// <param name='classify'>
            /// Classify input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Screen> ScreenTextAsync(this ITextModeration operations, string language, string textContentType, string textContent, bool? autocorrect = false, bool? pII = false, string listId = default(string), bool? classify = false, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ScreenTextWithHttpMessagesAsync(language, textContentType, textContent, autocorrect, pII, listId, classify, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation will detect the language of given input content. Returns the
            /// &lt;a href="http://www-01.sil.org/iso639-3/codes.asp"&gt;ISO 639-3
            /// code&lt;/a&gt; for the predominant language comprising the submitted text.
            /// Over 110 languages supported.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='textContentType'>
            /// The content type. Possible values include: 'text/plain', 'text/html',
            /// 'text/xml', 'text/markdown'
            /// </param>
            /// <param name='textContent'>
            /// Content to screen.
            /// </param>
            public static DetectedLanguage DetectLanguage(this ITextModeration operations, string textContentType, string textContent)
            {
                return operations.DetectLanguageAsync(textContentType, textContent).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation will detect the language of given input content. Returns the
            /// &lt;a href="http://www-01.sil.org/iso639-3/codes.asp"&gt;ISO 639-3
            /// code&lt;/a&gt; for the predominant language comprising the submitted text.
            /// Over 110 languages supported.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='textContentType'>
            /// The content type. Possible values include: 'text/plain', 'text/html',
            /// 'text/xml', 'text/markdown'
            /// </param>
            /// <param name='textContent'>
            /// Content to screen.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DetectedLanguage> DetectLanguageAsync(this ITextModeration operations, string textContentType, string textContent, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DetectLanguageWithHttpMessagesAsync(textContentType, textContent, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
