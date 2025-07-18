
# Aggregate Usage Item

Contains usage information per device.

*This model accepts additional fields of type unknown.*

## Structure

`AggregateUsageItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `imei` | `string \| undefined` | Optional | International Mobile Equipment Identifier. This is the ID of the device reporting usage. |
| `numberOfSessions` | `number \| undefined` | Optional | Number of sessions established by the device reporting usage. |
| `bytesTransferred` | `number \| undefined` | Optional | The amount of data transferred by the device reporting usage, measured in Bytes. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "imei": "709312034493372",
  "numberOfSessions": 1,
  "bytesTransferred": 2057,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

