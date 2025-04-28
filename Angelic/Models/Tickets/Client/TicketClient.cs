namespace Angelic.Models.Tickets.Client;

public class TicketClient
{
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// List of Faults
        /// </summary>
        /// <remarks>
        /// Use this to return multiple Faults.&lt;br&gt;
        /// <br/>				Requires authentication.
        /// </remarks>
        /// <param name="agent">(array of int) Returns tickets based on Agent ID's in the array.</param>
        /// <param name="agent_id">(int) Filters by the specified agent.</param>
        /// <param name="alerttype">(string) Includes fninjaalertid field in the response - 'ninjarmm' to use.</param>
        /// <param name="asset_id">(int) Filters by the specified asset.</param>
        /// <param name="billing_date">(string) Filter on billing date.</param>
        /// <param name="billing_type">(string) Filter on billing type.</param>
        /// <param name="calendar_enddate">(string) Specifies the calendar search parameter in which actions will have occured before this date.</param>
        /// <param name="calendar_startdate">(string) Specifies the calendar search parameter in which actions will have occured after this date.</param>
        /// <param name="category_1">(array of int) Returns tickets based on category 1 ID's in the array.</param>
        /// <param name="category_2">(array of int) Returns tickets based on category 2 ID's in the array.</param>
        /// <param name="category_3">(array of int) Returns tickets based on category 3 ID's in the array.</param>
        /// <param name="category_4">(array of int) Returns tickets based on category 4 ID's in the array.</param>
        /// <param name="client_id">(int) Filters by the specified client.</param>
        /// <param name="client_ids">(array of int) Returns tickets based on client ID's in the array.</param>
        /// <param name="closed_only">(bool) Returns only closed tickets in the response.</param>
        /// <param name="columns_id">(int) The column profile ID.</param>
        /// <param name="contract_id">(int) Filters by the specified contract.</param>
        /// <param name="contract_period">(int) Filters by the specified contract period.</param>
        /// <param name="count">(int) Number of Tickets to return in the response.</param>
        /// <param name="datesearch">(string) The date field to search against. Examples: Date Opened - 'dateoccured', Date Closed - 'datecleared'.</param>
        /// <param name="default_columns">(bool) Include only the default columns in the response.</param>
        /// <param name="domain">(string) Filter on tickets areas - 'reqs' = (not projects not oppportunities) or (projects not opportunities) - 'opps' = opportunities - 'prjs' = projects.</param>
        /// <param name="enddate">(string) For use with the datesearch parameter.</param>
        /// <param name="enddatetime">(bool) Include project end date and time details in the response.</param>
        /// <param name="excludeslacalcs">(bool) Exclude sla calculation details in the response.</param>
        /// <param name="excludethese">(array of int) Returns tickets based on the exclusion of these fault ID's in the array.</param>
        /// <param name="excludetickettypeallowall">(bool) Exclude ticket type allow all details in the response.</param>
        /// <param name="extraportalfilter">(string) Filter on the extraportalfilter field - 'MyTicketsOnly' for my tickets - 'MyClientTickets' for my client tickets.</param>
        /// <param name="facebook_id">(string) Filters by the specified facebook ID.</param>
        /// <param name="flagged">(array of int) Returns tickets based on flagged ticket ID's in the array.</param>
        /// <param name="followedandagents">(array of int) Returns tickets based on agent and follower ID's in the array.</param>
        /// <param name="includeaccountmanager">(bool) Include account manager details in the response.</param>
        /// <param name="includeagent">(bool) Include agent details in the response.</param>
        /// <param name="includeappointmentid">(bool) Include appointment ID in the response.</param>
        /// <param name="includeapproval">(array of int) Filter on approval tickets in the array. 1 = approval - 0 = not approval</param>
        /// <param name="includeassetkeyfield">(bool) Include asset key field in the response.</param>
        /// <param name="includeassettype">(bool) Include asset type details in the response.</param>
        /// <param name="includebreached">(array of int) Returns tickets based on breached ticket ID's in the array.</param>
        /// <param name="includebudgettype">(bool) Include budget type details in the response.</param>
        /// <param name="includechildids">(bool) Include child ticket IDs in the response.</param>
        /// <param name="includechildread">(bool) Include child tickets that have been read details in the response.</param>
        /// <param name="includechildren">(array of int) Filter on child tickets in the array. 0 = No children and not a child - 1 = Has children - 2 = is a child</param>
        /// <param name="includeclosed">(array of int) Filter on closed in the array - 1 = Closed - 0 = Not Closed.</param>
        /// <param name="includecolumns">(bool) Include column details in the response.</param>
        /// <param name="includecontract">(bool) Include contract details in the response.</param>
        /// <param name="includefirstname">(bool) Include first name of user details in the response.</param>
        /// <param name="includefollowedonly">(array of int) Returns tickets based on follower ID's in the array.</param>
        /// <param name="includehold">(array of int) Returns tickets based on on-hold ticket ID's in the array.</param>
        /// <param name="includeinactivetechs">(array of int) Returns tickets based on inactive tech ID's in the array.</param>
        /// <param name="includeinactiveusers">(array of int) Filter on inactive users in the array - 1 = inactive - 0 = active.</param>
        /// <param name="includeitilname">(bool) Include ITIL name details in the response.</param>
        /// <param name="includelastaction">(bool) Include the last action in the response (Note: only returned if one ticket result is returned).</param>
        /// <param name="includelastincomingemail">(bool) Include last incoming email details in the response.</param>
        /// <param name="includelastname">(bool) Include last name of user details in the response.</param>
        /// <param name="includelastnote">(bool) Include last note details in the response.</param>
        /// <param name="includemailbox">(bool) Include email box details in the response.</param>
        /// <param name="includemyuseronly">(array of int) Returns tickets based on my user ID in the array.</param>
        /// <param name="includenextactivitydate">(bool) Include nextactivitydate in the response.</param>
        /// <param name="includenextappointmenttype">(bool) Include next appointment type details in the response.</param>
        /// <param name="includeprojects">(array of int) Filter on projects in the array - 1 = Opportunities not Projects - 2 = Projects not Opportunities - 0 = Neither.</param>
        /// <param name="includeread">(array of int) Returns tickets based on read ticket ID's in the array.</param>
        /// <param name="includerelatedservices">(bool) Include related services in the response.</param>
        /// <param name="includerelease1">(bool) Include release 1 details in the response.</param>
        /// <param name="includerelease2">(bool) Include release 2 details in the response.</param>
        /// <param name="includerelease3">(bool) Include release 3 details in the response.</param>
        /// <param name="includeservicecategory">(bool) Include service category in the response.</param>
        /// <param name="includeslaactiondate">(bool) Include the SLA action date in the response.</param>
        /// <param name="includeslatimer">(bool) Include SLA timer in the response.</param>
        /// <param name="includestatus">(bool) Include status details in the response.</param>
        /// <param name="includesubmittedonly">(array of int) Returns tickets based on agent submitted ID's in the array.</param>
        /// <param name="includesupplier">(bool) Include supplier details in the response.</param>
        /// <param name="includetickettype">(bool) Include ticket type details in the response.</param>
        /// <param name="includetimetaken">(bool) Include time taken in the response.</param>
        /// <param name="includetoplevel">(bool) Include top level details in the response.</param>
        /// <param name="includeviewing">(bool) Include tickets currently being viewed details in the response.</param>
        /// <param name="includeworkflowstage">(bool) Include workflow stage details in the response.</param>
        /// <param name="includeworkflowstagenumber">(bool) Include workflow stage number in the response.</param>
        /// <param name="inlcludeopenchildcount">(bool) Include open child ticket count in the response.</param>
        /// <param name="isorion">(bool) Include integration orion details in the response.</param>
        /// <param name="isquicktimesearch">(bool) Returns only quick time tickets in the response.</param>
        /// <param name="isscom">(bool) Include integration scom details in the response.</param>
        /// <param name="isteams">(bool) Returns only teams tickets in the response.</param>
        /// <param name="iszapier">(bool) Returns a single ticket based on permissions in the response.</param>
        /// <param name="itil_requesttype">(array of int) Returns tickets based on ITIL request type ID's in the array.</param>
        /// <param name="itil_requesttype_id">(int) Filters by the specified ITIL ticket type.</param>
        /// <param name="kanbanviewontheagentapp">(bool) Include agent app kanban view in the response.</param>
        /// <param name="kanbanviewontheportal">(bool) Include portal kanban view in the response.</param>
        /// <param name="list_id">(int) Filters by the specified list.</param>
        /// <param name="mine">(bool) Include only the tickets that belong to yourself in the response.</param>
        /// <param name="open_only">(bool) Returns only open tickets in the response.</param>
        /// <param name="order">(string) The name of the field to order by first.</param>
        /// <param name="order2">(string) The name of the field to order by second.</param>
        /// <param name="order3">(string) The name of the field to order by third.</param>
        /// <param name="order4">(string) The name of the field to order by fourth.</param>
        /// <param name="order5">(string) The name of the field to order by fifth.</param>
        /// <param name="orderdesc">(bool) Whether to order ascending or descending on first order.</param>
        /// <param name="orderdesc2">(bool) Whether to order ascending or descending on second order.</param>
        /// <param name="orderdesc3">(bool) Whether to order ascending or descending on third order.</param>
        /// <param name="orderdesc4">(bool) Whether to order ascending or descending on fourth order.</param>
        /// <param name="orderdesc5">(bool) Whether to order ascending or descending on fifth order.</param>
        /// <param name="orion_type">(bool) Filters by the orion type.</param>
        /// <param name="page_no">(int) When using Pagination, the page number to return.</param>
        /// <param name="page_size">(int) When using Pagination, the size of the page. Maximum size: 100</param>
        /// <param name="pageinate">(bool) Whether to use Pagination in the response.</param>
        /// <param name="parent_id">(int) Filters by the specified parent.</param>
        /// <param name="pending_review">(bool) Filter on pending review.</param>
        /// <param name="per_action">(bool) Whether to calculate billing per action.</param>
        /// <param name="priority">(array of int) Returns tickets based on priority ID's in the array.</param>
        /// <param name="product">(array of int) Returns tickets based on product ID's in the array.</param>
        /// <param name="ready_for_invoicing">(bool) Filter on ready for invoicing.</param>
        /// <param name="related_id">(int) Filters by the specified related ticket.</param>
        /// <param name="release_id">(int) Filters by the specified release.</param>
        /// <param name="requesttype">(array of int) Returns tickets based on request type ID's in the array.</param>
        /// <param name="requesttype_id">(int) Filters by the specified request type.</param>
        /// <param name="requesttypegroup">(array of int) Returns tickets based on request type group ID's in the array.</param>
        /// <param name="search">(string) Filters response based on the search string.</param>
        /// <param name="search_details">(string) Returns tickets based on the details matching the search.</param>
        /// <param name="search_id">(string) Returns tickets based on ids matching the search.</param>
        /// <param name="search_inventory_number">(string) Returns tickets based on an asset tag matching the search.</param>
        /// <param name="search_oppcompanyname">(string) Returns tickets based on the opportunity company name matching the search.</param>
        /// <param name="search_oppcontactname">(string) Returns tickets based on the opportunity contact name matching the search.</param>
        /// <param name="search_oppemailaddress">(string) Returns tickets based on the opportunity email addresss matching the search.</param>
        /// <param name="search_release1">(string) Returns tickets based on release 1 matching the search.</param>
        /// <param name="search_release2">(string) Returns tickets based on release 2 matching the search.</param>
        /// <param name="search_release3">(string) Returns tickets based on release 3 matching the search.</param>
        /// <param name="search_releasenote">(string) Returns tickets based on the release note matching the search.</param>
        /// <param name="search_reportedby">(string) Returns tickets based on the reportedby field matching the search.</param>
        /// <param name="search_summary">(string) Returns tickets based on the summary matching the search.</param>
        /// <param name="search_supplier_reference">(string) Returns tickets based on the supplier reference matching the search.</param>
        /// <param name="search_user_name">(string) Returns tickets based on users matching the search.</param>
        /// <param name="search_version">(string) Returns tickets based on the software version matching the search.</param>
        /// <param name="searchactions">(bool) Whether to search actions when using search.</param>
        /// <param name="searchthisticketid">(int) Filters by the specified ticket.</param>
        /// <param name="service_id">(int) Filters by the specified service.</param>
        /// <param name="showonroadmap">(array of int) Filter on roadmap visibility in the array - 1 = visible - 0 = Not visible.</param>
        /// <param name="site_id">(int) Filters by the specified site.</param>
        /// <param name="sitepostcode">(bool) Include site postcode details in the response.</param>
        /// <param name="sla">(array of int) Returns tickets based on SLA ID's in the array.</param>
        /// <param name="sprints">(bool) Returns only sprint tickets in the response.</param>
        /// <param name="startandendset">(bool) Filter on tickets that have a project start and end date set.</param>
        /// <param name="startdate">(string) For use with the datesearch parameter.</param>
        /// <param name="startdatetime">(bool) Include project start date and time details in the response.</param>
        /// <param name="status">(array of int) Returns tickets based on Status ID's in the array.</param>
        /// <param name="status_id">(int) Filters by the specified status.</param>
        /// <param name="submittedandagents">(array of int) Returns tickets based on agent and agent submitted ID's in the array.</param>
        /// <param name="supplier_id">(int) Filters by the specified supplier.</param>
        /// <param name="supplier_status">(array of int) Returns tickets based on supplier status ID's in the array.</param>
        /// <param name="team">(array of int) Returns tickets based on Team ID's in the array.</param>
        /// <param name="team_name">(string) Include team name details in the response.</param>
        /// <param name="ticketarea_id">(int) Will return tickets in this ticket area in the response.</param>
        /// <param name="ticketcontract_id">(int) Filters by the specified ticket contract.</param>
        /// <param name="ticketidonly">(bool) Returns only the ID fields (Ticket ID, SLA ID, Status ID, Client ID and Name and Lastincomingemail date) of the Tickets (Not compatible with Pagination).</param>
        /// <param name="ticketids">(string) Returns only the tickets specified in the response.</param>
        /// <param name="toplevel_id">(int) Filters by the specified top level.</param>
        /// <param name="unlinked_only">(bool) Returns only unlinked tickets in the response.</param>
        /// <param name="user_id">(int) Filters by the specified user.</param>
        /// <param name="username">(string) Filters by the specified username.</param>
        /// <param name="utcoffsetQuery">(double) Adds an offset to the UTC date.</param>
        /// <param name="view_id">(int) The ID of the filter profile to filter by.</param>
        /// <param name="withattachments">(bool) Returns only tickets with 1 or more attachment.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task TicketsGETAsync(
        string? advanced_search, string? agent, object? agent_id, string? alerttype, object? asset_id,
        string? awaitinginput, object? billableonly, string? billing_date, string? billing_type,
        object? billingcontractid, string? calendar_enddate, string? calendar_startdate, string? category_1,
        string? category_2, string? category_3, string? category_4, object? checkmyticketsonly, object? client_id,
        string? client_ids, string? client_ref, object? closed_only, object? columns_id, object? contract_id,
        object? contract_period, object? count, string? datesearch, object? debug, object? default_columns,
        object? deleted, string? domain, string? enddate, object? enddatetime, object? excludeslacalcs,
        string? excludethese, object? excludetickettypeallowall, string? extraportalfilter, string? facebook_id,
        object? fetchgrandchildren, string? flagged, string? followedandagents, object? ignoremilestonerestriction,
        object? includeaccountmanager, object? includeagent, object? includeallopen, object? includeappointmentid,
        string? includeapproval, object? includeassetkeyfield, object? includeassettype, string? includebreached,
        object? includebudgettype, object? includechildids, object? includechildread, string? includechildren,
        string? includeclosed, object? includecolumns, object? includecompleted, object? includecontract,
        object? includecountryregion, object? includefirstname, string? includefollowedonly, string? includehold,
        string? includeinactivetechs, string? includeinactiveusers, object? includeitilname, object? includelastaction,
        object? includelastincomingemail, object? includelastname, object? includelastnote, object? includelocked,
        object? includemailbox, object? includemailid, string? includemyuseronly, object? includenextactivitydate,
        object? includenextappointmenttype, object? includeparentsubject, string? includeprojects, string? includeread,
        object? includerelatedservices, object? includerelease1, object? includerelease2, object? includerelease3,
        object? includeservicecategory, object? includeslaactiondate, object? includeslatimer, object? includestatus,
        string? includesubmittedonly, object? includesupplier, object? includetickettype, object? includetimetaken,
        object? includetoplevel, object? includeviewing, object? includeworkflowstage,
        object? includeworkflowstagenumber, object? includuserdepartments, object? inlcludeopenchildcount,
        object? invlucebranch, object? ismilestone, object? isorion, object? isquicktimesearch, object? isscom,
        object? isteams, object? iszapier, string? itil_requesttype, object? itil_requesttype_id,
        object? kanbanviewontheagentapp, object? kanbanviewontheportal, object? lastupdatefromdate,
        object? lastupdatetodate, object? list_id, object? milestone_id, object? mine, object? nochargeonly,
        object? notime, object? onlytime, object? open_only, string? order, string? order2, string? order3,
        string? order4, string? order5, object? orderdesc, object? orderdesc2, object? orderdesc3, object? orderdesc4,
        object? orderdesc5, object? orion_type, object? page_no, object? page_size, object? pageinate,
        object? parent_id, object? pending_review, object? per_action, object? prepayorcontractonly, string? priority,
        string? product, string? project_ids, object? ready_for_invoicing, object? related_id, object? release_id,
        string? requesttype, object? requesttype_id, string? requesttypegroup, string? search, string? search_details,
        string? search_id, string? search_inventory_number, string? search_oppcompanyname,
        string? search_oppcontactname, string? search_oppemailaddress, string? search_release1, string? search_release2,
        string? search_release3, string? search_releasenote, string? search_reportedby, string? search_summary,
        string? search_supplier_reference, string? search_user_name, string? search_version, object? searchactions,
        object? searchthisticketid, object? service_id, string? showonroadmap, object? site_id, object? sitepostcode,
        string? sla, object? sprint_for_tickettype_id, object? sprints, object? startandendset, string? startdate,
        object? startdatetime, string? status, object? status_id, string? submittedandagents, object? supplier_id,
        string? supplier_status, string? team, string? team_name, object? ticketarea_id, object? ticketcontract_id,
        object? ticketidonly, string? ticketids, object? ticketlinktype, object? toplevel_id, object? unlinked_only,
        object? user_id, string? username, object? utcoffsetQuery, object? view_id, object? withattachments,
        System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");

                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "Tickets"
                    urlBuilder_.Append("Tickets");
                    urlBuilder_.Append('?');
                    if (advanced_search != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("advanced_search")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(advanced_search, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (agent != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("agent")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(agent, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (agent_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("agent_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(agent_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (alerttype != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("alerttype")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(alerttype, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (asset_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("asset_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(asset_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (awaitinginput != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("awaitinginput")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(awaitinginput, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (billableonly != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("billableonly")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(billableonly, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (billing_date != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("billing_date")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(billing_date, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (billing_type != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("billing_type")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(billing_type, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (billingcontractid != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("billingcontractid")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(billingcontractid, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (calendar_enddate != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("calendar_enddate")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(calendar_enddate, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (calendar_startdate != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("calendar_startdate")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(calendar_startdate, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (category_1 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("category_1")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(category_1, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (category_2 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("category_2")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(category_2, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (category_3 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("category_3")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(category_3, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (category_4 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("category_4")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(category_4, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (checkmyticketsonly != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("checkmyticketsonly")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(checkmyticketsonly, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (client_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("client_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(client_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (client_ids != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("client_ids")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(client_ids, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (client_ref != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("client_ref")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(client_ref, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (closed_only != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("closed_only")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(closed_only, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (columns_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("columns_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(columns_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (contract_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("contract_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(contract_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (contract_period != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("contract_period")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(contract_period, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (count != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("count")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(count, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (datesearch != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("datesearch")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(datesearch, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (debug != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("debug")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(debug, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (default_columns != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("default_columns")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(default_columns, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (deleted != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("deleted")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(deleted, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (domain != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("domain")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(domain, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (enddate != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("enddate")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(enddate, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (enddatetime != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("enddatetime")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(enddatetime, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (excludeslacalcs != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("excludeslacalcs")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(excludeslacalcs, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (excludethese != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("excludethese")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(excludethese, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (excludetickettypeallowall != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("excludetickettypeallowall")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(excludetickettypeallowall, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (extraportalfilter != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("extraportalfilter")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(extraportalfilter, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (facebook_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("facebook_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(facebook_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (fetchgrandchildren != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("fetchgrandchildren")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(fetchgrandchildren, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (flagged != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("flagged")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(flagged, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (followedandagents != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("followedandagents")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(followedandagents, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (ignoremilestonerestriction != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("ignoremilestonerestriction")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(ignoremilestonerestriction, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeaccountmanager != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeaccountmanager")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeaccountmanager, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeagent != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeagent")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeagent, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeallopen != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeallopen")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeallopen, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeappointmentid != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeappointmentid")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeappointmentid, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeapproval != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeapproval")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeapproval, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeassetkeyfield != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeassetkeyfield")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeassetkeyfield, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeassettype != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeassettype")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeassettype, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includebreached != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includebreached")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includebreached, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includebudgettype != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includebudgettype")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includebudgettype, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includechildids != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includechildids")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includechildids, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includechildread != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includechildread")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includechildread, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includechildren != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includechildren")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includechildren, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeclosed != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeclosed")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeclosed, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includecolumns != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includecolumns")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includecolumns, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includecompleted != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includecompleted")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includecompleted, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includecontract != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includecontract")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includecontract, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includecountryregion != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includecountryregion")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includecountryregion, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includefirstname != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includefirstname")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includefirstname, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includefollowedonly != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includefollowedonly")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includefollowedonly, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includehold != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includehold")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includehold, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeinactivetechs != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeinactivetechs")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeinactivetechs, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeinactiveusers != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeinactiveusers")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeinactiveusers, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeitilname != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeitilname")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeitilname, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includelastaction != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includelastaction")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includelastaction, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includelastincomingemail != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includelastincomingemail")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includelastincomingemail, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includelastname != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includelastname")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includelastname, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includelastnote != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includelastnote")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includelastnote, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includelocked != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includelocked")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includelocked, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includemailbox != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includemailbox")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includemailbox, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includemailid != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includemailid")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includemailid, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includemyuseronly != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includemyuseronly")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includemyuseronly, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includenextactivitydate != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includenextactivitydate")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includenextactivitydate, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includenextappointmenttype != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includenextappointmenttype")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includenextappointmenttype, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeparentsubject != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeparentsubject")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeparentsubject, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeprojects != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeprojects")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeprojects, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeread != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeread")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeread, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includerelatedservices != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includerelatedservices")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includerelatedservices, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includerelease1 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includerelease1")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includerelease1, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includerelease2 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includerelease2")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includerelease2, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includerelease3 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includerelease3")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includerelease3, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeservicecategory != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeservicecategory")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeservicecategory, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeslaactiondate != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeslaactiondate")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeslaactiondate, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeslatimer != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeslatimer")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeslatimer, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includestatus != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includestatus")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includestatus, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includesubmittedonly != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includesubmittedonly")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includesubmittedonly, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includesupplier != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includesupplier")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includesupplier, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includetickettype != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includetickettype")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includetickettype, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includetimetaken != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includetimetaken")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includetimetaken, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includetoplevel != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includetoplevel")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includetoplevel, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeviewing != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeviewing")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeviewing, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeworkflowstage != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeworkflowstage")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeworkflowstage, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includeworkflowstagenumber != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includeworkflowstagenumber")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includeworkflowstagenumber, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (includuserdepartments != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("includuserdepartments")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(includuserdepartments, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (inlcludeopenchildcount != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("inlcludeopenchildcount")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(inlcludeopenchildcount, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (invlucebranch != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("invlucebranch")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(invlucebranch, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (ismilestone != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("ismilestone")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(ismilestone, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (isorion != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("isorion")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(isorion, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (isquicktimesearch != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("isquicktimesearch")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(isquicktimesearch, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (isscom != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("isscom")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(isscom, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (isteams != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("isteams")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(isteams, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (iszapier != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("iszapier")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(iszapier, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (itil_requesttype != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("itil_requesttype")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(itil_requesttype, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (itil_requesttype_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("itil_requesttype_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(itil_requesttype_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (kanbanviewontheagentapp != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("kanbanviewontheagentapp")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(kanbanviewontheagentapp, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (kanbanviewontheportal != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("kanbanviewontheportal")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(kanbanviewontheportal, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (lastupdatefromdate != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("lastupdatefromdate")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(lastupdatefromdate, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (lastupdatetodate != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("lastupdatetodate")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(lastupdatetodate, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (list_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("list_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(list_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (milestone_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("milestone_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(milestone_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (mine != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("mine")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(mine, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (nochargeonly != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("nochargeonly")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(nochargeonly, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (notime != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("notime")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(notime, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (onlytime != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("onlytime")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(onlytime, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (open_only != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("open_only")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(open_only, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("order")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(order, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order2 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("order2")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(order2, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order3 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("order3")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(order3, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order4 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("order4")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(order4, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order5 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("order5")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(order5, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (orderdesc != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("orderdesc")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(orderdesc, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (orderdesc2 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("orderdesc2")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(orderdesc2, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (orderdesc3 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("orderdesc3")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(orderdesc3, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (orderdesc4 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("orderdesc4")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(orderdesc4, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (orderdesc5 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("orderdesc5")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(orderdesc5, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (orion_type != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("orion_type")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(orion_type, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (page_no != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("page_no")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(page_no, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (page_size != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("page_size")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(page_size, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (pageinate != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("pageinate")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(pageinate, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (parent_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("parent_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(parent_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (pending_review != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("pending_review")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(pending_review, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (per_action != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("per_action")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(per_action, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (prepayorcontractonly != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("prepayorcontractonly")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(prepayorcontractonly, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (priority != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("priority")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(priority, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (product != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("product")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(product, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (project_ids != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("project_ids")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(project_ids, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (ready_for_invoicing != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("ready_for_invoicing")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(ready_for_invoicing, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (related_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("related_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(related_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (release_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("release_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(release_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (requesttype != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("requesttype")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(requesttype, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (requesttype_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("requesttype_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(requesttype_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (requesttypegroup != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("requesttypegroup")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(requesttypegroup, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_details != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_details")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_details, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_inventory_number != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_inventory_number")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_inventory_number, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_oppcompanyname != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_oppcompanyname")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_oppcompanyname, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_oppcontactname != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_oppcontactname")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_oppcontactname, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_oppemailaddress != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_oppemailaddress")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_oppemailaddress, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_release1 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_release1")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_release1, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_release2 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_release2")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_release2, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_release3 != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_release3")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_release3, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_releasenote != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_releasenote")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_releasenote, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_reportedby != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_reportedby")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_reportedby, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_summary != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_summary")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_summary, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_supplier_reference != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_supplier_reference")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_supplier_reference, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_user_name != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_user_name")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_user_name, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search_version != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("search_version")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(search_version, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (searchactions != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("searchactions")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(searchactions, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (searchthisticketid != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("searchthisticketid")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(searchthisticketid, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (service_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("service_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(service_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (showonroadmap != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("showonroadmap")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(showonroadmap, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (site_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("site_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(site_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (sitepostcode != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("sitepostcode")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(sitepostcode, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (sla != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("sla")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(sla, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (sprint_for_tickettype_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("sprint_for_tickettype_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(sprint_for_tickettype_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (sprints != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("sprints")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(sprints, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (startandendset != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("startandendset")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(startandendset, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (startdate != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("startdate")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(startdate, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (startdatetime != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("startdatetime")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(startdatetime, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (status != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("status")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(status, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (status_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("status_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(status_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (submittedandagents != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("submittedandagents")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(submittedandagents, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (supplier_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("supplier_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(supplier_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (supplier_status != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("supplier_status")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(supplier_status, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (team != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("team")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(team, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (team_name != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("team_name")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(team_name, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (ticketarea_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("ticketarea_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(ticketarea_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (ticketcontract_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("ticketcontract_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(ticketcontract_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (ticketidonly != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("ticketidonly")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(ticketidonly, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (ticketids != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("ticketids")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(ticketids, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (ticketlinktype != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("ticketlinktype")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(ticketlinktype, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (toplevel_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("toplevel_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(toplevel_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (unlinked_only != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("unlinked_only")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(unlinked_only, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (user_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("user_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(user_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (username != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("username")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(username, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (utcoffsetQuery != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("utcoffset")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(utcoffsetQuery, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (view_id != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("view_id")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(view_id, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (withattachments != null)
                    {
                        urlBuilder_.Append(System.Uri.EscapeDataString("withattachments")).Append('=').Append(System.Uri.EscapeDataString(ConvertToString(withattachments, System.Globalization.CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            return;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

}