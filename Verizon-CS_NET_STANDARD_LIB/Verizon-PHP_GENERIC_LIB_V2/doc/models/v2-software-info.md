
# V2 Software Info

Software information.

*This model accepts additional fields of type array.*

## Structure

`V2SoftwareInfo`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | `string` | Required | Software name. | getName(): string | setName(string name): void |
| `version` | `string` | Required | Software version. | getVersion(): string | setVersion(string version): void |
| `upgradeTime` | `string` | Required | Upgrade time. | getUpgradeTime(): string | setUpgradeTime(string upgradeTime): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "name": "FOTA_Verizon_Model-A_02To03_HF",
  "version": "3",
  "upgradeTime": "2020-09-08T19:00:51.541Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

