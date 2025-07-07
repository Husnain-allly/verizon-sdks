
# V3 Software Info

Software information.

*This model accepts additional fields of type Any.*

## Structure

`V3SoftwareInfo`

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
  "name": "VZ_MDM_IOT",
  "version": "0.14",
  "upgradeTime": "2012-04-23T18:25:43.511Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

