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

use_ok('WWW::OpenAPIClient::SettingApi');

my $api = WWW::OpenAPIClient::SettingApi->new();
isa_ok($api, 'WWW::OpenAPIClient::SettingApi');

#
# setting_addlogo test
#
{
    my $upload = undef; # replace NULL with a proper value
    my $filename = undef; # replace NULL with a proper value
    my $result = $api->setting_addlogo(upload => $upload, filename => $filename);
}

#
# setting_get test
#
{
    my $keys = undef; # replace NULL with a proper value
    my $domain = undef; # replace NULL with a proper value
    my $scope = undef; # replace NULL with a proper value
    my $result = $api->setting_get(keys => $keys, domain => $domain, scope => $scope);
}

#
# setting_save test
#
{
    my $unknown_base_type = undef; # replace NULL with a proper value
    my $result = $api->setting_save(unknown_base_type => $unknown_base_type);
}

#
# setting_viewgeneral test
#
{
    my $result = $api->setting_viewgeneral();
}


1;
