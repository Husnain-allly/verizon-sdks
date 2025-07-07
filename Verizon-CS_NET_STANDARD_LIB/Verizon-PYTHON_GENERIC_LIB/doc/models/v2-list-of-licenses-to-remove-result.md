
# V2 List of Licenses to Remove Result

List of created license cancellation devices.

*This model accepts additional fields of type Any.*

## Structure

`V2ListOfLicensesToRemoveResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `count` | `int` | Required | The number of devices. |
| `device_list` | `List[str]` | Required | Device IMEI list. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
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

