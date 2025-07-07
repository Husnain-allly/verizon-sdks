
# Pwn Device List

*This model accepts additional fields of type array.*

## Structure

`PwnDeviceList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceIds` | [`PwnDeviceId[]`](../../doc/models/pwn-device-id.md) | Required | - | getDeviceIds(): array | setDeviceIds(array deviceIds): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "id": "99948099913024600001",
      "kind": "iccid",
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

