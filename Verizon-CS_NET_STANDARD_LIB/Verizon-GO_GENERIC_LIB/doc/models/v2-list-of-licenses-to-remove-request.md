
# V2 List of Licenses to Remove Request

License cancellation candidate devices.

*This model accepts additional fields of type interface{}.*

## Structure

`V2ListOfLicensesToRemoveRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `*string` | Optional | List creation option. |
| `Count` | `*int` | Optional | The number of devices. |
| `DeviceList` | `[]string` | Required | Device IMEI list. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "type": "append",
  "count": 2,
  "deviceList": [
    "990003425730535",
    "990000473475989"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

