
# V2 Add or Remove Device Request

Add or remove device to existing software upgrade information.

*This model accepts additional fields of type object.*

## Structure

`V2AddOrRemoveDeviceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | Operation either 'append' or 'remove'. |
| `DeviceList` | `List<string>` | Required | Device IMEI list. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "Type": "remove",
  "deviceList": [
    "990013907884259",
    "990013907835573",
    "990013907833575"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

