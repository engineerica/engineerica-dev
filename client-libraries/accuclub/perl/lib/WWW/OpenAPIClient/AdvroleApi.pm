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
package WWW::OpenAPIClient::AdvroleApi;

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
# advrole_addmissing
#
# Adds the missing permissions to a role. Requires access to advrole.save
# 
# @param string $roles CSV list of the role ids to check (required)
# @param string $permissions CSV list of the permissions to check (required)
{
    my $params = {
    'roles' => {
        data_type => 'string',
        description => 'CSV list of the role ids to check',
        required => '1',
    },
    'permissions' => {
        data_type => 'string',
        description => 'CSV list of the permissions to check',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'advrole_addmissing' } = { 
        summary => 'Adds the missing permissions to a role. Requires access to advrole.save',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_addmissing {
    my ($self, %args) = @_;

    # verify the required parameter 'roles' is set
    unless (exists $args{'roles'}) {
      croak("Missing the required parameter 'roles' when calling advrole_addmissing");
    }

    # verify the required parameter 'permissions' is set
    unless (exists $args{'permissions'}) {
      croak("Missing the required parameter 'permissions' when calling advrole_addmissing");
    }

    # parse inputs
    my $_resource_path = '/advrole/addmissing';

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
    if ( exists $args{'roles'}) {
        $query_params->{'roles'} = $self->{api_client}->to_query_value($args{'roles'});
    }

    # query params
    if ( exists $args{'permissions'}) {
        $query_params->{'permissions'} = $self->{api_client}->to_query_value($args{'permissions'});
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
# advrole_checkperm
#
# Checks the permissions are assigned for the given roles
# 
# @param string $roles CSV list of the role ids to check (required)
# @param string $permissions CSV list of the permissions to check (required)
{
    my $params = {
    'roles' => {
        data_type => 'string',
        description => 'CSV list of the role ids to check',
        required => '1',
    },
    'permissions' => {
        data_type => 'string',
        description => 'CSV list of the permissions to check',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'advrole_checkperm' } = { 
        summary => 'Checks the permissions are assigned for the given roles',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_checkperm {
    my ($self, %args) = @_;

    # verify the required parameter 'roles' is set
    unless (exists $args{'roles'}) {
      croak("Missing the required parameter 'roles' when calling advrole_checkperm");
    }

    # verify the required parameter 'permissions' is set
    unless (exists $args{'permissions'}) {
      croak("Missing the required parameter 'permissions' when calling advrole_checkperm");
    }

    # parse inputs
    my $_resource_path = '/advrole/checkperm';

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
    if ( exists $args{'roles'}) {
        $query_params->{'roles'} = $self->{api_client}->to_query_value($args{'roles'});
    }

    # query params
    if ( exists $args{'permissions'}) {
        $query_params->{'permissions'} = $self->{api_client}->to_query_value($args{'permissions'});
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
# advrole_delete
#
# Delete a role
# 
# @param string $id The id of the location to delete. (required)
# @param AnyType $body  (optional)
{
    my $params = {
    'id' => {
        data_type => 'string',
        description => 'The id of the location to delete.',
        required => '1',
    },
    'body' => {
        data_type => 'AnyType',
        description => '',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'advrole_delete' } = { 
        summary => 'Delete a role',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_delete {
    my ($self, %args) = @_;

    # verify the required parameter 'id' is set
    unless (exists $args{'id'}) {
      croak("Missing the required parameter 'id' when calling advrole_delete");
    }

    # parse inputs
    my $_resource_path = '/advrole/{id}';

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
# advrole_deletemapping
#
# Delete a role mapping
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
    __PACKAGE__->method_documentation->{ 'advrole_deletemapping' } = { 
        summary => 'Delete a role mapping',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_deletemapping {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/advrole/deletemapping';

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
# advrole_get
#
# View details of a role
# 
# @param string $id The id of the location to get. (required)
{
    my $params = {
    'id' => {
        data_type => 'string',
        description => 'The id of the location to get.',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'advrole_get' } = { 
        summary => 'View details of a role',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_get {
    my ($self, %args) = @_;

    # verify the required parameter 'id' is set
    unless (exists $args{'id'}) {
      croak("Missing the required parameter 'id' when calling advrole_get");
    }

    # parse inputs
    my $_resource_path = '/advrole/{id}';

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
# advrole_list
#
# Lists the roles for the current account
# 
# @param boolean $includepolicies True to include the policies, defaults to false. (optional)
# @param boolean $includeinternal True to include the internal roles too. (optional)
# @param string $name Filter by name of the role. (optional)
{
    my $params = {
    'includepolicies' => {
        data_type => 'boolean',
        description => 'True to include the policies, defaults to false.',
        required => '0',
    },
    'includeinternal' => {
        data_type => 'boolean',
        description => 'True to include the internal roles too.',
        required => '0',
    },
    'name' => {
        data_type => 'string',
        description => 'Filter by name of the role.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'advrole_list' } = { 
        summary => 'Lists the roles for the current account',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_list {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/advrole/list';

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
    if ( exists $args{'includepolicies'}) {
        $query_params->{'includepolicies'} = $self->{api_client}->to_query_value($args{'includepolicies'});
    }

    # query params
    if ( exists $args{'includeinternal'}) {
        $query_params->{'includeinternal'} = $self->{api_client}->to_query_value($args{'includeinternal'});
    }

    # query params
    if ( exists $args{'name'}) {
        $query_params->{'name'} = $self->{api_client}->to_query_value($args{'name'});
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
# advrole_listmaps
#
# Lists the maps a roles is mapped to
# 
# @param string $roleid The id of the role to list the maps. (required)
{
    my $params = {
    'roleid' => {
        data_type => 'string',
        description => 'The id of the role to list the maps.',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'advrole_listmaps' } = { 
        summary => 'Lists the maps a roles is mapped to',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_listmaps {
    my ($self, %args) = @_;

    # verify the required parameter 'roleid' is set
    unless (exists $args{'roleid'}) {
      croak("Missing the required parameter 'roleid' when calling advrole_listmaps");
    }

    # parse inputs
    my $_resource_path = '/advrole/listmaps';

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
    if ( exists $args{'roleid'}) {
        $query_params->{'roleid'} = $self->{api_client}->to_query_value($args{'roleid'});
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
# advrole_listrolesmapped
#
# Lists the roles mappings
# 
# @param string $map List only the roles in the specified map. (optional)
{
    my $params = {
    'map' => {
        data_type => 'string',
        description => 'List only the roles in the specified map.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'advrole_listrolesmapped' } = { 
        summary => 'Lists the roles mappings',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_listrolesmapped {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/advrole/listrolesmapped';

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
    if ( exists $args{'map'}) {
        $query_params->{'map'} = $self->{api_client}->to_query_value($args{'map'});
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
# advrole_listtemplates
#
# View a list of role templates
# 
{
    my $params = {
    };
    __PACKAGE__->method_documentation->{ 'advrole_listtemplates' } = { 
        summary => 'View a list of role templates',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_listtemplates {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/advrole/listtemplates';

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
# advrole_save
#
# Create or edit a role
# 
# @param string $id The id of the role to save (leave empty to create a new one). (required)
# @param UNKNOWN_BASE_TYPE $unknown_base_type  (optional)
{
    my $params = {
    'id' => {
        data_type => 'string',
        description => 'The id of the role to save (leave empty to create a new one).',
        required => '1',
    },
    'unknown_base_type' => {
        data_type => 'UNKNOWN_BASE_TYPE',
        description => '',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'advrole_save' } = { 
        summary => 'Create or edit a role',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_save {
    my ($self, %args) = @_;

    # verify the required parameter 'id' is set
    unless (exists $args{'id'}) {
      croak("Missing the required parameter 'id' when calling advrole_save");
    }

    # parse inputs
    my $_resource_path = '/advrole/{id}';

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
# advrole_savemapping
#
# Saves a role mapping
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
    __PACKAGE__->method_documentation->{ 'advrole_savemapping' } = { 
        summary => 'Saves a role mapping',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_savemapping {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/advrole/savemapping';

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

#
# advrole_userupgrade
#
# Upgrade a user to another role (requires permission to edit those roles)
# 
# @param string $userid Id of the user to upgrade (required)
# @param string $roleid Id of the role to add (required)
{
    my $params = {
    'userid' => {
        data_type => 'string',
        description => 'Id of the user to upgrade',
        required => '1',
    },
    'roleid' => {
        data_type => 'string',
        description => 'Id of the role to add',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'advrole_userupgrade' } = { 
        summary => 'Upgrade a user to another role (requires permission to edit those roles)',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub advrole_userupgrade {
    my ($self, %args) = @_;

    # verify the required parameter 'userid' is set
    unless (exists $args{'userid'}) {
      croak("Missing the required parameter 'userid' when calling advrole_userupgrade");
    }

    # verify the required parameter 'roleid' is set
    unless (exists $args{'roleid'}) {
      croak("Missing the required parameter 'roleid' when calling advrole_userupgrade");
    }

    # parse inputs
    my $_resource_path = '/advrole/userupgrade';

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
    if ( exists $args{'userid'}) {
        $query_params->{'userid'} = $self->{api_client}->to_query_value($args{'userid'});
    }

    # query params
    if ( exists $args{'roleid'}) {
        $query_params->{'roleid'} = $self->{api_client}->to_query_value($args{'roleid'});
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
