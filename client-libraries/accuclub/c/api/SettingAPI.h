#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Add a logo to the account
//
// Allows the user to add the logo for the account, which appears on all pages on the AccuClub browser version.
//
void
SettingAPI_settingAddlogo(apiClient_t *apiClient, char * upload , char * filename );


// Get settings for the account or the specified scope
//
void
SettingAPI_settingGet(apiClient_t *apiClient, char * keys , char * domain , char * scope );


// Save settings for the account or the specified scope
//
// Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.
//
void
SettingAPI_settingSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View general settings for the account
//
// Allows the user to view the settings' general section.
//
void
SettingAPI_settingViewgeneral(apiClient_t *apiClient);


