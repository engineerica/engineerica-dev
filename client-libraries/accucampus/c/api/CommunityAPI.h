#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Sends an invitation to everyone to AccuCampus Communities
//
// Allows the user to invite all other users to the AccuCampus Communities.
//
void
CommunityAPI_communityInvite(apiClient_t *apiClient);


// Sends an invitation for myself to AccuCampus Communities
//
// Allows the user to access the AccuCampus Communities.
//
void
CommunityAPI_communityJoin(apiClient_t *apiClient);


