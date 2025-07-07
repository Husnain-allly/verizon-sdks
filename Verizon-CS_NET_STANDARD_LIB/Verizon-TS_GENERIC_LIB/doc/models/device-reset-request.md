
# Device Reset Request

Request body to Performs a device reboot.

*This model accepts additional fields of type unknown.*

## Structure

`DeviceResetRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string \| undefined` | Optional | The name of the account. An account name is usually numeric, and must include any leading zeros. |
| `action` | `string \| undefined` | Optional | The action you want to take on the device. |
| `devices` | [`Device[] \| undefined`](../../doc/models/device.md) | Optional | The devices for which you want to perform a factory reset or reboot. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0642233522-00003",
  "action": "reboot",
  "devices": [
    {
      "id": "id4",
      "kind": "kind2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "id": "id4",
      "kind": "kind2",
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

