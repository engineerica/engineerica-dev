#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Enable a service in a specific location
//
// Allows the user to enable a service in a location to which they are scoped.
//
void
ServiceassignmentAPI_serviceassignmentAddservice(apiClient_t *apiClient, char * serviceid , char * locationid );


// View a list of services enabled for a specific location
//
// Allows the user to view a list of services available in a location to which they are scoped.
//
void
ServiceassignmentAPI_serviceassignmentGetlocation(apiClient_t *apiClient, char * locationid , int includegloballyavailable , int namefilter , int count );


// View a list of locations where a service is available
//
// Allows the user to view a list of locations in which a service is available.
//
void
ServiceassignmentAPI_serviceassignmentGetservice(apiClient_t *apiClient, char * serviceid );


// Remove a service from a location
//
// Allows the user to disable a service from a location to which they are scoped.
//
void
ServiceassignmentAPI_serviceassignmentRemoveservice(apiClient_t *apiClient, char * serviceid , char * locationid );


