
# V1 List of Licenses to Remove Result

List of licenses assigned.

*This model accepts additional fields of type Any.*

## Structure

`V1ListOfLicensesToRemoveResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `count` | `int` | Optional | The total number of devices on the cancellation candidate list. |
| `device_list` | `List[str]` | Optional | The IMEIs of the devices. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "count": 2,
  "deviceList": [
    "900000000000001",
    "900000000000999"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

