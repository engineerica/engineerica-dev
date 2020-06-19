#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Register current user to an event session
//
// Allows the user to register themselves for an event.
//
void
SessionregAPI_sessionregAddcurrentuser(apiClient_t *apiClient, char * eventid , char sessiondate );


// Register users for events
//
// Allows the user to register another user for an upcoming event.
//
void
SessionregAPI_sessionregAdduser(apiClient_t *apiClient, char * userid , char * eventid , char sessiondate );


// View all the sessions the logged user is registered to
//
void
SessionregAPI_sessionregGetmysessions(apiClient_t *apiClient, char date );


// Lists the registrations for a specific user
//
// Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.
//
void
SessionregAPI_sessionregGetsessions(apiClient_t *apiClient, char * userid );


// Get the settings for session registration
//
// Allows the user to view a event's session registration settings.
//
void
SessionregAPI_sessionregGetsettings(apiClient_t *apiClient, char * locationid , char * eventid , char sessiondate , int noinherit );


// Lists the registrations for a specific session
//
// Allows the user to view the registration for a specified event session.
//
void
SessionregAPI_sessionregGetusers(apiClient_t *apiClient, char * eventid , char sessiondate );


// List the sessions available for a specific event
//
// Allows the user to view all the sessions available for a recurring event.
//
void
SessionregAPI_sessionregListsessions(apiClient_t *apiClient, char * eventid , char sessiondate );


// View a list of upcoming event sessions
//
// Allows the user to view the full list of upcoming events.
//
void
SessionregAPI_sessionregListupcoming(apiClient_t *apiClient, char date );


// View a list of upcoming sessions of a particular event
//
// Allows the user to view the upcoming recurring sessions of a specified event.
//
void
SessionregAPI_sessionregListupcomingevent(apiClient_t *apiClient, char date , char * event );


// Unregister current user from an event session
//
// Allows the user to un-register themselves from an event.
//
void
SessionregAPI_sessionregRemovecurrentuser(apiClient_t *apiClient, char * eventid , char sessiondate );


// Removes a user from an event session
//
// Allows the user to un-register another user from an event.
//
void
SessionregAPI_sessionregRemoveuser(apiClient_t *apiClient, char * userid , char * eventid , char sessiondate );


// Save the settings for an event's session registration
//
// Allows the user to save the settings for an event.
//
void
SessionregAPI_sessionregSavesettings(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


