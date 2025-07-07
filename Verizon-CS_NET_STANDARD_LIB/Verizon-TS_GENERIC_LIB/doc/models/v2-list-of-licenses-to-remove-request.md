
# V2 List of Licenses to Remove Request

License cancellation candidate devices.

*This model accepts additional fields of type unknown.*

## Structure

`V2ListOfLicensesToRemoveRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | `string \| undefined` | Optional | List creation option. |
| `count` | `number \| undefined` | Optional | The number of devices. |
| `deviceList` | `string[]` | Required | Device IMEI list. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

