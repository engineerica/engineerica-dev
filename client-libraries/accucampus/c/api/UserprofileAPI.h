#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a user profile
//
// Allows the user to delete a profile from the list of profiles that they have permission to edit.
//
void
UserprofileAPI_userprofileDelete(apiClient_t *apiClient, char * id ,  body );


// View a specific user profile
//
// Allows the user to view individual user profiles and their details, provided they have permission to view that profile.
//
void
UserprofileAPI_userprofileGet(apiClient_t *apiClient, char * id );


// Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
//
// Allows the user to view a profile for a user, provided they have permission to view that user and profile.
//
void
UserprofileAPI_userprofileGetallview(apiClient_t *apiClient, char * id );


// View the list of user profiles
//
// Allows the user to view the full list of profiles that they have permission to view.
//
void
UserprofileAPI_userprofileList(apiClient_t *apiClient, int from , int count );


// Gets the list of all the available user questions
//
// Allows the user to view the list of questions in a profile that they have permission to view.
//
void
UserprofileAPI_userprofileListquestions(apiClient_t *apiClient);


// Gets the statistics of a user group
//
// Allows the user to view the demographic statistics of a user group.
//
void
UserprofileAPI_userprofilePreparestats(apiClient_t *apiClient, char * params );


// Create or edit user profile questions
//
// Allows the user to create or edit a user profile.
//
void
UserprofileAPI_userprofileSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
//
// Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.
//
void
UserprofileAPI_userprofileSaveanswers(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


