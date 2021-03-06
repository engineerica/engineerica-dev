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

use_ok('WWW::OpenAPIClient::StaffavailApi');

my $api = WWW::OpenAPIClient::StaffavailApi->new();
isa_ok($api, 'WWW::OpenAPIClient::StaffavailApi');

#
# staffavail_addmetoallservices test
#
{
    my $result = $api->staffavail_addmetoallservices();
}

#
# staffavail_addmetoservice test
#
{
    my $serviceid = undef; # replace NULL with a proper value
    my $result = $api->staffavail_addmetoservice(serviceid => $serviceid);
}

#
# staffavail_addusertoallservices test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $result = $api->staffavail_addusertoallservices(userid => $userid);
}

#
# staffavail_addusertoservice test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $serviceid = undef; # replace NULL with a proper value
    my $result = $api->staffavail_addusertoservice(userid => $userid, serviceid => $serviceid);
}

#
# staffavail_getmyservices test
#
{
    my $result = $api->staffavail_getmyservices();
}

#
# staffavail_getservices test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $result = $api->staffavail_getservices(userid => $userid);
}

#
# staffavail_getusersforservice test
#
{
    my $serviceid = undef; # replace NULL with a proper value
    my $result = $api->staffavail_getusersforservice(serviceid => $serviceid);
}

#
# staffavail_listtypes test
#
{
    my $result = $api->staffavail_listtypes();
}

#
# staffavail_removemefromallservices test
#
{
    my $result = $api->staffavail_removemefromallservices();
}

#
# staffavail_removemefromservice test
#
{
    my $serviceid = undef; # replace NULL with a proper value
    my $result = $api->staffavail_removemefromservice(serviceid => $serviceid);
}

#
# staffavail_removeuserfromallservices test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $result = $api->staffavail_removeuserfromallservices(userid => $userid);
}

#
# staffavail_removeuserfromservice test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $serviceid = undef; # replace NULL with a proper value
    my $result = $api->staffavail_removeuserfromservice(userid => $userid, serviceid => $serviceid);
}

#
# staffavail_setavailability test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $availablefor = undef; # replace NULL with a proper value
    my $result = $api->staffavail_setavailability(userid => $userid, availablefor => $availablefor);
}

#
# staffavail_setmyavailability test
#
{
    my $availablefor = undef; # replace NULL with a proper value
    my $result = $api->staffavail_setmyavailability(availablefor => $availablefor);
}


1;
