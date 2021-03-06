=begin comment

AccuCampus OpenAPI 3

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# Do not edit the class manually.
# Ref: https://openapi-generator.tech
#
package WWW::OpenAPIClient::LikeApi;

require 5.6.0;
use strict;
use warnings;
use utf8; 
use Exporter;
use Carp qw( croak );
use Log::Any qw($log);

use WWW::OpenAPIClient::ApiClient;

use base "Class::Data::Inheritable";

__PACKAGE__->mk_classdata('method_documentation' => {});

sub new {
    my $class = shift;
    my $api_client;

    if ($_[0] && ref $_[0] && ref $_[0] eq 'WWW::OpenAPIClient::ApiClient' ) {
        $api_client = $_[0];
    } else {
        $api_client = WWW::OpenAPIClient::ApiClient->new(@_);
    }

    bless { api_client => $api_client }, $class;

}


#
# like_delete
#
# Delete a like
# 
# @param UNKNOWN_BASE_TYPE $unknown_base_type  (optional)
{
    my $params = {
    'unknown_base_type' => {
        data_type => 'UNKNOWN_BASE_TYPE',
        description => '',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'like_delete' } = { 
        summary => 'Delete a like',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub like_delete {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/like/delete';

    my $_method = 'DELETE';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept();
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type('application/json');

    my $_body_data;
    # body params
    if ( exists $args{'unknown_base_type'}) {
        $_body_data = $args{'unknown_base_type'};
    }

    # authentication setting, if any
    my $auth_settings = [qw(bearerAuth )];

    # make the API Call
    $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    return;
}

#
# like_list
#
# View all the likes associated to a target
# 
# @param string $interactionid The id of the interaction to unlike. (required)
# @param int $photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)
{
    my $params = {
    'interactionid' => {
        data_type => 'string',
        description => 'The id of the interaction to unlike.',
        required => '1',
    },
    'photosize' => {
        data_type => 'int',
        description => 'The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'like_list' } = { 
        summary => 'View all the likes associated to a target',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub like_list {
    my ($self, %args) = @_;

    # verify the required parameter 'interactionid' is set
    unless (exists $args{'interactionid'}) {
      croak("Missing the required parameter 'interactionid' when calling like_list");
    }

    # parse inputs
    my $_resource_path = '/like/list';

    my $_method = 'GET';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept();
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type();

    # query params
    if ( exists $args{'interactionid'}) {
        $query_params->{'interactionid'} = $self->{api_client}->to_query_value($args{'interactionid'});
    }

    # query params
    if ( exists $args{'photosize'}) {
        $query_params->{'photosize'} = $self->{api_client}->to_query_value($args{'photosize'});
    }

    my $_body_data;
    # authentication setting, if any
    my $auth_settings = [qw(bearerAuth )];

    # make the API Call
    $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    return;
}

#
# like_save
#
# Save a like
# 
# @param UNKNOWN_BASE_TYPE $unknown_base_type  (optional)
{
    my $params = {
    'unknown_base_type' => {
        data_type => 'UNKNOWN_BASE_TYPE',
        description => '',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'like_save' } = { 
        summary => 'Save a like',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub like_save {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/like/save';

    my $_method = 'POST';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept();
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type('application/json');

    my $_body_data;
    # body params
    if ( exists $args{'unknown_base_type'}) {
        $_body_data = $args{'unknown_base_type'};
    }

    # authentication setting, if any
    my $auth_settings = [qw(bearerAuth )];

    # make the API Call
    $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    return;
}

1;
