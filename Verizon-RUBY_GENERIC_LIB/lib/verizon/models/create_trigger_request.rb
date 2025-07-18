# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # CreateTriggerRequest Model.
  class CreateTriggerRequest < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :account_name

    # The details of the UsageAnomaly trigger.
    # @return [AnomalyTriggerRequest]
    attr_accessor :anomaly_trigger_request

    # The details of the UsageAnomaly trigger.
    # @return [DataTriggerRequest]
    attr_accessor :data_trigger_request

    # The details of the UsageAnomaly trigger.
    # @return [String]
    attr_accessor :group_name

    # The details of the UsageAnomaly trigger.
    # @return [String]
    attr_accessor :name

    # The details of the UsageAnomaly trigger.
    # @return [SessionTriggerRequest]
    attr_accessor :session_trigger_request

    # The details of the UsageAnomaly trigger.
    # @return [SmsTriggerRequest]
    attr_accessor :sms_trigger_request

    # The details of the UsageAnomaly trigger.
    # @return [String]
    attr_accessor :trigger_category

    # The details of the UsageAnomaly trigger.
    # @return [String]
    attr_accessor :trigger_cycle

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_name'] = 'accountName'
      @_hash['anomaly_trigger_request'] = 'anomalyTriggerRequest'
      @_hash['data_trigger_request'] = 'dataTriggerRequest'
      @_hash['group_name'] = 'groupName'
      @_hash['name'] = 'name'
      @_hash['session_trigger_request'] = 'sessionTriggerRequest'
      @_hash['sms_trigger_request'] = 'smsTriggerRequest'
      @_hash['trigger_category'] = 'triggerCategory'
      @_hash['trigger_cycle'] = 'triggerCycle'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        account_name
        anomaly_trigger_request
        data_trigger_request
        group_name
        name
        session_trigger_request
        sms_trigger_request
        trigger_category
        trigger_cycle
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_name: SKIP, anomaly_trigger_request: SKIP,
                   data_trigger_request: SKIP, group_name: SKIP, name: SKIP,
                   session_trigger_request: SKIP, sms_trigger_request: SKIP,
                   trigger_category: SKIP, trigger_cycle: SKIP)
      @account_name = account_name unless account_name == SKIP
      @anomaly_trigger_request = anomaly_trigger_request unless anomaly_trigger_request == SKIP
      @data_trigger_request = data_trigger_request unless data_trigger_request == SKIP
      @group_name = group_name unless group_name == SKIP
      @name = name unless name == SKIP
      @session_trigger_request = session_trigger_request unless session_trigger_request == SKIP
      @sms_trigger_request = sms_trigger_request unless sms_trigger_request == SKIP
      @trigger_category = trigger_category unless trigger_category == SKIP
      @trigger_cycle = trigger_cycle unless trigger_cycle == SKIP
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      account_name = hash.key?('accountName') ? hash['accountName'] : SKIP
      anomaly_trigger_request = AnomalyTriggerRequest.from_hash(hash['anomalyTriggerRequest']) if
        hash['anomalyTriggerRequest']
      data_trigger_request = DataTriggerRequest.from_hash(hash['dataTriggerRequest']) if
        hash['dataTriggerRequest']
      group_name = hash.key?('groupName') ? hash['groupName'] : SKIP
      name = hash.key?('name') ? hash['name'] : SKIP
      session_trigger_request = SessionTriggerRequest.from_hash(hash['sessionTriggerRequest']) if
        hash['sessionTriggerRequest']
      sms_trigger_request = SmsTriggerRequest.from_hash(hash['smsTriggerRequest']) if
        hash['smsTriggerRequest']
      trigger_category =
        hash.key?('triggerCategory') ? hash['triggerCategory'] : SKIP
      trigger_cycle = hash.key?('triggerCycle') ? hash['triggerCycle'] : SKIP

      # Create object from extracted values.
      CreateTriggerRequest.new(account_name: account_name,
                               anomaly_trigger_request: anomaly_trigger_request,
                               data_trigger_request: data_trigger_request,
                               group_name: group_name,
                               name: name,
                               session_trigger_request: session_trigger_request,
                               sms_trigger_request: sms_trigger_request,
                               trigger_category: trigger_category,
                               trigger_cycle: trigger_cycle)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name}, anomaly_trigger_request:"\
      " #{@anomaly_trigger_request}, data_trigger_request: #{@data_trigger_request}, group_name:"\
      " #{@group_name}, name: #{@name}, session_trigger_request: #{@session_trigger_request},"\
      " sms_trigger_request: #{@sms_trigger_request}, trigger_category: #{@trigger_category},"\
      " trigger_cycle: #{@trigger_cycle}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name.inspect}, anomaly_trigger_request:"\
      " #{@anomaly_trigger_request.inspect}, data_trigger_request:"\
      " #{@data_trigger_request.inspect}, group_name: #{@group_name.inspect}, name:"\
      " #{@name.inspect}, session_trigger_request: #{@session_trigger_request.inspect},"\
      " sms_trigger_request: #{@sms_trigger_request.inspect}, trigger_category:"\
      " #{@trigger_category.inspect}, trigger_cycle: #{@trigger_cycle.inspect}>"
    end
  end
end
