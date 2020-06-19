#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Add myself to a waiting line
//
// Allows the user to add themselves to a waiting line from the AccuCampus mobile app.
//
void
VirtuallineAPI_virtuallineAddmyself(apiClient_t *apiClient, char * waitinglineid );


// Lists waiting lines that have remote access enabled
//
void
VirtuallineAPI_virtuallineList(apiClient_t *apiClient);


// Remove myself from a waiting line
//
// Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.
//
void
VirtuallineAPI_virtuallineRemovemyself(apiClient_t *apiClient);


