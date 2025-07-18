# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # The type of the device's network connection at the time of the request. If
  # the device is on the Verizon cellular network it should use the "VZ" value
  # otherwise the "non-VZ" value. Devices on the Verizon network can directly
  # access the ETX Message Exchange on the MEC (Mobile Edge Compute server)
  class EtxNetworkType
    ETX_NETWORK_TYPE = [
      # TODO: Write general description for VZ
      VZ = 'VZ'.freeze,

      # TODO: Write general description for NONVZ
      NONVZ = 'non-VZ'.freeze
    ].freeze

    def self.validate(value)
      return false if value.nil?

      ETX_NETWORK_TYPE.include?(value)
    end
  end
end
