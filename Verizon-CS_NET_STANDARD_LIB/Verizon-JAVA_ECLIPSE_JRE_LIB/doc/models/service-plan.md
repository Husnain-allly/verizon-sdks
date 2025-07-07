
# Service Plan

Details of the service plan.

*This model accepts additional fields of type Object.*

## Structure

`ServicePlan`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `CarrierServicePlanCode` | `String` | Optional | The code that is used by the carrier for the service plan. | String getCarrierServicePlanCode() | setCarrierServicePlanCode(String carrierServicePlanCode) |
| `Code` | `String` | Optional | The code of the service plan, which may not be the same as the name. | String getCode() | setCode(String code) |
| `ExtendedAttributes` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the service plan, as Key and Value pairs. | List<CustomFields> getExtendedAttributes() | setExtendedAttributes(List<CustomFields> extendedAttributes) |
| `Name` | `String` | Optional | The name of the service plan. | String getName() | setName(String name) |
| `SizeKb` | `Long` | Optional | The size of the service plan in kilobytes. | Long getSizeKb() | setSizeKb(Long sizeKb) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

