
# Account Device List Filter

Filter for a list of devices.

*This model accepts additional fields of type Object.*

## Structure

`AccountDeviceListFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_identifier_filters` | [`Array<DeviceIdSearch>`](../../doc/models/device-id-search.md) | Required | Specify the kind of the device identifier, the type of match, and the string that you want to match. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceIdentifierFilters": [
    {
      "kind": "iccid",
      "contains": "4259",
      "startswith": "startswith8",
      "endswith": "endswith0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

