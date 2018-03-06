// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ListManagementImageLists.
    /// </summary>
    public static partial class ListManagementImageListsExtensions
    {
            /// <summary>
            /// Returns the details of the image list with list Id equal to list Id passed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='listId'>
            /// List Id of the image list.
            /// </param>
            public static ImageList GetDetails(this IListManagementImageLists operations, string listId)
            {
                return operations.GetDetailsAsync(listId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the details of the image list with list Id equal to list Id passed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='listId'>
            /// List Id of the image list.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImageList> GetDetailsAsync(this IListManagementImageLists operations, string listId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDetailsWithHttpMessagesAsync(listId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes image list with the list Id equal to list Id passed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='listId'>
            /// List Id of the image list.
            /// </param>
            public static string Delete(this IListManagementImageLists operations, string listId)
            {
                return operations.DeleteAsync(listId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes image list with the list Id equal to list Id passed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='listId'>
            /// List Id of the image list.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> DeleteAsync(this IListManagementImageLists operations, string listId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(listId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an image list with list Id equal to list Id passed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='listId'>
            /// List Id of the image list.
            /// </param>
            /// <param name='contentType'>
            /// The content type.
            /// </param>
            /// <param name='body'>
            /// Schema of the body.
            /// </param>
            public static ImageList Update(this IListManagementImageLists operations, string listId, string contentType, Body body)
            {
                return operations.UpdateAsync(listId, contentType, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an image list with list Id equal to list Id passed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='listId'>
            /// List Id of the image list.
            /// </param>
            /// <param name='contentType'>
            /// The content type.
            /// </param>
            /// <param name='body'>
            /// Schema of the body.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImageList> UpdateAsync(this IListManagementImageLists operations, string listId, string contentType, Body body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(listId, contentType, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an image list.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='contentType'>
            /// The content type.
            /// </param>
            /// <param name='body'>
            /// Schema of the body.
            /// </param>
            public static ImageList Create(this IListManagementImageLists operations, string contentType, Body body)
            {
                return operations.CreateAsync(contentType, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an image list.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='contentType'>
            /// The content type.
            /// </param>
            /// <param name='body'>
            /// Schema of the body.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImageList> CreateAsync(this IListManagementImageLists operations, string contentType, Body body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(contentType, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the Image Lists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<ImageList> GetAllImageLists(this IListManagementImageLists operations)
            {
                return operations.GetAllImageListsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the Image Lists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ImageList>> GetAllImageListsAsync(this IListManagementImageLists operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllImageListsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Refreshes the index of the list with list Id equal to list Id passed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='listId'>
            /// List Id of the image list.
            /// </param>
            public static RefreshIndex RefreshIndexMethod(this IListManagementImageLists operations, string listId)
            {
                return operations.RefreshIndexMethodAsync(listId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Refreshes the index of the list with list Id equal to list Id passed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='listId'>
            /// List Id of the image list.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RefreshIndex> RefreshIndexMethodAsync(this IListManagementImageLists operations, string listId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RefreshIndexMethodWithHttpMessagesAsync(listId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
