#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a computer
//
// Allows the user to delete an existing computer.
//
void
ComputerlabAPI_computerlabDeletecomputer(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Search and view details of a computer
//
// Allows the user to search and view an individual computer and its details.
//
void
ComputerlabAPI_computerlabGetcomputer(apiClient_t *apiClient, char * id );


// Loads the settings for a computer lab
//
// Loads the settings for a computer lab.
//
void
ComputerlabAPI_computerlabGetsettings(apiClient_t *apiClient, char * id );


// Gets whether a user is signed-in or not.
//
void
ComputerlabAPI_computerlabIssignedin(apiClient_t *apiClient, char * station , char * user );


// View a list of computers
//
// Allows the user to view the list of all computers.
//
void
ComputerlabAPI_computerlabListcomputers(apiClient_t *apiClient, int from , int count , char * location , int freeonly );


// View a list of the locations that use the Computer Lab add-on
//
// Allows the user to view the list of all labs.
//
void
ComputerlabAPI_computerlabListlabs(apiClient_t *apiClient);


// View a list of sign-in stations available for computer labs.
//
// Allows the user to view the list of sign-in stations that are available for computer labs.
//
void
ComputerlabAPI_computerlabListstations(apiClient_t *apiClient);


// Create or edit a computer
//
// Allows the user to create or edit a computer.
//
void
ComputerlabAPI_computerlabSavecomputer(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Saves the settings for a computer lab
//
// Saves the settings for a computer lab.
//
void
ComputerlabAPI_computerlabSavesettings(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Save a new swipe from a computer in a computer lab.
//
void
ComputerlabAPI_computerlabSaveswipe(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


