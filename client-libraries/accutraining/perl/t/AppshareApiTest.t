=begin comment

AccuTraining OpenAPI 3

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

use_ok('WWW::OpenAPIClient::AppshareApi');

my $api = WWW::OpenAPIClient::AppshareApi->new();
isa_ok($api, 'WWW::OpenAPIClient::AppshareApi');

#
# appshare_getphone test
#
{
    my $result = $api->appshare_getphone();
}

#
# appshare_sendtext test
#
{
    my $phonenumber = undef; # replace NULL with a proper value
    my $result = $api->appshare_sendtext(phonenumber => $phonenumber);
}


1;
