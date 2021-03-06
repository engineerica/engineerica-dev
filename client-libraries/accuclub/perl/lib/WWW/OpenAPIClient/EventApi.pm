=begin comment

AccuClub OpenAPI 3

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
package WWW::OpenAPIClient::EventApi;

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
# event_delete
#
# Delete a course
# 
# @param string $id The id of the event to delete. (required)
# @param AnyType $body  (optional)
{
    my $params = {
    'id' => {
        data_type => 'string',
        description => 'The id of the event to delete.',
        required => '1',
    },
    'body' => {
        data_type => 'AnyType',
        description => '',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'event_delete' } = { 
        summary => 'Delete a course',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub event_delete {
    my ($self, %args) = @_;

    # verify the required parameter 'id' is set
    unless (exists $args{'id'}) {
      croak("Missing the required parameter 'id' when calling event_delete");
    }

    # parse inputs
    my $_resource_path = '/event/{id}';

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

    # path params
    if ( exists $args{'id'}) {
        my $_base_variable = "{" . "id" . "}";
        my $_base_value = $self->{api_client}->to_path_value($args{'id'});
        $_resource_path =~ s/$_base_variable/$_base_value/g;
    }

    my $_body_data;
    # body params
    if ( exists $args{'body'}) {
        $_body_data = $args{'body'};
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
# event_get
#
# Search and view details of a course
# 
# @param string $id The id of the event to get. (required)
{
    my $params = {
    'id' => {
        data_type => 'string',
        description => 'The id of the event to get.',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'event_get' } = { 
        summary => 'Search and view details of a course',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub event_get {
    my ($self, %args) = @_;

    # verify the required parameter 'id' is set
    unless (exists $args{'id'}) {
      croak("Missing the required parameter 'id' when calling event_get");
    }

    # parse inputs
    my $_resource_path = '/event/{id}';

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

    # path params
    if ( exists $args{'id'}) {
        my $_base_variable = "{" . "id" . "}";
        my $_base_value = $self->{api_client}->to_path_value($args{'id'});
        $_resource_path =~ s/$_base_variable/$_base_value/g;
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
# event_getsessionsbydate
#
# View a list of courses by date
# 
# @param string $location The location to filter the events. (optional)
# @param DateTime $date The date to filter the events. Today will be used if this parameter is omitted. (optional)
# @param string $type Type of event to list. (optional)
{
    my $params = {
    'location' => {
        data_type => 'string',
        description => 'The location to filter the events.',
        required => '0',
    },
    'date' => {
        data_type => 'DateTime',
        description => 'The date to filter the events. Today will be used if this parameter is omitted.',
        required => '0',
    },
    'type' => {
        data_type => 'string',
        description => 'Type of event to list.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'event_getsessionsbydate' } = { 
        summary => 'View a list of courses by date',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub event_getsessionsbydate {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/event/getsessionsbydate';

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
    if ( exists $args{'location'}) {
        $query_params->{'location'} = $self->{api_client}->to_query_value($args{'location'});
    }

    # query params
    if ( exists $args{'date'}) {
        $query_params->{'date'} = $self->{api_client}->to_query_value($args{'date'});
    }

    # query params
    if ( exists $args{'type'}) {
        $query_params->{'type'} = $self->{api_client}->to_query_value($args{'type'});
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
# event_list
#
# View a list of courses
# 
# @param string $from The first record to return. (required)
# @param string $count The max number of records to return. (required)
# @param boolean $summaryonly True to return only the event information and not the associated schedule, dept, etc. Defaults to false. (optional)
# @param string $termid Id of the term to list the events. Null to list all events. (optional)
{
    my $params = {
    'from' => {
        data_type => 'string',
        description => 'The first record to return.',
        required => '1',
    },
    'count' => {
        data_type => 'string',
        description => 'The max number of records to return.',
        required => '1',
    },
    'summaryonly' => {
        data_type => 'boolean',
        description => 'True to return only the event information and not the associated schedule, dept, etc. Defaults to false.',
        required => '0',
    },
    'termid' => {
        data_type => 'string',
        description => 'Id of the term to list the events. Null to list all events.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'event_list' } = { 
        summary => 'View a list of courses',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub event_list {
    my ($self, %args) = @_;

    # verify the required parameter 'from' is set
    unless (exists $args{'from'}) {
      croak("Missing the required parameter 'from' when calling event_list");
    }

    # verify the required parameter 'count' is set
    unless (exists $args{'count'}) {
      croak("Missing the required parameter 'count' when calling event_list");
    }

    # parse inputs
    my $_resource_path = '/event/list';

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
    if ( exists $args{'from'}) {
        $query_params->{'from'} = $self->{api_client}->to_query_value($args{'from'});
    }

    # query params
    if ( exists $args{'count'}) {
        $query_params->{'count'} = $self->{api_client}->to_query_value($args{'count'});
    }

    # query params
    if ( exists $args{'summaryonly'}) {
        $query_params->{'summaryonly'} = $self->{api_client}->to_query_value($args{'summaryonly'});
    }

    # query params
    if ( exists $args{'termid'}) {
        $query_params->{'termid'} = $self->{api_client}->to_query_value($args{'termid'});
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
# event_save
#
# Create or edit a course
# 
# @param string $id The id of the event to save (leave empty to create a new one). (required)
# @param UNKNOWN_BASE_TYPE $unknown_base_type  (optional)
{
    my $params = {
    'id' => {
        data_type => 'string',
        description => 'The id of the event to save (leave empty to create a new one).',
        required => '1',
    },
    'unknown_base_type' => {
        data_type => 'UNKNOWN_BASE_TYPE',
        description => '',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'event_save' } = { 
        summary => 'Create or edit a course',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub event_save {
    my ($self, %args) = @_;

    # verify the required parameter 'id' is set
    unless (exists $args{'id'}) {
      croak("Missing the required parameter 'id' when calling event_save");
    }

    # parse inputs
    my $_resource_path = '/event/{id}';

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

    # path params
    if ( exists $args{'id'}) {
        my $_base_variable = "{" . "id" . "}";
        my $_base_value = $self->{api_client}->to_path_value($args{'id'});
        $_resource_path =~ s/$_base_variable/$_base_value/g;
    }

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
# event_searchgroup
#
# Searches for the available event groups
# 
# @param string $query Query to search event groups. (required)
{
    my $params = {
    'query' => {
        data_type => 'string',
        description => 'Query to search event groups.',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'event_searchgroup' } = { 
        summary => 'Searches for the available event groups',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub event_searchgroup {
    my ($self, %args) = @_;

    # verify the required parameter 'query' is set
    unless (exists $args{'query'}) {
      croak("Missing the required parameter 'query' when calling event_searchgroup");
    }

    # parse inputs
    my $_resource_path = '/event/searchgroup';

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
    if ( exists $args{'query'}) {
        $query_params->{'query'} = $self->{api_client}->to_query_value($args{'query'});
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

1;
