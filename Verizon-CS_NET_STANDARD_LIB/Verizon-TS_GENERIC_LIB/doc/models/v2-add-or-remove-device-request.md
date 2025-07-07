
# V2 Add or Remove Device Request

Add or remove device to existing software upgrade information.

*This model accepts additional fields of type unknown.*

## Structure

`V2AddOrRemoveDeviceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | `string` | Required | Operation either 'append' or 'remove'. |
| `deviceList` | `string[]` | Required | Device IMEI list. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

