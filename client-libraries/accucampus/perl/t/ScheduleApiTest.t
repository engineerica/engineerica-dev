=begin comment

AccuCampus OpenAPI 3

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator
# Please update the test cases below to test the API endpoints.
# Ref: https://openapi-generator.tech
#
use Test::More tests => 1; #TODO update number of test cases
use Test::Exception;

use lib 'lib';
use strict;
use warnings;

use_ok('WWW::OpenAPIClient::ScheduleApi');

my $api = WWW::OpenAPIClient::ScheduleApi->new();
isa_ok($api, 'WWW::OpenAPIClient::ScheduleApi');

#
# schedule_delete test
#
{
    my $unknown_base_type = undef; # replace NULL with a proper value
    my $result = $api->schedule_delete(unknown_base_type => $unknown_base_type);
}

#
# schedule_deletemine test
#
{
    my $unknown_base_type = undef; # replace NULL with a proper value
    my $result = $api->schedule_deletemine(unknown_base_type => $unknown_base_type);
}

#
# schedule_enable test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $enable = undef; # replace NULL with a proper value
    my $result = $api->schedule_enable(userid => $userid, enable => $enable);
}

#
# schedule_enablemine test
#
{
    my $enable = undef; # replace NULL with a proper value
    my $result = $api->schedule_enablemine(enable => $enable);
}

#
# schedule_findallstaffslots test
#
{
    my $starttime = undef; # replace NULL with a proper value
    my $endtime = undef; # replace NULL with a proper value
    my $staffid = undef; # replace NULL with a proper value
    my $serviceids = undef; # replace NULL with a proper value
    my $eventid = undef; # replace NULL with a proper value
    my $locationid = undef; # replace NULL with a proper value
    my $staffroleids = undef; # replace NULL with a proper value
    my $availablefor = undef; # replace NULL with a proper value
    my $result = $api->schedule_findallstaffslots(starttime => $starttime, endtime => $endtime, staffid => $staffid, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, staffroleids => $staffroleids, availablefor => $availablefor);
}

#
# schedule_findslots test
#
{
    my $staffid = undef; # replace NULL with a proper value
    my $starttime = undef; # replace NULL with a proper value
    my $endtime = undef; # replace NULL with a proper value
    my $serviceids = undef; # replace NULL with a proper value
    my $eventid = undef; # replace NULL with a proper value
    my $locationid = undef; # replace NULL with a proper value
    my $availablefor = undef; # replace NULL with a proper value
    my $result = $api->schedule_findslots(staffid => $staffid, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, availablefor => $availablefor);
}

#
# schedule_findstaffavail test
#
{
    my $starttime = undef; # replace NULL with a proper value
    my $endtime = undef; # replace NULL with a proper value
    my $serviceids = undef; # replace NULL with a proper value
    my $eventid = undef; # replace NULL with a proper value
    my $locationid = undef; # replace NULL with a proper value
    my $staffroleids = undef; # replace NULL with a proper value
    my $availablefor = undef; # replace NULL with a proper value
    my $photosize = undef; # replace NULL with a proper value
    my $result = $api->schedule_findstaffavail(starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, staffroleids => $staffroleids, availablefor => $availablefor, photosize => $photosize);
}

#
# schedule_get test
#
{
    my $scheduleid = undef; # replace NULL with a proper value
    my $result = $api->schedule_get(scheduleid => $scheduleid);
}

#
# schedule_getmine test
#
{
    my $scheduleid = undef; # replace NULL with a proper value
    my $result = $api->schedule_getmine(scheduleid => $scheduleid);
}

#
# schedule_getstaff test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $result = $api->schedule_getstaff(userid => $userid);
}

#
# schedule_getstaffmine test
#
{
    my $result = $api->schedule_getstaffmine();
}

#
# schedule_myofftimes test
#
{
    my $includedeleted = undef; # replace NULL with a proper value
    my $onlyupcoming = undef; # replace NULL with a proper value
    my $modifiedafter = undef; # replace NULL with a proper value
    my $result = $api->schedule_myofftimes(includedeleted => $includedeleted, onlyupcoming => $onlyupcoming, modifiedafter => $modifiedafter);
}

#
# schedule_save test
#
{
    my $unknown_base_type = undef; # replace NULL with a proper value
    my $result = $api->schedule_save(unknown_base_type => $unknown_base_type);
}

#
# schedule_savemine test
#
{
    my $unknown_base_type = undef; # replace NULL with a proper value
    my $result = $api->schedule_savemine(unknown_base_type => $unknown_base_type);
}


1;