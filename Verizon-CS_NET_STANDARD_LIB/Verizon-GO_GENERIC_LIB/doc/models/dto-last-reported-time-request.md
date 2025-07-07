
# Dto Last Reported Time Request

*This model accepts additional fields of type interface{}.*

## Structure

`DtoLastReportedTimeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountname` | `*string` | Optional | The numeric account name, which must include leading zeros |
| `Resourceidentifier` | [`*models.DtoDeviceResourceIdentifier`](../../doc/models/dto-device-resource-identifier.md) | Optional | Device identifiers, one or more are required |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
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

