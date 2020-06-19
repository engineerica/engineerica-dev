#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// View a list of users action logs
//
// Allows the user to view the audit logs for the account.
//
void
ActionlogAPI_actionlogList(apiClient_t *apiClient, int from , int count , char * user , char startdate , char enddate , char * resource , char * actionfilter , char * argument );


