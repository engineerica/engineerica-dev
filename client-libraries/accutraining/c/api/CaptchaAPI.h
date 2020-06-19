#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Gets a captcha challenge that the user must complete to do certain requests.
//
void
CaptchaAPI_captchaGetchallenge(apiClient_t *apiClient);


// Gets a captcha image that the user must complete to do certain requests.
//
void
CaptchaAPI_captchaGetimage(apiClient_t *apiClient, char * captchatoken );


