
# Service Plan

Details of the service plan.

*This model accepts additional fields of type Object.*

## Structure

`ServicePlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `carrier_service_plan_code` | `String` | Optional | The code that is used by the carrier for the service plan. |
| `code` | `String` | Optional | The code of the service plan, which may not be the same as the name. |
| `extended_attributes` | [`Array<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the service plan, as Key and Value pairs. |
| `name` | `String` | Optional | The name of the service plan. |
| `size_kb` | `Integer` | Optional | The size of the service plan in kilobytes. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

