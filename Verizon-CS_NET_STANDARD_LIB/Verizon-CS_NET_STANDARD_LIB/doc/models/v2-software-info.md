
# V2 Software Info

Software information.

*This model accepts additional fields of type object.*

## Structure

`V2SoftwareInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Software name. |
| `Version` | `string` | Required | Software version. |
| `UpgradeTime` | `string` | Required | Upgrade time. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

