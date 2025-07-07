
# Fall Back

*This model accepts additional fields of type array.*

## Structure

`FallBack`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `devices` | [`?(DeviceIdarray[][])`](../../doc/models/device-idarray.md) | Optional | An array containing the `deviceId` array.<br><br>**Constraints**: *Maximum Items*: `100` | getDevices(): ?array | setDevices(?array devices): void |
| `accountName` | `?string` | Optional | The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` | getAccountName(): ?string | setAccountName(?string accountName): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "devices": [
    [
      {
        "kind": "kind2",
        "id": "id4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "kind": "kind2",
        "id": "id4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ],
    [
      {
        "kind": "kind2",
        "id": "id4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "kind": "kind2",
        "id": "id4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ]
  ],
  "accountName": "accountName4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

