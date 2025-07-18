# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Status of the MEC Platform (default is 'unknown')
  class MecPlatformStatus
    MEC_PLATFORM_STATUS = [
      # TODO: Write general description for ACTIVE
      ACTIVE = 'Active'.freeze,

      # TODO: Write general description for INACTIVE
      INACTIVE = 'Inactive'.freeze,

      # TODO: Write general description for UNKNOWN
      UNKNOWN = 'unknown'.freeze
    ].freeze

    def self.validate(value)
      return false if value.nil?

      MEC_PLATFORM_STATUS.include?(value)
    end
  end
end
