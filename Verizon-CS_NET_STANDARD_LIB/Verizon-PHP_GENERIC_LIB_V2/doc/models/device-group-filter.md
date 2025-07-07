
# Device Group Filter

*This model accepts additional fields of type array.*

## Structure

`DeviceGroupFilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceGroupName` | `?string` | Optional | - | getDeviceGroupName(): ?string | setDeviceGroupName(?string deviceGroupName): void |
| `individualOrCombined` | `?string` | Optional | - | getIndividualOrCombined(): ?string | setIndividualOrCombined(?string individualOrCombined): void |
| `accountName` | `?string` | Optional | The numeric name of the account and must include leading zeroes | getAccountName(): ?string | setAccountName(?string accountName): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceGroupName": "User defined group name",
  "IndividualOrCombined": "Combined",
  "accountName": "0000123456-00001",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

