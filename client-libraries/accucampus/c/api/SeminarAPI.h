#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete an event
//
// Allows the user to delete an existing event.
//
void
SeminarAPI_seminarDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of a event
//
// Allows the user to view a event and its details.
//
void
SeminarAPI_seminarGet(apiClient_t *apiClient, char * id );


// View a list of events
//
// Allows the user to view the full list of events in the past, present, and future.
//
void
SeminarAPI_seminarList(apiClient_t *apiClient, char * from , char * count , int summaryonly , char * termid );


// Create or edit a event
//
// Allows the user to create or edit a event.
//
void
SeminarAPI_seminarSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


