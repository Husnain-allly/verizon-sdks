# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # RbsHighPrecisionTiltConfig Model.
  class RbsHighPrecisionTiltConfig < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # the reporting mode of the tilt sensor
    # @return [Mode]
    attr_accessor :mode

    # The units and values of the time interval for the sensor to send a report
    # @return [PeriodicReporting]
    attr_accessor :periodic_reporting

    # The time the threshold condition exists, in milliseconds, to recognize an
    # event
    # @return [Integer]
    attr_accessor :hold_time

    # the threshold value, from verticle, to recognize an event
    # @return [Integer]
    attr_accessor :angle_away

    # the threshold value, moving towards  verticle, to recognize an event
    # @return [Integer]
    attr_accessor :angle_toward

    # the threshold value, moving towards  verticle, to recognize an event
    # @return [Tscore]
    attr_accessor :tscore

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['mode'] = 'mode'
      @_hash['periodic_reporting'] = 'periodic-reporting'
      @_hash['hold_time'] = 'hold-time'
      @_hash['angle_away'] = 'angle-away'
      @_hash['angle_toward'] = 'angle-toward'
      @_hash['tscore'] = 'tscore'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        mode
        periodic_reporting
        hold_time
        angle_away
        angle_toward
        tscore
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(mode: SKIP, periodic_reporting: SKIP, hold_time: SKIP,
                   angle_away: SKIP, angle_toward: SKIP, tscore: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @mode = mode unless mode == SKIP
      @periodic_reporting = periodic_reporting unless periodic_reporting == SKIP
      @hold_time = hold_time unless hold_time == SKIP
      @angle_away = angle_away unless angle_away == SKIP
      @angle_toward = angle_toward unless angle_toward == SKIP
      @tscore = tscore unless tscore == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      mode = hash.key?('mode') ? hash['mode'] : SKIP
      periodic_reporting = PeriodicReporting.from_hash(hash['periodic-reporting']) if
        hash['periodic-reporting']
      hold_time = hash.key?('hold-time') ? hash['hold-time'] : SKIP
      angle_away = hash.key?('angle-away') ? hash['angle-away'] : SKIP
      angle_toward = hash.key?('angle-toward') ? hash['angle-toward'] : SKIP
      tscore = Tscore.from_hash(hash['tscore']) if hash['tscore']

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      RbsHighPrecisionTiltConfig.new(mode: mode,
                                     periodic_reporting: periodic_reporting,
                                     hold_time: hold_time,
                                     angle_away: angle_away,
                                     angle_toward: angle_toward,
                                     tscore: tscore,
                                     additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} mode: #{@mode}, periodic_reporting: #{@periodic_reporting}, hold_time:"\
      " #{@hold_time}, angle_away: #{@angle_away}, angle_toward: #{@angle_toward}, tscore:"\
      " #{@tscore}, additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} mode: #{@mode.inspect}, periodic_reporting: #{@periodic_reporting.inspect},"\
      " hold_time: #{@hold_time.inspect}, angle_away: #{@angle_away.inspect}, angle_toward:"\
      " #{@angle_toward.inspect}, tscore: #{@tscore.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
