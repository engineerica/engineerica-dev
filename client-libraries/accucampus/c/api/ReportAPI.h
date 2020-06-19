#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Query and load an attendance analytics report
//
// Allows the user to query and load attendance analytics reports.
//
void
ReportAPI_reportAttanalyticsprepare(apiClient_t *apiClient, char * reportname , char * params , char * refreshgroup );


// View a list of available reports
//
// Allows the user to view the complete list of available, canned reports.
//
void
ReportAPI_reportList(apiClient_t *apiClient);


// Permissions by user report
//
// Lists all the users in the system including their corresponding permissions.
//
void
ReportAPI_reportPermissionsbyuser(apiClient_t *apiClient, char * params );


// Queries and loads the specified report, in background.
//
// Allows the user to run reports, in background, with the exception of attendance analytics reports.
//
void
ReportAPI_reportPrepare(apiClient_t *apiClient, char * reportname , char * params , char * repformat , char * fillgroupid , char * groupby , char * refreshgroup , char * filtertext );


// Query and load a specified report
//
// Allows the user to run reports with the exception of attendance analytics reports.
//
void
ReportAPI_reportQuery(apiClient_t *apiClient, char * reportname , char * params );


// Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.
//
// Allows the user to use a report to assign or unassign tags.
//
void
ReportAPI_reportTagresults(apiClient_t *apiClient, char * reportname , int assign , char * tags , char * params );


