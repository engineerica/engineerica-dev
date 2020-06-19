#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Accept the license agreement
//
void
LicenseAPI_licenseAcceptagreement(apiClient_t *apiClient);


// Check if license agreement has been accepted
//
void
LicenseAPI_licenseGetagreementstatus(apiClient_t *apiClient);


// Gets the current license information
//
void
LicenseAPI_licenseGetcurrent(apiClient_t *apiClient);


// Contact Engineerica in order to renew the AccuCampus subscription
//
// Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.
//
void
LicenseAPI_licenseRenew(apiClient_t *apiClient, char * email , char * phonenumber , char * jobtitle , char * institution , char * comments );


