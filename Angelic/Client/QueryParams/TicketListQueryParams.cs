
using Newtonsoft.Json;

// ReSharper disable InvalidXmlDocComment

namespace Angelic.Client.QueryParams;

public class TicketListQueryParams
{
    /// <param name="agent">(array of int) Returns tickets based on Agent ID's in the array.</param>
    public int[]? Agent { get; set; }
    /// <param name="agent_id">(int) Filters by the specified agent.</param>
    public int? AgentId { get; set; }
    /// <param name="alerttype">(string) Includes fninjaalertid field in the response - 'ninjarmm' to use.</param>
    public string? AlertType { get; set; }
    /// <param name="asset_id">(int) Filters by the specified asset.</param>
    public int? AssetId { get; set; }
    /// <param name="billing_date">(string) Filter on billing date.</param>
    public string? BillingDate { get; set; }
    /// <param name="billing_type">(string) Filter on billing type.</param>
    public string? BillingType { get; set; }
    
    /// <param name="calendar_enddate">(string) Specifies the calendar search parameter in which actions will have occured before this date.</param>
    public string? CalendarEndDate { get; set; }
    /// <param name="calendar_startdate">(string) Specifies the calendar search parameter in which actions will have occured after this date.</param>
    public string? CalendarStartDate { get; set; }
    /// <param name="category_1">(array of int) Returns tickets based on category 1 ID's in the array.</param>
    public int[]? Category1 { get; set; }
    /// <param name="category_2">(array of int) Returns tickets based on category 2 ID's in the array.</param>
    public int[]? Category2 { get; set; }
    /// <param name="category_3">(array of int) Returns tickets based on category 3 ID's in the array.</param>
    public int[]? Category3 { get; set; }
    /// <param name="category_4">(array of int) Returns tickets based on category 4 ID's in the array.</param>
    public int[]? Category4 { get; set; }
    /// <param name="client_id">(int) Filters by the specified client.</param>
    public int? ClientId { get; set; }
    /// <param name="client_ids">(array of int) Returns tickets based on client ID's in the array.</param>
    public int[]? ClientIds { get; set; }
    
    /// <param name="closed_only">(bool) Returns only closed tickets in the response.</param>
    public bool? ClosedOnly { get; set; }
    /// <param name="columns_id">(int) The column profile ID.</param>
    public int? ColumnsId { get; set; }
    /// <param name="contract_id">(int) Filters by the specified contract.</param>
    public int? ContractId { get; set; }
    /// <param name="contract_period">(int) Filters by the specified contract period.</param>
    public int? ContractPeriod { get; set; }
    /// <param name="count">(int) Number of Tickets to return in the response.</param>
    public int? Count { get; set; }
    /// <param name="datesearch">(string) The date field to search against. Examples: Date Opened - 'dateoccured', Date Closed - 'datecleared'.</param>
    public string? DateSearch { get; set; }
    
    /// <param name="default_columns">(bool) Include only the default columns in the response.</param>
    public bool? DefaultColumns { get; set; }
    
    /// <param name="domain">(string) Filter on tickets areas - 'reqs' = (not projects not oppportunities) or (projects not opportunities) - 'opps' = opportunities - 'prjs' = projects.</param>
    public string? Domain { get; set; }
    /// <param name="enddate">(string) For use with the datesearch parameter.</param>
    public string? EndDate { get; set; }
    /// <param name="enddatetime">(bool) Include project end date and time details in the response.</param>
    public bool? EndDateTime { get; set; }
    /// <param name="excludeslacalcs">(bool) Exclude sla calculation details in the response.</param>
    public bool? ExcludeSlAcalcs { get; set; }

    /// <param name="excludethese">(array of int) Returns tickets based on the exclusion of these fault ID's in the array.</param>
    public int[]? ExcludeThese { get; set; }

    /// <param name="excludetickettypeallowall">(bool) Exclude ticket type allow all details in the response.</param>
    public bool? ExcludeTicketTypeAllowAll { get; set; }

    /// <param name="extraportalfilter">(string) Filter on the extraportalfilter field - 'MyTicketsOnly' for my tickets - 'MyClientTickets' for my client tickets.</param>
    public string? ExtraPortalFilter { get; set; }

    /// <param name="facebook_id">(string) Filters by the specified facebook ID.</param>
    public string? FacebookId { get; set; }
    
    /// <param name="flagged">(array of int) Returns tickets based on flagged ticket ID's in the array.</param>
    public int[]? Flagged { get; set; }

    /// <param name="followedandagents">(array of int) Returns tickets based on agent and follower ID's in the array.</param>
    public int[]? FollowedAndAgents { get; set; }
    
    /// <param name="includeaccountmanager">(bool) Include account manager details in the response.</param>
    public bool? IncludeAccountManager { get; set; }

    /// <param name="includeagent">(bool) Include agent details in the response.</param>
    public bool? IncludeAgent { get; set; }
    
    /// <param name="includeappointmentid">(bool) Include appointment ID in the response.</param>
    public bool? IncludeAppointmentId { get; set; }

    /// <param name="includeapproval">(array of int) Filter on approval tickets in the array. 1 = approval - 0 = not approval</param>
    public int[]? IncludeApproval { get; set; }

    /// <param name="includeassetkeyfield">(bool) Include asset key field in the response.</param>
    public bool? IncludeAssetKeyField { get; set; }

    /// <param name="includeassettype">(bool) Include asset type details in the response.</param>
    public bool? IncludeAssetType { get; set; }

    /// <param name="includebreached">(array of int) Returns tickets based on breached ticket ID's in the array.</param>
    public int[]? IncludeBreached { get; set; }

    /// <param name="includebudgettype">(bool) Include budget type details in the response.</param>
    public bool? IncludeBudgetType { get; set; }

    /// <param name="includechildids">(bool) Include child ticket IDs in the response.</param>
    public bool? IncludeChildIds { get; set; }

    /// <param name="includechildread">(bool) Include child tickets that have been read details in the response.</param>
    public bool? IncludeChildRead { get; set; }

    /// <param name="includechildren">(array of int) Filter on child tickets in the array. 0 = No children and not a child - 1 = Has children - 2 = is a child</param>
    public int[]? IncludeChildren { get; set; }

    /// <param name="includeclosed">(array of int) Filter on closed in the array - 1 = Closed - 0 = Not Closed.</param>
    public int[]? IncludeClosed { get; set; }

    /// <param name="includecolumns">(bool) Include column details in the response.</param>
    public bool? IncludeColumns { get; set; }
    
    /// <param name="includecontract">(bool) Include contract details in the response.</param>
    public bool? IncludeContract { get; set; }
    
    /// <param name="includefirstname">(bool) Include first name of user details in the response.</param>
    public bool? IncludeFirstName { get; set; }

    /// <param name="includefollowedonly">(array of int) Returns tickets based on follower ID's in the array.</param>
    public int[]? IncludeFollowedOnly { get; set; }

    /// <param name="includehold">(array of int) Returns tickets based on on-hold ticket ID's in the array.</param>
    public int[]? IncludeHold { get; set; }

    /// <param name="includeinactivetechs">(array of int) Returns tickets based on inactive tech ID's in the array.</param>
    public int[]? IncludeInactiveTechs { get; set; }

    /// <param name="includeinactiveusers">(array of int) Filter on inactive users in the array - 1 = inactive - 0 = active.</param>
    public int[]? IncludeInactiveUsers { get; set; }

    /// <param name="includeitilname">(bool) Include ITIL name details in the response.</param>
    public bool? IncludeItilName { get; set; }

    /// <param name="includelastaction">(bool) Include the last action in the response (Note: only returned if one ticket result is returned).</param>
    public bool? IncludeLastAction { get; set; }

    /// <param name="includelastincomingemail">(bool) Include last incoming email details in the response.</param>
    public bool? IncludeLastIncomingEmail { get; set; }

    /// <param name="includelastname">(bool) Include last name of user details in the response.</param>
    public bool? IncludeLastName { get; set; }

    /// <param name="includelastnote">(bool) Include last note details in the response.</param>
    public bool? IncludeLastNote { get; set; }

    /// <param name="includemailbox">(bool) Include email box details in the response.</param>
    public bool? IncludeMailbox { get; set; }

    /// <param name="includemyuseronly">(array of int) Returns tickets based on my user ID in the array.</param>
    public int[]? IncludeMyUserOnly { get; set; }

    /// <param name="includenextactivitydate">(bool) Include nextactivitydate in the response.</param>
    public bool? IncludeNextActivityDate { get; set; }

    /// <param name="includenextappointmenttype">(bool) Include next appointment type details in the response.</param>
    public bool? IncludeNextAppointmentType { get; set; }

    /// <param name="includeprojects">(array of int) Filter on projects in the array - 1 = Opportunities not Projects - 2 = Projects not Opportunities - 0 = Neither.</param>
    public int[]? IncludeProjects { get; set; }

    /// <param name="includeread">(array of int) Returns tickets based on read ticket ID's in the array.</param>
    public int[]? IncludeRead { get; set; }

    /// <param name="includerelatedservices">(bool) Include related services in the response.</param>
    public bool? IncludeRelatedServices { get; set; }

    /// <param name="includerelease1">(bool) Include release 1 details in the response.</param>
    public bool? IncludeRelease1 { get; set; }

    /// <param name="includerelease2">(bool) Include release 2 details in the response.</param>
    public bool? IncludeRelease2 { get; set; }

    /// <param name="includerelease3">(bool) Include release 3 details in the response.</param>
    public bool? IncludeRelease3 { get; set; }

    /// <param name="includeservicecategory">(bool) Include service category in the response.</param>
    public bool? IncludeServiceCategory { get; set; }

    /// <param name="includeslaactiondate">(bool) Include the SLA action date in the response.</param>
    public bool? IncludeSlaActionDate { get; set; }

    /// <param name="includeslatimer">(bool) Include SLA timer in the response.</param>
    public bool? IncludeSlaTimer { get; set; }

    /// <param name="includestatus">(bool) Include status details in the response.</param>
    public bool? IncludeStatus { get; set; }

    /// <param name="includesubmittedonly">(array of int) Returns tickets based on agent submitted ID's in the array.</param>
    public int[]? IncludeSubmittedOnly { get; set; }

    /// <param name="includesupplier">(bool) Include supplier details in the response.</param>
    public bool? IncludeSupplier { get; set; }

    /// <param name="includetickettype">(bool) Include ticket type details in the response.</param>
    public bool? IncludeTicketType { get; set; }

    /// <param name="includetimetaken">(bool) Include time taken in the response.</param>
    public bool? IncludeTimeTaken { get; set; }

    /// <param name="includetoplevel">(bool) Include top level details in the response.</param>
    public bool? IncludeTopLevel { get; set; }

    /// <param name="includeviewing">(bool) Include tickets currently being viewed details in the response.</param>
    public bool? IncludeViewing { get; set; }

    /// <param name="includeworkflowstage">(bool) Include workflow stage details in the response.</param>
    public bool? IncludeWorkflowStage { get; set; }

    /// <param name="includeworkflowstagenumber">(bool) Include workflow stage number in the response.</param>
    public bool? IncludeWorkflowStageNumber { get; set; }

    /// <param name="inlcludeopenchildcount">(bool) Include open child ticket count in the response.</param>
    public bool? IncludeOpenChildCount { get; set; }

    /// <param name="isorion">(bool) Include integration orion details in the response.</param>
    public bool? IsOrion { get; set; }

    /// <param name="isquicktimesearch">(bool) Returns only quick time tickets in the response.</param>
    public bool? IsQuickTimeSearch { get; set; }

    /// <param name="isscom">(bool) Include integration scom details in the response.</param>
    public bool? IsScom { get; set; }

    /// <param name="isteams">(bool) Returns only teams tickets in the response.</param>
    public bool? IsTeams { get; set; }

    /// <param name="iszapier">(bool) Returns a single ticket based on permissions in the response.</param>
    public bool? IsZapier { get; set; }

    /// <param name="itil_requesttype">(array of int) Returns tickets based on ITIL request type ID's in the array.</param>
    public int[]? ItilRequestType { get; set; }

    /// <param name="itil_requesttype_id">(int) Filters by the specified ITIL ticket type.</param>
    public int? ItilRequestTypeId { get; set; }

    /// <param name="kanbanviewontheagentapp">(bool) Include agent app kanban view in the response.</param>
    public bool? KanbanViewOnTheAgentApp { get; set; }

    /// <param name="kanbanviewontheportal">(bool) Include portal kanban view in the response.</param>
    public bool? KanbanViewOnThePortal { get; set; }

    /// <param name="list_id">(int) Filters by the specified list.</param>
    public int? ListId { get; set; }

    /// <param name="mine">(bool) Include only the tickets that belong to yourself in the response.</param>
    public bool? Mine { get; set; }

    /// <param name="open_only">(bool) Returns only open tickets in the response.</param>
    public bool? OpenOnly { get; set; }

    /// <param name="order">(string) The name of the field to order by first.</param>
    public string? Order { get; set; }

    /// <param name="order2">(string) The name of the field to order by second.</param>
    public string? Order2 { get; set; }

    /// <param name="order3">(string) The name of the field to order by third.</param>
    public string? Order3 { get; set; }

    /// <param name="order4">(string) The name of the field to order by fourth.</param>
    public string? Order4 { get; set; }

    /// <param name="order5">(string) The name of the field to order by fifth.</param>
    public string? Order5 { get; set; }

    /// <param name="orderdesc">(bool) Whether to order ascending or descending on first order.</param>
    public bool? OrderDesc { get; set; }

    /// <param name="orderdesc2">(bool) Whether to order ascending or descending on second order.</param>
    public bool? OrderDesc2 { get; set; }

    /// <param name="orderdesc3">(bool) Whether to order ascending or descending on third order.</param>
    public bool? OrderDesc3 { get; set; }

    /// <param name="orderdesc4">(bool) Whether to order ascending or descending on fourth order.</param>
    public bool? OrderDesc4 { get; set; }

    /// <param name="orderdesc5">(bool) Whether to order ascending or descending on fifth order.</param>
    public bool? OrderDesc5 { get; set; }

    /// <param name="orion_type">(bool) Filters by the orion type.</param>
    public bool? OrionType { get; set; }

    /// <param name="page_no">(int) When using Pagination, the page number to return.</param>
    public int? PageNo { get; set; }

    /// <param name="page_size">(int) When using Pagination, the size of the page. Maximum size: 100</param>
    public int? PageSize { get; set; }

    /// <param name="pageinate">(bool) Whether to use Pagination in the response.</param>
    public bool? Paginate { get; set; }

    /// <param name="parent_id">(int) Filters by the specified parent.</param>
    public int? ParentId { get; set; }

    /// <param name="pending_review">(bool) Filter on pending review.</param>
    public bool? PendingReview { get; set; }

    /// <param name="per_action">(bool) Whether to calculate billing per action.</param>
    public bool? PerAction { get; set; }

    /// <param name="priority">(array of int) Returns tickets based on priority ID's in the array.</param>
    public int[]? Priority { get; set; }

    /// <param name="product">(array of int) Returns tickets based on product ID's in the array.</param>
    public int[]? Product { get; set; }

    /// <param name="ready_for_invoicing">(bool) Filter on ready for invoicing.</param>
    public bool? ReadyForInvoicing { get; set; }

    /// <param name="related_id">(int) Filters by the specified related ticket.</param>
    public int? RelatedId { get; set; }

    /// <param name="release_id">(int) Filters by the specified release.</param>
    public int? ReleaseId { get; set; }

    /// <param name="requesttype">(array of int) Returns tickets based on request type ID's in the array.</param>
    public int[]? RequestType { get; set; }

    /// <param name="requesttype_id">(int) Filters by the specified request type.</param>
    public int? RequestTypeId { get; set; }

    /// <param name="requesttypegroup">(array of int) Returns tickets based on request type group ID's in the array.</param>
    public int[]? RequestTypeGroup { get; set; }

    /// <param name="search">(string) Filters response based on the search string.</param>
    public string? Search { get; set; }

    /// <param name="search_details">(string) Returns tickets based on the details matching the search.</param>
    public string? SearchDetails { get; set; }

    /// <param name="search_id">(string) Returns tickets based on ids matching the search.</param>
    public string? SearchId { get; set; }

    /// <param name="search_inventory_number">(string) Returns tickets based on an asset tag matching the search.</param>
    public string? SearchInventoryNumber { get; set; }

    /// <param name="search_oppcompanyname">(string) Returns tickets based on the opportunity company name matching the search.</param>
    public string? SearchOppCompanyName { get; set; }

    /// <param name="search_oppcontactname">(string) Returns tickets based on the opportunity contact name matching the search.</param>
    public string? SearchOppContactName { get; set; }

    /// <param name="search_oppemailaddress">(string) Returns tickets based on the opportunity email addresss matching the search.</param>
    public string? SearchOppEmailAddress { get; set; }

    /// <param name="search_release1">(string) Returns tickets based on release 1 matching the search.</param>
    public string? SearchRelease1 { get; set; }

    /// <param name="search_release2">(string) Returns tickets based on release 2 matching the search.</param>
    public string? SearchRelease2 { get; set; }

    /// <param name="search_release3">(string) Returns tickets based on release 3 matching the search.</param>
    public string? SearchRelease3 { get; set; }

    /// <param name="search_releasenote">(string) Returns tickets based on the release note matching the search.</param>
    public string? SearchReleaseNote { get; set; }

    /// <param name="search_reportedby">(string) Returns tickets based on the reportedby field matching the search.</param>
    public string? SearchReportedBy { get; set; }

    /// <param name="search_summary">(string) Returns tickets based on the summary matching the search.</param>
    public string? SearchSummary { get; set; }

    /// <param name="search_supplier_reference">(string) Returns tickets based on the supplier reference matching the search.</param>
    public string? SearchSupplierReference { get; set; }

    /// <param name="search_user_name">(string) Returns tickets based on users matching the search.</param>
    public string? SearchUserName { get; set; }

    /// <param name="search_version">(string) Returns tickets based on the software version matching the search.</param>
    public string? SearchVersion { get; set; }

    /// <param name="searchactions">(bool) Whether to search actions when using search.</param>
    public bool? SearchActions { get; set; }

    /// <param name="searchthisticketid">(int) Filters by the specified ticket.</param>
    public int? SearchThisTicketId { get; set; }

    /// <param name="service_id">(int) Filters by the specified service.</param>
    public int? ServiceId { get; set; }

    /// <param name="showonroadmap">(array of int) Filter on roadmap visibility in the array - 1 = visible - 0 = Not visible.</param>
    public int[]? ShowOnRoadmap { get; set; }

    /// <param name="site_id">(int) Filters by the specified site.</param>
    public int? SiteId { get; set; }

    /// <param name="sitepostcode">(bool) Include site postcode details in the response.</param>
    public bool? SitePostcode { get; set; }

    /// <param name="sla">(array of int) Returns tickets based on SLA ID's in the array.</param>
    public string? Sla { get; set; }

    /// <param name="sprints">(bool) Returns only sprint tickets in the response.</param>
    public bool? Sprints { get; set; }

    /// <param name="startandendset">(bool) Filter on tickets that have a project start and end date set.</param>
    public bool? StartAndEndSet { get; set; }

    /// <param name="startdate">(string) For use with the datesearch parameter.</param>
    public string? StartDate { get; set; }

    /// <param name="startdatetime">(bool) Include project start date and time details in the response.</param>
    public bool? StartDateTime { get; set; }

    /// <param name="status">(array of int) Returns tickets based on Status ID's in the array.</param>
    public int[]? Status { get; set; }

    /// <param name="status_id">(int) Filters by the specified status.</param>
    public int? StatusId { get; set; }

    /// <param name="submittedandagents">(array of int) Returns tickets based on agent and agent submitted ID's in the array.</param>
    public int[]? SubmittedAndAgents { get; set; }

    /// <param name="supplier_id">(int) Filters by the specified supplier.</param>
    public int? SupplierId { get; set; }

    /// <param name="supplier_status">(array of int) Returns tickets based on supplier status ID's in the array.</param>
    public int[]? SupplierStatus { get; set; }

    /// <param name="team">(array of int) Returns tickets based on Team ID's in the array.</param>
    public int[]? Team { get; set; }

    /// <param name="team_name">(string) Include team name details in the response.</param>
    public string? TeamName { get; set; }

    /// <param name="ticketarea_id">(int) Will return tickets in this ticket area in the response.</param>
    public int? TicketAreaId { get; set; }

    /// <param name="ticketcontract_id">(int) Filters by the specified ticket contract.</param>
    public int? TicketContractId { get; set; }

    /// <param name="ticketidonly">(bool) Returns only the ID fields (Ticket ID, SLA ID, Status ID, Client ID and Name and LastIncomingEmail date) of the Tickets (Not compatible with Pagination).</param>
    public bool? TicketIdOnly { get; set; }

    /// <param name="ticketids">(string) Returns only the tickets specified in the response.</param>
    public string? TicketIds { get; set; }

    /// <param name="toplevel_id">(int) Filters by the specified top level.</param>
    public int? TopLevelId { get; set; }

    /// <param name="unlinked_only">(bool) Returns only unlinked tickets in the response.</param>
    public bool? UnlinkedOnly { get; set; }

    /// <param name="user_id">(int) Filters by the specified user.</param>
    public int? UserId { get; set; }

    /// <param name="username">(string) Filters by the specified username.</param>
    public string? UserName { get; set; }

    /// <param name="utcoffsetQuery">(double) Adds an offset to the UTC date.</param>
    public double? UtcOffsetQuery { get; set; }

    /// <param name="view_id">(int) The ID of the filter profile to filter by.</param>
    public int? ViewId { get; set; }

    /// <param name="withattachments">(bool) Returns only tickets with 1 or more attachment.</param>
    public bool? WithAttachments { get; set; }

    // Poor undocumented parameters!
    /// <param name="advanced_search">
    /// Advanced search queries.
    /// </param>
    public string? AdvancedSearch { get; set; }
    
    /// <param name="awaitinginput"></param>
    public string? AwaitingInput { get; set; }
    
    /// <param name="billableonly">
    /// 
    /// </param>
    public bool? BillableOnly { get; set; }
    
    /// <param name="billingcontractid">
    /// 
    /// </param>
    public int? BillingContractId { get; set; }
    
    /// <param name="checkmyticketsonly">
    /// 
    /// </param>
    public bool? CheckMyTicketsOnly { get; set; }
    /// <param name="client_ref">
    /// 
    /// </param>
    public string? ClientRef { get; set; }
    /// <param name="debug">
    /// Include debug information in the response.
    /// </param>
    public bool? Debug { get; set; }
    /// <param name="deleted">
    /// 
    /// </param>
    public bool? Deleted { get; set; }
    /// <param name="fetchgrqndchildren">
    /// 
    /// </param>
    public bool? FetchGrandChildren { get; set; }
    /// <param name="ignoremilestonerestriction">
    /// 
    /// </param>
    public bool? IgnoreMilestoneRestriction { get; set; }
    /// <param name="includeallopen">
    /// 
    /// </param>
    public bool? IncludeAllOpen { get; set; }
    /// <param name="includecompleted">
    /// 
    /// </param>
    public bool? IncludeCompleted { get; set; }
    /// <param name="includecountryregion">
    /// 
    /// </param>
    public bool? IncludeCountryRegion { get; set; }
    /// <param name="includelocked">
    /// 
    /// </param>
    public bool? IncludeLocked { get; set; }
    /// <param name="includemailid">
    /// 
    /// </param>
    public bool? IncludeMailId { get; set; }
    /// <param name="includeparentsubject">
    /// 
    /// </param>
    public bool? IncludeParentSubject { get; set; }
    /// <param name="includeusersubjects">
    /// 
    /// </param>
    public bool? IncludeUserDepartments { get; set; }
    /// <param name="includebranch">
    /// 
    /// </param>
    [JsonProperty("invlucebranch")]
    public bool? IncludeBranch { get; set; }
    /// <param name="ismilestone">
    /// 
    /// </param>
    public bool? IsMilestone { get; set; }
    /// <param name="milestoneid">
    /// 
    /// </param>
    public int? MilestoneId { get; set; }
    /// <param name="nochargeonly">
    /// 
    /// </param>
    public bool? NoChargeOnly { get; set; }
    /// <param name="notime">
    /// 
    /// </param>
    public bool? NoTime { get; set; }
    /// <param name="onlytime">
    /// 
    /// </param>
    public bool? OnlyTime { get; set; }
    /// <param name="projectids">
    /// 
    /// </param>
    public string? ProjectIds { get; set; }
    /// <param name="sprintforticketypeid">
    /// 
    /// </param>
    public int? SprintForTicketTypeId { get; set; }
    /// <param name="ticketlinktype">
    /// 
    /// </param>
    public int? TicketLinkType { get; set; }
}
