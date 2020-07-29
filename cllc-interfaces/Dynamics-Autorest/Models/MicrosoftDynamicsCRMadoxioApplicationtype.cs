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
    /// Microsoft.Dynamics.CRM.adoxio_applicationtype
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioApplicationtype
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationtype()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationtype(string adoxioDynamicapplicationform = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), bool? adoxioIsshowassociatesformupload = default(bool?), bool? adoxioIslgzoningconfirmation = default(bool?), bool? adoxioShowdescription1 = default(bool?), bool? adoxioIsshowcurrentproperty = default(bool?), int? adoxioCategory = default(int?), int? adoxioProofofzoning = default(int?), bool? adoxioIsshowhoursofsale = default(bool?), int? adoxioLetterofintent = default(int?), bool? adoxioServiceareas = default(bool?), string adoxioTitletext = default(string), bool? adoxioShowdescription3 = default(bool?), bool? adoxioIsshowpropertydetails = default(bool?), string adoxioActiontext = default(string), string adoxioName = default(string), int? adoxioCurrentestablishmentaddress = default(int?), string _adoxioRenewalapplicationtypeValue = default(string), int? adoxioNewestablishmentaddress = default(int?), string _owningbusinessunitValue = default(string), int? adoxioIsfree = default(int?), bool? adoxioIsshowdeclarations = default(bool?), string adoxioCode = default(string), bool? adoxioOutsideareas = default(bool?), string _owneridValue = default(string), int? adoxioBusinessplan = default(int?), bool? adoxioIsshowlginapproval = default(bool?), int? importsequencenumber = default(int?), string _createdbyValue = default(string), int? adoxioSignage = default(int?), int? statecode = default(int?), int? statuscode = default(int?), int? adoxioSitephotographs = default(int?), string _owningteamValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? adoxioValidinterest = default(int?), bool? adoxioIsendorsement = default(bool?), bool? adoxioIsshowfinancialintegrityformupload = default(bool?), int? adoxioFloorplan = default(int?), int? adoxioConnectedgrocerystore = default(int?), string adoxioPortallabel = default(string), string adoxioDefaultbpfid = default(string), bool? adoxioIsshowsupportingdocuments = default(bool?), bool? adoxioIswineryproduction = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioFormreference = default(string), int? adoxioPubliccoolerspace = default(int?), bool? adoxioCapacityarea = default(bool?), string _modifiedbyValue = default(string), int? adoxioFinalinspectionduetime = default(int?), bool? adoxioIsdefault = default(bool?), bool? adoxioRequiressecurityscreening = default(bool?), int? adoxioEstablishmentname = default(int?), bool? adoxioShowdescription2 = default(bool?), int? adoxioStorecontactinfo = default(int?), int? timezoneruleversionnumber = default(int?), string versionnumber = default(string), string adoxioDefaultbpmid = default(string), int? adoxioLgandpoliceselectors = default(int?), int? adoxioRoutineinspectionoccurrence = default(int?), int? adoxioSiteplan = default(int?), string _modifiedonbehalfbyValue = default(string), bool? adoxioIslockestablishmentname = default(bool?), int? adoxioFinalinspectionduetimeunit = default(int?), int? utcconversiontimezonecode = default(int?), string adoxioApplicationtypeid = default(string), int? adoxioLiquorsiteplan = default(int?), bool? adoxioIsshowliquordeclarations = default(bool?), string adoxioDefaultqueuename = default(string), string _adoxioApplicationfeeproductValue = default(string), string _owninguserValue = default(string), string _adoxioLicencetypeValue = default(string), bool? adoxioIsownershipconfirmation = default(bool?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioApplicationtypeSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioApplicationtypeDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioApplicationtypeDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioApplicationtypeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioApplicationtypeMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioApplicationtypeProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioApplicationtypeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioApplicationtypePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioApplicationtypeApplications = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioLicencetype> adoxioLicencetypesApplicationtypes = default(IList<MicrosoftDynamicsCRMadoxioLicencetype>), IList<MicrosoftDynamicsCRMadoxioApplicationtypecontent> adoxioApplicationtypeAdoxioApplicationtypecontentApplicationType = default(IList<MicrosoftDynamicsCRMadoxioApplicationtypecontent>), MicrosoftDynamicsCRMproduct adoxioApplicationFeeProduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMadoxioLicencetype adoxioLicenceType = default(MicrosoftDynamicsCRMadoxioLicencetype), IList<MicrosoftDynamicsCRMincident> adoxioApplicationtypeInspections = default(IList<MicrosoftDynamicsCRMincident>), MicrosoftDynamicsCRMadoxioApplicationtype adoxioRenewalApplicationType = default(MicrosoftDynamicsCRMadoxioApplicationtype), IList<MicrosoftDynamicsCRMadoxioApplicationtype> adoxioApplicationtypeRenewalType = default(IList<MicrosoftDynamicsCRMadoxioApplicationtype>), IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> adoxioApplicationtypeAdoxioLicenseechangelogApplicationType = default(IList<MicrosoftDynamicsCRMadoxioLicenseechangelog>), IList<MicrosoftDynamicsCRMadoxioFormelementuploadfield> adoxioApplicationtypeFormelementuploadfields = default(IList<MicrosoftDynamicsCRMadoxioFormelementuploadfield>), IList<MicrosoftDynamicsCRMadoxioApplicationtypefeeschedule> adoxioApplicationtypeAdoxioApplicationtypefeescheduleApplicationTypeId = default(IList<MicrosoftDynamicsCRMadoxioApplicationtypefeeschedule>), IList<MicrosoftDynamicsCRMadoxioEndorsement> adoxioApplicationtypeAdoxioEndorsementApplicationType = default(IList<MicrosoftDynamicsCRMadoxioEndorsement>))
        {
            AdoxioDynamicapplicationform = adoxioDynamicapplicationform;
            Overriddencreatedon = overriddencreatedon;
            AdoxioIsshowassociatesformupload = adoxioIsshowassociatesformupload;
            AdoxioIslgzoningconfirmation = adoxioIslgzoningconfirmation;
            AdoxioShowdescription1 = adoxioShowdescription1;
            AdoxioIsshowcurrentproperty = adoxioIsshowcurrentproperty;
            AdoxioCategory = adoxioCategory;
            AdoxioProofofzoning = adoxioProofofzoning;
            AdoxioIsshowhoursofsale = adoxioIsshowhoursofsale;
            AdoxioLetterofintent = adoxioLetterofintent;
            AdoxioServiceareas = adoxioServiceareas;
            AdoxioTitletext = adoxioTitletext;
            AdoxioShowdescription3 = adoxioShowdescription3;
            AdoxioIsshowpropertydetails = adoxioIsshowpropertydetails;
            AdoxioActiontext = adoxioActiontext;
            AdoxioName = adoxioName;
            AdoxioCurrentestablishmentaddress = adoxioCurrentestablishmentaddress;
            this._adoxioRenewalapplicationtypeValue = _adoxioRenewalapplicationtypeValue;
            AdoxioNewestablishmentaddress = adoxioNewestablishmentaddress;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioIsfree = adoxioIsfree;
            AdoxioIsshowdeclarations = adoxioIsshowdeclarations;
            AdoxioCode = adoxioCode;
            AdoxioOutsideareas = adoxioOutsideareas;
            this._owneridValue = _owneridValue;
            AdoxioBusinessplan = adoxioBusinessplan;
            AdoxioIsshowlginapproval = adoxioIsshowlginapproval;
            Importsequencenumber = importsequencenumber;
            this._createdbyValue = _createdbyValue;
            AdoxioSignage = adoxioSignage;
            Statecode = statecode;
            Statuscode = statuscode;
            AdoxioSitephotographs = adoxioSitephotographs;
            this._owningteamValue = _owningteamValue;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioValidinterest = adoxioValidinterest;
            AdoxioIsendorsement = adoxioIsendorsement;
            AdoxioIsshowfinancialintegrityformupload = adoxioIsshowfinancialintegrityformupload;
            AdoxioFloorplan = adoxioFloorplan;
            AdoxioConnectedgrocerystore = adoxioConnectedgrocerystore;
            AdoxioPortallabel = adoxioPortallabel;
            AdoxioDefaultbpfid = adoxioDefaultbpfid;
            AdoxioIsshowsupportingdocuments = adoxioIsshowsupportingdocuments;
            AdoxioIswineryproduction = adoxioIswineryproduction;
            Modifiedon = modifiedon;
            AdoxioFormreference = adoxioFormreference;
            AdoxioPubliccoolerspace = adoxioPubliccoolerspace;
            AdoxioCapacityarea = adoxioCapacityarea;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioFinalinspectionduetime = adoxioFinalinspectionduetime;
            AdoxioIsdefault = adoxioIsdefault;
            AdoxioRequiressecurityscreening = adoxioRequiressecurityscreening;
            AdoxioEstablishmentname = adoxioEstablishmentname;
            AdoxioShowdescription2 = adoxioShowdescription2;
            AdoxioStorecontactinfo = adoxioStorecontactinfo;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Versionnumber = versionnumber;
            AdoxioDefaultbpmid = adoxioDefaultbpmid;
            AdoxioLgandpoliceselectors = adoxioLgandpoliceselectors;
            AdoxioRoutineinspectionoccurrence = adoxioRoutineinspectionoccurrence;
            AdoxioSiteplan = adoxioSiteplan;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioIslockestablishmentname = adoxioIslockestablishmentname;
            AdoxioFinalinspectionduetimeunit = adoxioFinalinspectionduetimeunit;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioApplicationtypeid = adoxioApplicationtypeid;
            AdoxioLiquorsiteplan = adoxioLiquorsiteplan;
            AdoxioIsshowliquordeclarations = adoxioIsshowliquordeclarations;
            AdoxioDefaultqueuename = adoxioDefaultqueuename;
            this._adoxioApplicationfeeproductValue = _adoxioApplicationfeeproductValue;
            this._owninguserValue = _owninguserValue;
            this._adoxioLicencetypeValue = _adoxioLicencetypeValue;
            AdoxioIsownershipconfirmation = adoxioIsownershipconfirmation;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioApplicationtypeSyncErrors = adoxioApplicationtypeSyncErrors;
            AdoxioApplicationtypeDuplicateMatchingRecord = adoxioApplicationtypeDuplicateMatchingRecord;
            AdoxioApplicationtypeDuplicateBaseRecord = adoxioApplicationtypeDuplicateBaseRecord;
            AdoxioApplicationtypeAsyncOperations = adoxioApplicationtypeAsyncOperations;
            AdoxioApplicationtypeMailboxTrackingFolders = adoxioApplicationtypeMailboxTrackingFolders;
            AdoxioApplicationtypeProcessSession = adoxioApplicationtypeProcessSession;
            AdoxioApplicationtypeBulkDeleteFailures = adoxioApplicationtypeBulkDeleteFailures;
            AdoxioApplicationtypePrincipalObjectAttributeAccesses = adoxioApplicationtypePrincipalObjectAttributeAccesses;
            AdoxioApplicationtypeApplications = adoxioApplicationtypeApplications;
            AdoxioLicencetypesApplicationtypes = adoxioLicencetypesApplicationtypes;
            AdoxioApplicationtypeAdoxioApplicationtypecontentApplicationType = adoxioApplicationtypeAdoxioApplicationtypecontentApplicationType;
            AdoxioApplicationFeeProduct = adoxioApplicationFeeProduct;
            AdoxioLicenceType = adoxioLicenceType;
            AdoxioApplicationtypeInspections = adoxioApplicationtypeInspections;
            AdoxioRenewalApplicationType = adoxioRenewalApplicationType;
            AdoxioApplicationtypeRenewalType = adoxioApplicationtypeRenewalType;
            AdoxioApplicationtypeAdoxioLicenseechangelogApplicationType = adoxioApplicationtypeAdoxioLicenseechangelogApplicationType;
            AdoxioApplicationtypeFormelementuploadfields = adoxioApplicationtypeFormelementuploadfields;
            AdoxioApplicationtypeAdoxioApplicationtypefeescheduleApplicationTypeId = adoxioApplicationtypeAdoxioApplicationtypefeescheduleApplicationTypeId;
            AdoxioApplicationtypeAdoxioEndorsementApplicationType = adoxioApplicationtypeAdoxioEndorsementApplicationType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dynamicapplicationform")]
        public string AdoxioDynamicapplicationform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowassociatesformupload")]
        public bool? AdoxioIsshowassociatesformupload { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_islgzoningconfirmation")]
        public bool? AdoxioIslgzoningconfirmation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_showdescription1")]
        public bool? AdoxioShowdescription1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowcurrentproperty")]
        public bool? AdoxioIsshowcurrentproperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_category")]
        public int? AdoxioCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_proofofzoning")]
        public int? AdoxioProofofzoning { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowhoursofsale")]
        public bool? AdoxioIsshowhoursofsale { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_letterofintent")]
        public int? AdoxioLetterofintent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_serviceareas")]
        public bool? AdoxioServiceareas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_titletext")]
        public string AdoxioTitletext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_showdescription3")]
        public bool? AdoxioShowdescription3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowpropertydetails")]
        public bool? AdoxioIsshowpropertydetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_actiontext")]
        public string AdoxioActiontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_currentestablishmentaddress")]
        public int? AdoxioCurrentestablishmentaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_renewalapplicationtype_value")]
        public string _adoxioRenewalapplicationtypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_newestablishmentaddress")]
        public int? AdoxioNewestablishmentaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isfree")]
        public int? AdoxioIsfree { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowdeclarations")]
        public bool? AdoxioIsshowdeclarations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_code")]
        public string AdoxioCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_outsideareas")]
        public bool? AdoxioOutsideareas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_businessplan")]
        public int? AdoxioBusinessplan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowlginapproval")]
        public bool? AdoxioIsshowlginapproval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_signage")]
        public int? AdoxioSignage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sitephotographs")]
        public int? AdoxioSitephotographs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_validinterest")]
        public int? AdoxioValidinterest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isendorsement")]
        public bool? AdoxioIsendorsement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowfinancialintegrityformupload")]
        public bool? AdoxioIsshowfinancialintegrityformupload { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_floorplan")]
        public int? AdoxioFloorplan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_connectedgrocerystore")]
        public int? AdoxioConnectedgrocerystore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_portallabel")]
        public string AdoxioPortallabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_defaultbpfid")]
        public string AdoxioDefaultbpfid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowsupportingdocuments")]
        public bool? AdoxioIsshowsupportingdocuments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iswineryproduction")]
        public bool? AdoxioIswineryproduction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_formreference")]
        public string AdoxioFormreference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_publiccoolerspace")]
        public int? AdoxioPubliccoolerspace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_capacityarea")]
        public bool? AdoxioCapacityarea { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_finalinspectionduetime")]
        public int? AdoxioFinalinspectionduetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isdefault")]
        public bool? AdoxioIsdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_requiressecurityscreening")]
        public bool? AdoxioRequiressecurityscreening { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishmentname")]
        public int? AdoxioEstablishmentname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_showdescription2")]
        public bool? AdoxioShowdescription2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_storecontactinfo")]
        public int? AdoxioStorecontactinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_defaultbpmid")]
        public string AdoxioDefaultbpmid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lgandpoliceselectors")]
        public int? AdoxioLgandpoliceselectors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_routineinspectionoccurrence")]
        public int? AdoxioRoutineinspectionoccurrence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_siteplan")]
        public int? AdoxioSiteplan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_islockestablishmentname")]
        public bool? AdoxioIslockestablishmentname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_finalinspectionduetimeunit")]
        public int? AdoxioFinalinspectionduetimeunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtypeid")]
        public string AdoxioApplicationtypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_liquorsiteplan")]
        public int? AdoxioLiquorsiteplan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowliquordeclarations")]
        public bool? AdoxioIsshowliquordeclarations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_defaultqueuename")]
        public string AdoxioDefaultqueuename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationfeeproduct_value")]
        public string _adoxioApplicationfeeproductValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licencetype_value")]
        public string _adoxioLicencetypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isownershipconfirmation")]
        public bool? AdoxioIsownershipconfirmation { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_applicationtype_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioApplicationtypeSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioApplicationtypeDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioApplicationtypeDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioApplicationtypeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioApplicationtypeMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioApplicationtypeProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioApplicationtypeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioApplicationtypePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_applications")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioApplicationtypeApplications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypes_applicationtypes")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetype> AdoxioLicencetypesApplicationtypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_adoxio_applicationtypecontent_ApplicationType")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtypecontent> AdoxioApplicationtypeAdoxioApplicationtypecontentApplicationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ApplicationFeeProduct")]
        public MicrosoftDynamicsCRMproduct AdoxioApplicationFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceType")]
        public MicrosoftDynamicsCRMadoxioLicencetype AdoxioLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_inspections")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioApplicationtypeInspections { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RenewalApplicationType")]
        public MicrosoftDynamicsCRMadoxioApplicationtype AdoxioRenewalApplicationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_RenewalType")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtype> AdoxioApplicationtypeRenewalType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_adoxio_licenseechangelog_ApplicationType")]
        public IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> AdoxioApplicationtypeAdoxioLicenseechangelogApplicationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_formelementuploadfields")]
        public IList<MicrosoftDynamicsCRMadoxioFormelementuploadfield> AdoxioApplicationtypeFormelementuploadfields { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_adoxio_applicationtypefeeschedule_ApplicationTypeId")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtypefeeschedule> AdoxioApplicationtypeAdoxioApplicationtypefeescheduleApplicationTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_adoxio_endorsement_ApplicationType")]
        public IList<MicrosoftDynamicsCRMadoxioEndorsement> AdoxioApplicationtypeAdoxioEndorsementApplicationType { get; set; }

    }
}
