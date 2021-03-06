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
    /// Extension methods for Adoxiolicencetypeadoxioinvestigationset.
    /// </summary>
    public static partial class AdoxiolicencetypeadoxioinvestigationsetExtensions
    {
            /// <summary>
            /// Get entities from adoxio_adoxio_licencetype_adoxio_investigationset
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
            public static MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigationCollection Get(this IAdoxiolicencetypeadoxioinvestigationset operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from adoxio_adoxio_licencetype_adoxio_investigationset
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
            public static async Task<MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigationCollection> GetAsync(this IAdoxiolicencetypeadoxioinvestigationset operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from adoxio_adoxio_licencetype_adoxio_investigationset
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigationCollection> GetWithHttpMessages(this IAdoxiolicencetypeadoxioinvestigationset operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_adoxio_licencetype_adoxio_investigationset
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
            public static MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation Create(this IAdoxiolicencetypeadoxioinvestigationset operations, MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_adoxio_licencetype_adoxio_investigationset
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
            public static async Task<MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation> CreateAsync(this IAdoxiolicencetypeadoxioinvestigationset operations, MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to adoxio_adoxio_licencetype_adoxio_investigationset
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation> CreateWithHttpMessages(this IAdoxiolicencetypeadoxioinvestigationset operations, MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_adoxio_licencetype_adoxio_investigationset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdoxioLicencetypeAdoxioInvestigationid'>
            /// key: adoxio_adoxio_licencetype_adoxio_investigationid of
            /// adoxio_adoxio_licencetype_adoxio_investigation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation GetByKey(this IAdoxiolicencetypeadoxioinvestigationset operations, string adoxioAdoxioLicencetypeAdoxioInvestigationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(adoxioAdoxioLicencetypeAdoxioInvestigationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_adoxio_licencetype_adoxio_investigationset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdoxioLicencetypeAdoxioInvestigationid'>
            /// key: adoxio_adoxio_licencetype_adoxio_investigationid of
            /// adoxio_adoxio_licencetype_adoxio_investigation
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
            public static async Task<MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation> GetByKeyAsync(this IAdoxiolicencetypeadoxioinvestigationset operations, string adoxioAdoxioLicencetypeAdoxioInvestigationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(adoxioAdoxioLicencetypeAdoxioInvestigationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from adoxio_adoxio_licencetype_adoxio_investigationset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdoxioLicencetypeAdoxioInvestigationid'>
            /// key: adoxio_adoxio_licencetype_adoxio_investigationid of
            /// adoxio_adoxio_licencetype_adoxio_investigation
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation> GetByKeyWithHttpMessages(this IAdoxiolicencetypeadoxioinvestigationset operations, string adoxioAdoxioLicencetypeAdoxioInvestigationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetByKeyWithHttpMessagesAsync(adoxioAdoxioLicencetypeAdoxioInvestigationid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_adoxio_licencetype_adoxio_investigationset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdoxioLicencetypeAdoxioInvestigationid'>
            /// key: adoxio_adoxio_licencetype_adoxio_investigationid of
            /// adoxio_adoxio_licencetype_adoxio_investigation
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this IAdoxiolicencetypeadoxioinvestigationset operations, string adoxioAdoxioLicencetypeAdoxioInvestigationid, MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation body)
            {
                operations.UpdateAsync(adoxioAdoxioLicencetypeAdoxioInvestigationid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_adoxio_licencetype_adoxio_investigationset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdoxioLicencetypeAdoxioInvestigationid'>
            /// key: adoxio_adoxio_licencetype_adoxio_investigationid of
            /// adoxio_adoxio_licencetype_adoxio_investigation
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IAdoxiolicencetypeadoxioinvestigationset operations, string adoxioAdoxioLicencetypeAdoxioInvestigationid, MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(adoxioAdoxioLicencetypeAdoxioInvestigationid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in adoxio_adoxio_licencetype_adoxio_investigationset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdoxioLicencetypeAdoxioInvestigationid'>
            /// key: adoxio_adoxio_licencetype_adoxio_investigationid of
            /// adoxio_adoxio_licencetype_adoxio_investigation
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse UpdateWithHttpMessages(this IAdoxiolicencetypeadoxioinvestigationset operations, string adoxioAdoxioLicencetypeAdoxioInvestigationid, MicrosoftDynamicsCRMadoxioAdoxioLicencetypeAdoxioInvestigation body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.UpdateWithHttpMessagesAsync(adoxioAdoxioLicencetypeAdoxioInvestigationid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_adoxio_licencetype_adoxio_investigationset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdoxioLicencetypeAdoxioInvestigationid'>
            /// key: adoxio_adoxio_licencetype_adoxio_investigationid of
            /// adoxio_adoxio_licencetype_adoxio_investigation
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this IAdoxiolicencetypeadoxioinvestigationset operations, string adoxioAdoxioLicencetypeAdoxioInvestigationid, string ifMatch = default(string))
            {
                operations.DeleteAsync(adoxioAdoxioLicencetypeAdoxioInvestigationid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_adoxio_licencetype_adoxio_investigationset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdoxioLicencetypeAdoxioInvestigationid'>
            /// key: adoxio_adoxio_licencetype_adoxio_investigationid of
            /// adoxio_adoxio_licencetype_adoxio_investigation
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAdoxiolicencetypeadoxioinvestigationset operations, string adoxioAdoxioLicencetypeAdoxioInvestigationid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(adoxioAdoxioLicencetypeAdoxioInvestigationid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from adoxio_adoxio_licencetype_adoxio_investigationset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAdoxioLicencetypeAdoxioInvestigationid'>
            /// key: adoxio_adoxio_licencetype_adoxio_investigationid of
            /// adoxio_adoxio_licencetype_adoxio_investigation
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse DeleteWithHttpMessages(this IAdoxiolicencetypeadoxioinvestigationset operations, string adoxioAdoxioLicencetypeAdoxioInvestigationid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.DeleteWithHttpMessagesAsync(adoxioAdoxioLicencetypeAdoxioInvestigationid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
