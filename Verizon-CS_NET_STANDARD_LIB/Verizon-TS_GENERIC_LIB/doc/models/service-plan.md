
# Service Plan

Details of the service plan.

*This model accepts additional fields of type unknown.*

## Structure

`ServicePlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `carrierServicePlanCode` | `string \| undefined` | Optional | The code that is used by the carrier for the service plan. |
| `code` | `string \| undefined` | Optional | The code of the service plan, which may not be the same as the name. |
| `extendedAttributes` | [`CustomFields[] \| undefined`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the service plan, as Key and Value pairs. |
| `name` | `string \| undefined` | Optional | The name of the service plan. |
| `sizeKb` | `bigint \| undefined` | Optional | The size of the service plan in kilobytes. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "name": "2MSHR5GB",
  "code": "M2MSHR5GB",
  "sizeKb": 0,
  "carrierServicePlanCode": "84638",
  "extendedAttributes": [
    {
      "key": "key8",
      "value": "value0",
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

