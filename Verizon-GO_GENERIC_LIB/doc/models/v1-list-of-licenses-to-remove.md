
# V1 List of Licenses to Remove

List of cancellation candidate devices.

*This model accepts additional fields of type interface{}.*

## Structure

`V1ListOfLicensesToRemove`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Count` | `*int` | Optional | The total number of devices on the list. |
| `HasMoreData` | `*bool` | Optional | True if there are more devices to retrieve. |
| `UpdateTime` | `*time.Time` | Optional | The date and time that the list was last updated. |
| `DeviceList` | `[]string` | Optional | The IMEIs of the devices. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

