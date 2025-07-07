
# M 5G Bidevice Id

*This model accepts additional fields of type unknown.*

## Structure

`M5GBideviceId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceId` | [`M5GBideviceId1 \| undefined`](../../doc/models/m-5g-bidevice-id-1.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": {
    "id": "id0",
    "kind": "kind8",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

