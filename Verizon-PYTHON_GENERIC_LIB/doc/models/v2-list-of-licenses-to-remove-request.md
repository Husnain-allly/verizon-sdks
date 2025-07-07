
# V2 List of Licenses to Remove Request

License cancellation candidate devices.

*This model accepts additional fields of type Any.*

## Structure

`V2ListOfLicensesToRemoveRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mtype` | `str` | Optional | List creation option. |
| `count` | `int` | Optional | The number of devices. |
| `device_list` | `List[str]` | Required | Device IMEI list. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

