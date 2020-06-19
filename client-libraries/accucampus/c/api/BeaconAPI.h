#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a beacon profile
//
// Allows the user to delete an existing beacon profile.
//
void
BeaconAPI_beaconDelete(apiClient_t *apiClient, char * id ,  body );


// Disable beacon support account wide
//
// Allows the user to enable or disable beacon usage account wide.
//
void
BeaconAPI_beaconDisable(apiClient_t *apiClient);


// View details of a beacon profile
//
// Allows the user to view an individual beacon profile and its details.
//
void
BeaconAPI_beaconGet(apiClient_t *apiClient, char * id );


// Get the sign-in stations assigned to specific beacons.
//
void
BeaconAPI_beaconGetlocations(apiClient_t *apiClient, char * beacons );


// Get the location settings in the specified sign-in station.
//
void
BeaconAPI_beaconGetstationlocation(apiClient_t *apiClient, char * station , char * location );


// View the identifier for the account's beacon region (for sign-in stations).
//
void
BeaconAPI_beaconGetuuid(apiClient_t *apiClient);


// View a list of beacon profiles
//
// Allows the user to view the list of all beacon profiles without their basic details.
//
void
BeaconAPI_beaconList(apiClient_t *apiClient, int from , int count );


// View a list of beacon profiles with their characteristics
//
// Allows the user to view the list of all beacon profiles with their basic details.
//
void
BeaconAPI_beaconListprofiles(apiClient_t *apiClient);


// Generate or reset the identifier for the account's beacon region.
//
// Allows the user to reset the identifier for the beacon region, generally not necessary.
//
void
BeaconAPI_beaconResetuuid(apiClient_t *apiClient);


// Create or edit a beacon profile
//
// Allows the user to create or edit a beacon profile.
//
void
BeaconAPI_beaconSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Check if there's location available to sign-in / out.
//
void
BeaconAPI_beaconScanlocations(apiClient_t *apiClient, char * beacons );


// Set the identifier for the account's beacon region (for sign-in stations).
//
// Allows the user to set the identifier for the account's beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.
//
void
BeaconAPI_beaconSetuuid(apiClient_t *apiClient, char * id );


// View all the beacon regions defined for silent tracking
//
void
BeaconAPI_beaconSilentregions(apiClient_t *apiClient);


// Sign-in silently from the location specified by a beacon
//
void
BeaconAPI_beaconSilentsignin(apiClient_t *apiClient, char * uuid );


// Sign-out silently from the location specified by a beacon
//
void
BeaconAPI_beaconSilentsignout(apiClient_t *apiClient, char * uuid );


