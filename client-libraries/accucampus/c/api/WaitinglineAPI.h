#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Put user in a waiting line
//
void
WaitinglineAPI_waitinglineAdduser(apiClient_t *apiClient, char * station , char * user , char * locationid , char time , char * signinrole , char * roleid , char * services , char * eventid , char * staff , int photosize );


// Delete a waiting line
//
// Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.
//
void
WaitinglineAPI_waitinglineDelete(apiClient_t *apiClient, char * id ,  body );


// View details of a waiting line
//
// Allows the user to view the details of a waiting line in a location to which they are scoped.
//
void
WaitinglineAPI_waitinglineGet(apiClient_t *apiClient, char * id , int photosize );


// Check whether a user is in a waiting line, signed-in or is not in the area
//
void
WaitinglineAPI_waitinglineIsuserin(apiClient_t *apiClient, char * station , char time , char * user , char * location );


// View a list of waiting lines
//
// Allows the user to view the list of waiting lines in locations to which they are scoped.
//
void
WaitinglineAPI_waitinglineList(apiClient_t *apiClient, int from , int count );


// Remove a user from a waiting line
//
// Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.
//
void
WaitinglineAPI_waitinglineRemoveuser(apiClient_t *apiClient, char * waitingline , char * itemid );


// Create or edit a waiting line
//
// Allows the user to create or edit a waiting line in a location to which they are scoped.
//
void
WaitinglineAPI_waitinglineSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Sign a user in from a waiting line
//
// Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.
//
void
WaitinglineAPI_waitinglineSigninuser(apiClient_t *apiClient, char * waitingline , char * itemid , char * staff , int photosize );


