#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a sign-in station
//
// Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.
//
void
StationAPI_stationDelete(apiClient_t *apiClient, char * id ,  body );


// View details of a sign-in station
//
// Allows the user to view an individual sign-in station and its details.
//
void
StationAPI_stationGet(apiClient_t *apiClient, char * id );


// Get all the current terms
//
void
StationAPI_stationGetcurrentterms(apiClient_t *apiClient, char * station );


// Gets a the info to display in the sign-in station by it's ID.
//
void
StationAPI_stationGetinfo(apiClient_t *apiClient, char * id , char * event );


// Gets the current license information
//
void
StationAPI_stationGetlicense(apiClient_t *apiClient, char * station );


// View a list of sign-in stations
//
// Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.
//
void
StationAPI_stationList(apiClient_t *apiClient, int from , int count );


// Create or edit a sign-in station
//
// Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.
//
void
StationAPI_stationSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Unlocks the sign-in station.
//
void
StationAPI_stationUnlock(apiClient_t *apiClient, char * id , char * passcode , char * method );


