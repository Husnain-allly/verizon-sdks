
# Dm V1 Devices Actions Set Request

*This model accepts additional fields of type Object.*

## Structure

`DmV1DevicesActionsSetRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountname` | `String` | Optional | The numeric account name, which must include leading zeros | String getAccountname() | setAccountname(String accountname) |
| `Configuration` | [`DtoDeviceActionSetConfiguration1`](../../doc/models/dto-device-action-set-configuration-1.md) | Optional | - | DtoDeviceActionSetConfiguration1 getConfiguration() | setConfiguration(DtoDeviceActionSetConfiguration1 configuration) |
| `Resourceidentifier` | [`DtoDeviceResourceIdentifier1`](../../doc/models/dto-device-resource-identifier-1.md) | Optional | Device identifiers, one or more are required | DtoDeviceResourceIdentifier1 getResourceidentifier() | setResourceidentifier(DtoDeviceResourceIdentifier1 resourceidentifier) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "configuration": {
    "deviceConfig": {
      "ble": {
        "dataMode": 216,
        "manufacturerId": 180,
        "maxNumScan": 126,
        "minSigStr": 60,
        "monitorPeriod": 88,
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    },
    "RbsHighPrecisionTiltConfig": {
      "mode": "reportOnChange",
      "periodic-reporting": {
        "unit": "minutes",
        "hours": 250,
        "minutes": 232,
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "hold-time": 62,
      "angle-away": 90,
      "angle-toward": 30,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "resourceidentifier": {
    "deveui": "deveui2",
    "deviceid": "deviceid6",
    "esn": 86,
    "iccid": "iccid0",
    "imei": 2
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

