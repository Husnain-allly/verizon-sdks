
# V1 List of Licenses to Remove Result

List of licenses assigned.

*This model accepts additional fields of type unknown.*

## Structure

`V1ListOfLicensesToRemoveResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `count` | `number \| undefined` | Optional | The total number of devices on the cancellation candidate list. |
| `deviceList` | `string[] \| undefined` | Optional | The IMEIs of the devices. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

