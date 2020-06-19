#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete an attendance restriction
//
// Allows the user to delete an existing attendance restriction.
//
void
AttendancerestrictionAPI_attendancerestrictionDelete(apiClient_t *apiClient, char * id ,  body );


// View details of an attendance restriction
//
// Allows the user to view an individual attendance restriction and its details.
//
void
AttendancerestrictionAPI_attendancerestrictionGet(apiClient_t *apiClient, char * id );


// View a list of attendance restrictions
//
// Allows the user to view the list of all attendance restrictions.
//
void
AttendancerestrictionAPI_attendancerestrictionList(apiClient_t *apiClient, int from , int count );


// Create or edit an attendance restriction
//
// Allows the user to create or edit an attendance restriction.
//
void
AttendancerestrictionAPI_attendancerestrictionSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


