
# M 5G Bidevice Idarray

*This model accepts additional fields of type unknown.*

## Structure

`M5GBideviceIdarray`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceId` | [`M5GBideviceIdarrayDeviceId[] \| undefined`](../../doc/models/containers/m-5g-bidevice-idarray-device-id.md) | Optional | This is Array of a container for any-of cases. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": [
    {
      "id": "id0",
      "kind": "kind8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

