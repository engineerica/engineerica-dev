#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a report schedule
//
// Allows the user to delete a scheduled report that they created.
//
void
ReportscheduleAPI_reportscheduleDelete(apiClient_t *apiClient, char * id ,  body );


// Get a report schedule
//
// Allows the user to view the list of reports that they scheduled.
//
void
ReportscheduleAPI_reportscheduleGet(apiClient_t *apiClient, char * id );


// View a list of the scheduled reports
//
// Allows the user to view a list of the scheduled reports.
//
void
ReportscheduleAPI_reportscheduleList(apiClient_t *apiClient, int from , int count );


// Create or edit a report schedule
//
// Allows the user to create or edit a scheduled report.
//
void
ReportscheduleAPI_reportscheduleSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


