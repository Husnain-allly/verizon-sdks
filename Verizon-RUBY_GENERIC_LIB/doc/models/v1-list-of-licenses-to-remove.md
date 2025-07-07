
# V1 List of Licenses to Remove

List of cancellation candidate devices.

*This model accepts additional fields of type Object.*

## Structure

`V1ListOfLicensesToRemove`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `count` | `Integer` | Optional | The total number of devices on the list. |
| `has_more_data` | `TrueClass \| FalseClass` | Optional | True if there are more devices to retrieve. |
| `update_time` | `DateTime` | Optional | The date and time that the list was last updated. |
| `device_list` | `Array<String>` | Optional | The IMEIs of the devices. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "count": 6,
  "hasMoreData": false,
  "updateTime": "2018-03-22T12:06:06.000Z",
  "deviceList": [
    "990003425730535",
    "990000473475989",
    "990005733420535",
    "990000347475989",
    "990007303425535",
    "990007590473489"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

