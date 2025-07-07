
# V1 Licenses Assigned Removed Request

IMEIs of the devices to assign licenses to.

*This model accepts additional fields of type interface{}.*

## Structure

`V1LicensesAssignedRemovedRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceList` | `[]string` | Required | The IMEIs of the devices. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "deviceList": [
    "900000000000001",
    "900000000000998",
    "900000000000999"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

