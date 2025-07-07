
# Device Filter

Specify the kind of the device identifier, the type of match, and the string that you want to match.

*This model accepts additional fields of type Any.*

## Structure

`DeviceFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `str` | Optional | The the billing account that the devices belong to. |
| `group_name` | `str` | Optional | Only include devices that are in this device group. |
| `service_plan` | `str` | Optional | Only include devices that have this service plan. |
| `custom_fields` | [`List[CustomFields]`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "groupName": "Short-Haul Trucks",
  "customFields": [
    {
      "key": "CustomField1",
      "value": "East Region Trucks",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "account": "account8",
  "servicePlan": "servicePlan2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

