#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete memorized report
//
// Allows the user to delete a memorized report that they have created.
//
void
MemorizedreportAPI_memorizedreportDelete(apiClient_t *apiClient, char * id ,  body );


// View details of a memorized report
//
// Allows the user to view an individual memorized report and its details.
//
void
MemorizedreportAPI_memorizedreportGet(apiClient_t *apiClient, char * id );


// View a list of all his memorized reports
//
// Allows the user to view the list of all memorized reports that they have created.
//
void
MemorizedreportAPI_memorizedreportList(apiClient_t *apiClient, int from , int count , char * customname );


// Create or edit a memorized report
//
// Allows the user to create or edit a memorized report for themselves.
//
void
MemorizedreportAPI_memorizedreportSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


