
# V3 Software Info

Software information.

*This model accepts additional fields of type unknown.*

## Structure

`V3SoftwareInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string` | Required | Software name. |
| `version` | `string` | Required | Software version. |
| `upgradeTime` | `string` | Required | Upgrade time. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

