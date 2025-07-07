
# V3 Software Info

Software information.

*This model accepts additional fields of type interface{}.*

## Structure

`V3SoftwareInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Software name. |
| `Version` | `string` | Required | Software version. |
| `UpgradeTime` | `string` | Required | Upgrade time. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "name": "VZ_MDM_IOT",
  "version": "0.14",
  "upgradeTime": "2012-04-23T18:25:43.511Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

