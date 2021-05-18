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
    /// Extension methods for Regionadditionalinspectors.
    /// </summary>
    public static partial class RegionadditionalinspectorsExtensions
    {
            /// <summary>
            /// Get adoxio_region_additionalinspectors from adoxio_regions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioRegionid'>
            /// key: adoxio_regionid of adoxio_region
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
            public static MicrosoftDynamicsCRMadoxioAdditionalinspectorCollection Get(this IRegionadditionalinspectors operations, string adoxioRegionid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioRegionid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_region_additionalinspectors from adoxio_regions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioRegionid'>
            /// key: adoxio_regionid of adoxio_region
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
            public static async Task<MicrosoftDynamicsCRMadoxioAdditionalinspectorCollection> GetAsync(this IRegionadditionalinspectors operations, string adoxioRegionid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioRegionid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_region_additionalinspectors from adoxio_regions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioRegionid'>
            /// key: adoxio_regionid of adoxio_region
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioAdditionalinspectorCollection> GetWithHttpMessages(this IRegionadditionalinspectors operations, string adoxioRegionid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioRegionid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_region_additionalinspectors from adoxio_regions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioRegionid'>
            /// key: adoxio_regionid of adoxio_region
            /// </param>
            /// <param name='adoxioAdditionalinspectorid'>
            /// key: adoxio_additionalinspectorid of adoxio_additionalinspector
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioAdditionalinspector AdditionalinspectorsByKey(this IRegionadditionalinspectors operations, string adoxioRegionid, string adoxioAdditionalinspectorid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.AdditionalinspectorsByKeyAsync(adoxioRegionid, adoxioAdditionalinspectorid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_region_additionalinspectors from adoxio_regions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioRegionid'>
            /// key: adoxio_regionid of adoxio_region
            /// </param>
            /// <param name='adoxioAdditionalinspectorid'>
            /// key: adoxio_additionalinspectorid of adoxio_additionalinspector
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
            public static async Task<MicrosoftDynamicsCRMadoxioAdditionalinspector> AdditionalinspectorsByKeyAsync(this IRegionadditionalinspectors operations, string adoxioRegionid, string adoxioAdditionalinspectorid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AdditionalinspectorsByKeyWithHttpMessagesAsync(adoxioRegionid, adoxioAdditionalinspectorid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_region_additionalinspectors from adoxio_regions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioRegionid'>
            /// key: adoxio_regionid of adoxio_region
            /// </param>
            /// <param name='adoxioAdditionalinspectorid'>
            /// key: adoxio_additionalinspectorid of adoxio_additionalinspector
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioAdditionalinspector> AdditionalinspectorsByKeyWithHttpMessages(this IRegionadditionalinspectors operations, string adoxioRegionid, string adoxioAdditionalinspectorid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.AdditionalinspectorsByKeyWithHttpMessagesAsync(adoxioRegionid, adoxioAdditionalinspectorid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}