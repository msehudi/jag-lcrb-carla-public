// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Sepdrinktypes.
    /// </summary>
    public static partial class SepdrinktypesExtensions
    {
            /// <summary>
            /// Get entities from adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioSepdrinktypeCollection Get(this ISepdrinktypes operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioSepdrinktypeCollection> GetAsync(this ISepdrinktypes operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioSepdrinktypeCollection> GetWithHttpMessages(this ISepdrinktypes operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            public static MicrosoftDynamicsCRMadoxioSepdrinktype Create(this ISepdrinktypes operations, MicrosoftDynamicsCRMadoxioSepdrinktype body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioSepdrinktype> CreateAsync(this ISepdrinktypes operations, MicrosoftDynamicsCRMadoxioSepdrinktype body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioSepdrinktype> CreateWithHttpMessages(this ISepdrinktypes operations, MicrosoftDynamicsCRMadoxioSepdrinktype body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_sepdrinktypes by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinktypeid'>
            /// key: adoxio_sepdrinktypeid of adoxio_sepdrinktype
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioSepdrinktype GetByKey(this ISepdrinktypes operations, string adoxioSepdrinktypeid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(adoxioSepdrinktypeid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_sepdrinktypes by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinktypeid'>
            /// key: adoxio_sepdrinktypeid of adoxio_sepdrinktype
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioSepdrinktype> GetByKeyAsync(this ISepdrinktypes operations, string adoxioSepdrinktypeid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(adoxioSepdrinktypeid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from adoxio_sepdrinktypes by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinktypeid'>
            /// key: adoxio_sepdrinktypeid of adoxio_sepdrinktype
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioSepdrinktype> GetByKeyWithHttpMessages(this ISepdrinktypes operations, string adoxioSepdrinktypeid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetByKeyWithHttpMessagesAsync(adoxioSepdrinktypeid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinktypeid'>
            /// key: adoxio_sepdrinktypeid of adoxio_sepdrinktype
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this ISepdrinktypes operations, string adoxioSepdrinktypeid, MicrosoftDynamicsCRMadoxioSepdrinktype body)
            {
                operations.UpdateAsync(adoxioSepdrinktypeid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinktypeid'>
            /// key: adoxio_sepdrinktypeid of adoxio_sepdrinktype
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this ISepdrinktypes operations, string adoxioSepdrinktypeid, MicrosoftDynamicsCRMadoxioSepdrinktype body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(adoxioSepdrinktypeid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinktypeid'>
            /// key: adoxio_sepdrinktypeid of adoxio_sepdrinktype
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse UpdateWithHttpMessages(this ISepdrinktypes operations, string adoxioSepdrinktypeid, MicrosoftDynamicsCRMadoxioSepdrinktype body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.UpdateWithHttpMessagesAsync(adoxioSepdrinktypeid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinktypeid'>
            /// key: adoxio_sepdrinktypeid of adoxio_sepdrinktype
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this ISepdrinktypes operations, string adoxioSepdrinktypeid, string ifMatch = default(string))
            {
                operations.DeleteAsync(adoxioSepdrinktypeid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinktypeid'>
            /// key: adoxio_sepdrinktypeid of adoxio_sepdrinktype
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISepdrinktypes operations, string adoxioSepdrinktypeid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(adoxioSepdrinktypeid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from adoxio_sepdrinktypes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinktypeid'>
            /// key: adoxio_sepdrinktypeid of adoxio_sepdrinktype
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse DeleteWithHttpMessages(this ISepdrinktypes operations, string adoxioSepdrinktypeid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.DeleteWithHttpMessagesAsync(adoxioSepdrinktypeid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
