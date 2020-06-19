#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Associate current user to all services
//
// Allows the user to associate themselves to all services, provided they have a staff role.
//
void
StaffavailAPI_staffavailAddmetoallservices(apiClient_t *apiClient);


// Associate current user to a service
//
// Allows the user to associate themselves to a service, provided they have a staff role.
//
void
StaffavailAPI_staffavailAddmetoservice(apiClient_t *apiClient, char * serviceid );


// Associate a staff member to all services
//
// Allows the user to make a staff member available for all services.
//
void
StaffavailAPI_staffavailAddusertoallservices(apiClient_t *apiClient, char * userid );


// Associate a staff member to a service
//
// Allows the user to make a staff member available for a service.
//
void
StaffavailAPI_staffavailAddusertoservice(apiClient_t *apiClient, char * userid , char * serviceid );


// View the services the current user is available for
//
// Allows the user to view a list of services that they are associated with.
//
void
StaffavailAPI_staffavailGetmyservices(apiClient_t *apiClient);


// View a list of services that a staff member is available for
//
// Allows the user to view the list of services that a staff member is available for.
//
void
StaffavailAPI_staffavailGetservices(apiClient_t *apiClient, char * userid );


// View a list of staff members that are available for a specific service
//
// Allows the user to view all staff members who are available for a service.
//
void
StaffavailAPI_staffavailGetusersforservice(apiClient_t *apiClient, char * serviceid );


// View all the availability types
//
void
StaffavailAPI_staffavailListtypes(apiClient_t *apiClient);


// Remove current user from all services
//
// Allows the user to disassociate themselves from all services, provided they have a staff role.
//
void
StaffavailAPI_staffavailRemovemefromallservices(apiClient_t *apiClient);


// Remove current user from a service
//
// Allows the user to disassociate themselves from a service, provided they have a staff role.
//
void
StaffavailAPI_staffavailRemovemefromservice(apiClient_t *apiClient, char * serviceid );


// Removes a staff member from the registration to all services
//
// Allows the user to remove a staff member's availability to all services.
//
void
StaffavailAPI_staffavailRemoveuserfromallservices(apiClient_t *apiClient, char * userid );


// Remove a staff member from a service
//
// Allows the user to remove a staff member's service availability.
//
void
StaffavailAPI_staffavailRemoveuserfromservice(apiClient_t *apiClient, char * userid , char * serviceid );


// Make a staff member available for a specific availability type
//
// Allows the user to set a staff member as available for walk ins, appointments, or both.
//
void
StaffavailAPI_staffavailSetavailability(apiClient_t *apiClient, char * userid , char * availablefor );


// Change current user's availability type
//
// Allows the user to make themselves available for walk ins, appointments, or both.
//
void
StaffavailAPI_staffavailSetmyavailability(apiClient_t *apiClient, char * availablefor );


