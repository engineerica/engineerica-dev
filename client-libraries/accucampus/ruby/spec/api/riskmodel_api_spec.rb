=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::RiskmodelApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'RiskmodelApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::RiskmodelApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of RiskmodelApi' do
    it 'should create an instance of RiskmodelApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::RiskmodelApi)
    end
  end

  # unit tests for riskmodel_checkanalysis
  # Check the status of the analysis of a specified risk assessment model
  # Allows the user to check the status of a risk assessment model as it is being processed.
  # @param id The id of the risk assessment model whose analysis status has to be returned.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'riskmodel_checkanalysis test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for riskmodel_delete
  # Delete a risk assessment model
  # Allows the user to delete a previously created risk assessment model.
  # @param id The id of the risk assessment model to delete.
  # @param [Hash] opts the optional parameters
  # @option opts [AnyType] :body 
  # @return [nil]
  describe 'riskmodel_delete test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for riskmodel_get
  # View details of a risk assessment model
  # Allows the user to view an individual risk assessment model and its details.
  # @param id The id of the risk assessment model to get.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'riskmodel_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for riskmodel_getscore
  # View the risk score for a specific user
  # Allows the user to view the risk score of another user.
  # @param userid The id of the user to get the risk score.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'riskmodel_getscore test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for riskmodel_list
  # View a list of risk assessment models
  # Allows the user to view the full list of risk assessment models.
  # @param from The first record to return.
  # @param count The max number of records to return.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'riskmodel_list test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for riskmodel_predict
  # Predict risk based on an assessment model
  # Allows a user to process a risk prediction from a risk assessment model that has processed.
  # @param id The id of the assessment model to use in order to predict risk.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'riskmodel_predict test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for riskmodel_process
  # Process a risk assessment model
  # Allows the user to process a risk assessment model once it has been created.
  # @param id The id of the risk assessment model to process.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'riskmodel_process test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for riskmodel_refresh
  # Refresh the information used in a risk assessment model
  # Allows the user to refresh a risk assessment model.
  # @param id The id of the risk assessment model whose information has to be refreshed.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'riskmodel_refresh test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for riskmodel_save
  # Create or edit a risk assessment model
  # Allows the user to create or edit a risk assessment model.
  # @param id The id of the department save (leave empty to create a new one).
  # @param [Hash] opts the optional parameters
  # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
  # @return [nil]
  describe 'riskmodel_save test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for riskmodel_termprecedences
  # View all default term precedences
  # Allows the user to view the default term precedences used in a model.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'riskmodel_termprecedences test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end