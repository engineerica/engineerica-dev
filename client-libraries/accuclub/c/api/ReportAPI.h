#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


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


