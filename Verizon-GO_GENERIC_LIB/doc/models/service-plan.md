
# Service Plan

Details of the service plan.

*This model accepts additional fields of type interface{}.*

## Structure

`ServicePlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CarrierServicePlanCode` | `*string` | Optional | The code that is used by the carrier for the service plan. |
| `Code` | `*string` | Optional | The code of the service plan, which may not be the same as the name. |
| `ExtendedAttributes` | [`[]models.CustomFields`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the service plan, as Key and Value pairs. |
| `Name` | `*string` | Optional | The name of the service plan. |
| `SizeKb` | `*int64` | Optional | The size of the service plan in kilobytes. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

