
# Device Filter

Specify the kind of the device identifier, the type of match, and the string that you want to match.

*This model accepts additional fields of type unknown.*

## Structure

`DeviceFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string \| undefined` | Optional | The the billing account that the devices belong to. |
| `groupName` | `string \| undefined` | Optional | Only include devices that are in this device group. |
| `servicePlan` | `string \| undefined` | Optional | Only include devices that have this service plan. |
| `customFields` | [`CustomFields[] \| undefined`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

