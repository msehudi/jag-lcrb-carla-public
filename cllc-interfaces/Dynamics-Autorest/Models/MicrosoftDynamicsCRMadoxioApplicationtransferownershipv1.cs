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
    /// Microsoft.Dynamics.CRM.adoxio_applicationtransferownershipv1
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1 class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1 class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1(string businessprocessflowinstanceid = default(string), string _modifiedbyValue = default(string), string _bpfAdoxioApplicationidValue = default(string), string _organizationidValue = default(string), string traversedpath = default(string), int? utcconversiontimezonecode = default(int?), int? statuscode = default(int?), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _activestageidValue = default(string), System.DateTimeOffset? activestagestartedon = default(System.DateTimeOffset?), string _processidValue = default(string), string versionnumber = default(string), int? bpfDuration = default(int?), string bpfName = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statecode = default(int?), int? importsequencenumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMprocessstage activestageidname = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMworkflow processidname = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMsyncerror> adoxioApplicationtransferownershipv1SyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioApplicationtransferownershipv1AsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMworkflowlog> adoxioApplicationtransferownershipv1WorkflowLogs = default(IList<MicrosoftDynamicsCRMworkflowlog>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioApplicationtransferownershipv1MailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioApplicationtransferownershipv1ProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioApplicationtransferownershipv1BulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioApplicationtransferownershipv1PrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioApplication bpfAdoxioApplicationid = default(MicrosoftDynamicsCRMadoxioApplication))
        {
            Businessprocessflowinstanceid = businessprocessflowinstanceid;
            this._modifiedbyValue = _modifiedbyValue;
            this._bpfAdoxioApplicationidValue = _bpfAdoxioApplicationidValue;
            this._organizationidValue = _organizationidValue;
            Traversedpath = traversedpath;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statuscode = statuscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            this._activestageidValue = _activestageidValue;
            Activestagestartedon = activestagestartedon;
            this._processidValue = _processidValue;
            Versionnumber = versionnumber;
            BpfDuration = bpfDuration;
            BpfName = bpfName;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Completedon = completedon;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            Statecode = statecode;
            Importsequencenumber = importsequencenumber;
            Modifiedon = modifiedon;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            Activestageidname = activestageidname;
            Processidname = processidname;
            AdoxioApplicationtransferownershipv1SyncErrors = adoxioApplicationtransferownershipv1SyncErrors;
            AdoxioApplicationtransferownershipv1AsyncOperations = adoxioApplicationtransferownershipv1AsyncOperations;
            AdoxioApplicationtransferownershipv1WorkflowLogs = adoxioApplicationtransferownershipv1WorkflowLogs;
            AdoxioApplicationtransferownershipv1MailboxTrackingFolders = adoxioApplicationtransferownershipv1MailboxTrackingFolders;
            AdoxioApplicationtransferownershipv1ProcessSession = adoxioApplicationtransferownershipv1ProcessSession;
            AdoxioApplicationtransferownershipv1BulkDeleteFailures = adoxioApplicationtransferownershipv1BulkDeleteFailures;
            AdoxioApplicationtransferownershipv1PrincipalObjectAttributeAccesses = adoxioApplicationtransferownershipv1PrincipalObjectAttributeAccesses;
            BpfAdoxioApplicationid = bpfAdoxioApplicationid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessprocessflowinstanceid")]
        public string Businessprocessflowinstanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bpf_adoxio_applicationid_value")]
        public string _bpfAdoxioApplicationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_activestageid_value")]
        public string _activestageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestagestartedon")]
        public System.DateTimeOffset? Activestagestartedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_duration")]
        public int? BpfDuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_name")]
        public string BpfName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestageidname")]
        public MicrosoftDynamicsCRMprocessstage Activestageidname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processidname")]
        public MicrosoftDynamicsCRMworkflow Processidname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtransferownershipv1_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioApplicationtransferownershipv1SyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtransferownershipv1_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioApplicationtransferownershipv1AsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtransferownershipv1_WorkflowLogs")]
        public IList<MicrosoftDynamicsCRMworkflowlog> AdoxioApplicationtransferownershipv1WorkflowLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtransferownershipv1_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioApplicationtransferownershipv1MailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtransferownershipv1_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioApplicationtransferownershipv1ProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtransferownershipv1_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioApplicationtransferownershipv1BulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtransferownershipv1_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioApplicationtransferownershipv1PrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_adoxio_applicationid")]
        public MicrosoftDynamicsCRMadoxioApplication BpfAdoxioApplicationid { get; set; }

    }
}
