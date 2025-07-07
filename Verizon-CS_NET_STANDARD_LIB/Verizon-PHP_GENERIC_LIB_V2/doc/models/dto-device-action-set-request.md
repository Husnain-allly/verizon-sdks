
# Dto Device Action Set Request

*This model accepts additional fields of type array.*

## Structure

`DtoDeviceActionSetRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `configuration` | [`?DtoDeviceActionSetConfiguration`](../../doc/models/dto-device-action-set-configuration.md) | Optional | - | getConfiguration(): ?DtoDeviceActionSetConfiguration | setConfiguration(?DtoDeviceActionSetConfiguration configuration): void |
| `resourceidentifier` | [`?DtoDeviceResourceIdentifier`](../../doc/models/dto-device-resource-identifier.md) | Optional | Device identifiers, one or more are required | getResourceidentifier(): ?DtoDeviceResourceIdentifier | setResourceidentifier(?DtoDeviceResourceIdentifier resourceidentifier): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

