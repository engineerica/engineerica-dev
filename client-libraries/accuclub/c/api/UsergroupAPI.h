#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Add a user to a group
//
// Allows the user to add a user to a group that they have permission to edit.
//
void
UsergroupAPI_usergroupAddmember(apiClient_t *apiClient, char * userid , char * groupid );


// Delete a group
//
// Allows the user to delete a group that they have permission to edit.
//
void
UsergroupAPI_usergroupDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of a user group
//
// Allows the user to view a user group and its details.
//
void
UsergroupAPI_usergroupGet(apiClient_t *apiClient, char * id );


// View the members of a user group
//
// Allows the user to view the list of users in a group that they have permission to view.
//
void
UsergroupAPI_usergroupGetmembers(apiClient_t *apiClient, char * groupid );


// View the groups which a user is registered to
//
// Allows the user to view the groups an individual user is registered to, based on group and user permissions.
//
void
UsergroupAPI_usergroupGetuser(apiClient_t *apiClient, char * userid );


// View a list of user groups
//
// Allows the user to view the list of groups that they have permission to view.
//
void
UsergroupAPI_usergroupList(apiClient_t *apiClient, int from , int count , char * type );


// Refresh the dynamic group
//
// Allows the user to refresh a dynamic group that they have permission to edit.
//
void
UsergroupAPI_usergroupRefresh(apiClient_t *apiClient, char * group );


// Remove a user from a group
//
// Allows the user to remove a user from a group that they have permission to edit.
//
void
UsergroupAPI_usergroupRemovemember(apiClient_t *apiClient, char * userid , char * groupid );


// Create or edit a group
//
// Allows the user to create a new group or edit a group that they have permission to edit.
//
void
UsergroupAPI_usergroupSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


