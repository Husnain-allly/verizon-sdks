
# V2 Software Info

Software information.

*This model accepts additional fields of type Any.*

## Structure

`V2SoftwareInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `str` | Required | Software name. |
| `version` | `str` | Required | Software version. |
| `upgrade_time` | `str` | Required | Upgrade time. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

