#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a tag
//
// Allows the user to delete an existing tag.
//
void
TagAPI_tagDelete(apiClient_t *apiClient, char * id ,  body );


// View details of a specified tag
//
// Allows the user to click on and view the settings for a tag.
//
void
TagAPI_tagGet(apiClient_t *apiClient, char * id );


// View a list of tags
//
// Allows the user to view the list of tags.
//
void
TagAPI_tagList(apiClient_t *apiClient, char * group , int from , int count );


// View a list of entities that can be tagged
//
// Allows the user to view the list of user roles that can be tagged, according to that tag's settings.
//
void
TagAPI_tagListgroups(apiClient_t *apiClient);


// Create or edit a tag
//
// Allows the user to create or edit a tag.
//
void
TagAPI_tagSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Search for tags in the account
//
// Allows the user to search for tags.
//
void
TagAPI_tagSearch(apiClient_t *apiClient, char * query , int allowcreatingnew );


