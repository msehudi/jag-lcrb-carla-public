// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.adoxio_endorsement
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioEndorsement
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEndorsement class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEndorsement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEndorsement class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEndorsement(int? utcconversiontimezonecode = default(int?), int? adoxioLicensedserviceareacountState = default(int?), System.DateTimeOffset? adoxioLicensedhoursofservicecountDate = default(System.DateTimeOffset?), int? adoxioLicensedhoursofservicecountState = default(int?), int? adoxioLicensedserviceareacount = default(int?), string _modifiedbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _adoxioLicenceValue = default(string), int? adoxioLicensedhoursofservicecount = default(int?), string adoxioCancelledsuspendedreason = default(string), System.DateTimeOffset? adoxioDatecancelledsuspended = default(System.DateTimeOffset?), string adoxioEndorsementid = default(string), string _owningbusinessunitValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _adoxioLicencewhencancelledValue = default(string), int? importsequencenumber = default(int?), int? statecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _adoxioApplicationtypeValue = default(string), int? statuscode = default(int?), string _owningteamValue = default(string), string _createdbyValue = default(string), string _adoxioApplicationValue = default(string), string _owneridValue = default(string), System.DateTimeOffset? adoxioDateissuedreinstated = default(System.DateTimeOffset?), string _owninguserValue = default(string), string adoxioExternalid = default(string), string versionnumber = default(string), System.DateTimeOffset? adoxioLicensedserviceareacountDate = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string adoxioName = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioEndorsementSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioEndorsementDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioEndorsementDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioEndorsementSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioEndorsementAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioEndorsementMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioEndorsementProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioEndorsementBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioEndorsementPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioApplication adoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioLicences adoxioLicence = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioApplicationtype adoxioApplicationType = default(MicrosoftDynamicsCRMadoxioApplicationtype), IList<MicrosoftDynamicsCRMadoxioHoursofservice> adoxioEndorsementAdoxioHoursofserviceEndorsement = default(IList<MicrosoftDynamicsCRMadoxioHoursofservice>), IList<MicrosoftDynamicsCRMadoxioServicearea> adoxioEndorsementAdoxioServiceareaEndorsement = default(IList<MicrosoftDynamicsCRMadoxioServicearea>), IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> adoxioEndorsementAdoxioApplicationtermsconditionslimitationEndorsement = default(IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation>), MicrosoftDynamicsCRMadoxioLicences adoxioLicenceWhenCancelled = default(MicrosoftDynamicsCRMadoxioLicences))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioLicensedserviceareacountState = adoxioLicensedserviceareacountState;
            AdoxioLicensedhoursofservicecountDate = adoxioLicensedhoursofservicecountDate;
            AdoxioLicensedhoursofservicecountState = adoxioLicensedhoursofservicecountState;
            AdoxioLicensedserviceareacount = adoxioLicensedserviceareacount;
            this._modifiedbyValue = _modifiedbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._adoxioLicenceValue = _adoxioLicenceValue;
            AdoxioLicensedhoursofservicecount = adoxioLicensedhoursofservicecount;
            AdoxioCancelledsuspendedreason = adoxioCancelledsuspendedreason;
            AdoxioDatecancelledsuspended = adoxioDatecancelledsuspended;
            AdoxioEndorsementid = adoxioEndorsementid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._adoxioLicencewhencancelledValue = _adoxioLicencewhencancelledValue;
            Importsequencenumber = importsequencenumber;
            Statecode = statecode;
            Overriddencreatedon = overriddencreatedon;
            this._adoxioApplicationtypeValue = _adoxioApplicationtypeValue;
            Statuscode = statuscode;
            this._owningteamValue = _owningteamValue;
            this._createdbyValue = _createdbyValue;
            this._adoxioApplicationValue = _adoxioApplicationValue;
            this._owneridValue = _owneridValue;
            AdoxioDateissuedreinstated = adoxioDateissuedreinstated;
            this._owninguserValue = _owninguserValue;
            AdoxioExternalid = adoxioExternalid;
            Versionnumber = versionnumber;
            AdoxioLicensedserviceareacountDate = adoxioLicensedserviceareacountDate;
            Createdon = createdon;
            AdoxioName = adoxioName;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioEndorsementSyncErrors = adoxioEndorsementSyncErrors;
            AdoxioEndorsementDuplicateMatchingRecord = adoxioEndorsementDuplicateMatchingRecord;
            AdoxioEndorsementDuplicateBaseRecord = adoxioEndorsementDuplicateBaseRecord;
            AdoxioEndorsementSharePointDocumentLocations = adoxioEndorsementSharePointDocumentLocations;
            AdoxioEndorsementAsyncOperations = adoxioEndorsementAsyncOperations;
            AdoxioEndorsementMailboxTrackingFolders = adoxioEndorsementMailboxTrackingFolders;
            AdoxioEndorsementProcessSession = adoxioEndorsementProcessSession;
            AdoxioEndorsementBulkDeleteFailures = adoxioEndorsementBulkDeleteFailures;
            AdoxioEndorsementPrincipalObjectAttributeAccesses = adoxioEndorsementPrincipalObjectAttributeAccesses;
            AdoxioApplication = adoxioApplication;
            AdoxioLicence = adoxioLicence;
            AdoxioApplicationType = adoxioApplicationType;
            AdoxioEndorsementAdoxioHoursofserviceEndorsement = adoxioEndorsementAdoxioHoursofserviceEndorsement;
            AdoxioEndorsementAdoxioServiceareaEndorsement = adoxioEndorsementAdoxioServiceareaEndorsement;
            AdoxioEndorsementAdoxioApplicationtermsconditionslimitationEndorsement = adoxioEndorsementAdoxioApplicationtermsconditionslimitationEndorsement;
            AdoxioLicenceWhenCancelled = adoxioLicenceWhenCancelled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licensedserviceareacount_state")]
        public int? AdoxioLicensedserviceareacountState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licensedhoursofservicecount_date")]
        public System.DateTimeOffset? AdoxioLicensedhoursofservicecountDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licensedhoursofservicecount_state")]
        public int? AdoxioLicensedhoursofservicecountState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licensedserviceareacount")]
        public int? AdoxioLicensedserviceareacount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licence_value")]
        public string _adoxioLicenceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licensedhoursofservicecount")]
        public int? AdoxioLicensedhoursofservicecount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cancelledsuspendedreason")]
        public string AdoxioCancelledsuspendedreason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_datecancelledsuspended")]
        public System.DateTimeOffset? AdoxioDatecancelledsuspended { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsementid")]
        public string AdoxioEndorsementid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licencewhencancelled_value")]
        public string _adoxioLicencewhencancelledValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationtype_value")]
        public string _adoxioApplicationtypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_application_value")]
        public string _adoxioApplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateissuedreinstated")]
        public System.DateTimeOffset? AdoxioDateissuedreinstated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_externalid")]
        public string AdoxioExternalid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licensedserviceareacount_date")]
        public System.DateTimeOffset? AdoxioLicensedserviceareacountDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioEndorsementSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioEndorsementDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioEndorsementDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioEndorsementSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioEndorsementAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioEndorsementMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioEndorsementProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioEndorsementBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioEndorsementPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Application")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Licence")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ApplicationType")]
        public MicrosoftDynamicsCRMadoxioApplicationtype AdoxioApplicationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_adoxio_hoursofservice_Endorsement")]
        public IList<MicrosoftDynamicsCRMadoxioHoursofservice> AdoxioEndorsementAdoxioHoursofserviceEndorsement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_adoxio_servicearea_Endorsement")]
        public IList<MicrosoftDynamicsCRMadoxioServicearea> AdoxioEndorsementAdoxioServiceareaEndorsement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_adoxio_applicationtermsconditionslimitation_Endorsement")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> AdoxioEndorsementAdoxioApplicationtermsconditionslimitationEndorsement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceWhenCancelled")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicenceWhenCancelled { get; set; }

    }
}
